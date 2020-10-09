using KMeansProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ImageClassification
{
    public partial class Form1 : Form
    {
        private List<double[]> _trainingSet;
        private KMeans _kMeans;
        private BindingList<DPoint> _kmeansPointList;
        private Series _kMeansSeries;
        private string[] _files;
        public Form1()
        {
            InitializeComponent();
            _trainingSet = new List<double[]>();
            _kmeansPointList = new BindingList<DPoint>();

            _kMeansSeries = new Series("KMeans");
            _kMeansSeries.ChartType = SeriesChartType.Line;
            chart1.Series.Clear();
            chart1.Series.Add(_kMeansSeries);
            _kMeansSeries.XValueMember = "X";
            _kMeansSeries.YValueMembers = "Y";
            chart1.DataSource = _kmeansPointList;
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.SelectedPath = @"C:\Discover-Groups-Similar-Photos.zip\8. Discover Groups - Similar Photos\Data";
                if (fbd.ShowDialog()== DialogResult.OK)
                {
                    _files = Directory.GetFiles(fbd.SelectedPath);
                    BackgroundWorker objBackgroundWorker = new BackgroundWorker();
                    objBackgroundWorker.WorkerReportsProgress = true;
                    objBackgroundWorker.DoWork += (o, ea) =>
                    {
                        int i = 1;
                        foreach (string file in _files)
                        {
                            Bitmap bmpImage = ResizeImage(file, new Size(400, 200));
                            double[] processResult = GetAverageRGB(bmpImage);
                            _trainingSet.Add(processResult);
                            double percent = (100.0 * i) / _files.Length;
                            ((BackgroundWorker)o).ReportProgress((int)percent);
                            i++;
                        }
                    };
                    objBackgroundWorker.ProgressChanged += (o, ea) => { progressBar1.Value = ea.ProgressPercentage; };
                    objBackgroundWorker.RunWorkerAsync();
                }
            }
        }

        private void btnProcessData_Click(object sender, EventArgs e)
        {
            IDistance eucledeanDistance = new EuclideanDistance();

            BackgroundWorker backgroundWorker = new BackgroundWorker();
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.DoWork += (o, eventArgs) =>
            {
                for (int k = (int)start.Value; k <= (int)end.Value; k++)
                {
                    List<double[]> distanceResult = new List<double[]>();

                    _kMeans = new KMeans(k, eucledeanDistance);
                    Centroid[] centroids = _kMeans.Run(_trainingSet.ToArray());

                    double result = 0;
                    foreach (double[] point in _trainingSet)
                    {
                        double minValue = Double.MaxValue;
                        foreach (Centroid centroid in centroids)
                        {
                            double distance = eucledeanDistance.Run(point, centroid.Array);
                            if (distance < minValue)
                                minValue = distance;
                        }
                        result += minValue;
                    }
                    result /= _trainingSet.Count;
                    _kmeansPointList.Add(new DPoint(k, result));

                    double progressPercent = (100 * k) / (int)end.Value;
                    ((BackgroundWorker)o).ReportProgress((int)progressPercent, new UserState { Distortion = result, Index = k });
                }
            };
            backgroundWorker.ProgressChanged += (o, eventArgsProgressChanged) =>
            {
                chart1.DataBind();
                progressBar1.Value = eventArgsProgressChanged.ProgressPercentage;
                UserState temp = eventArgsProgressChanged.UserState as UserState;
                listBox1.Items.Add(String.Format("K={0}, Dist: {1}", temp.Index, Math.Round(temp.Distortion, 2)));
            };
            backgroundWorker.RunWorkerAsync();
        }

        Bitmap ResizeImage(string file, Size size)
        {
            return new Bitmap(Image.FromFile(file), size);
        }
        double[] GetAverageRGB(Bitmap bmpImage)
        {
            double[] result = new double[3];
            int numberOfPixlels = 0;

            for (int i = 0; i < bmpImage.Width; i++)
            {
                for (int j = 0; j < bmpImage.Height; j++)
                {
                    Color c = bmpImage.GetPixel(i, j);
                    result[0] += c.R;
                    result[1] += c.G;
                    result[2] += c.B;
                    numberOfPixlels++;
                }
            }

            bmpImage.Dispose();

            result[0] /= numberOfPixlels;
            result[1] /= numberOfPixlels;
            result[2] /= numberOfPixlels;
            return result;
        }

        private Centroid[] _centroids;
        private void btnTrain_Click(object sender, EventArgs e)
        {
            _kMeans = new KMeans((int)nClusters.Value, new EuclideanDistance());
            _centroids = _kMeans.Run(_trainingSet.ToArray());
            MessageBox.Show("Training is done!");
        }

        private void btnPresentResults_Click(object sender, EventArgs e)
        {
            frmPresenter presenter = new frmPresenter();
            int cluster = 0;
            foreach (Centroid c in _centroids)
            {
                presenter.AddList(String.Format("Cluster: {0}",cluster));
                cluster++;
            }

            foreach (string file in _files)
            {
                Bitmap bmpImage = ResizeImage(file, new Size(400, 200));
                double[] processResult = GetAverageRGB(bmpImage);
                int clusterIndex = _kMeans.Classify(processResult);
                presenter.AddItemToList(clusterIndex, file);
            }

            presenter.Show();
        }
    }
}
