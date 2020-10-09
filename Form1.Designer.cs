namespace ImageClassification
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.end = new System.Windows.Forms.NumericUpDown();
            this.start = new System.Windows.Forms.NumericUpDown();
            this.btnProcessData = new System.Windows.Forms.Button();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.btnTrain = new System.Windows.Forms.Button();
            this.nClusters = new System.Windows.Forms.NumericUpDown();
            this.btnPresentResults = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.end)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nClusters)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Top;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(708, 394);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar1.Location = new System.Drawing.Point(0, 394);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(708, 49);
            this.progressBar1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 451);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Distortion:";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(494, 443);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(214, 170);
            this.listBox1.TabIndex = 12;
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(136, 480);
            this.end.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(120, 22);
            this.end.TabIndex = 11;
            this.end.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(136, 451);
            this.start.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(120, 22);
            this.start.TabIndex = 10;
            this.start.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnProcessData
            // 
            this.btnProcessData.Location = new System.Drawing.Point(12, 498);
            this.btnProcessData.Name = "btnProcessData";
            this.btnProcessData.Size = new System.Drawing.Size(118, 43);
            this.btnProcessData.TabIndex = 9;
            this.btnProcessData.Text = "Process Data";
            this.btnProcessData.UseVisualStyleBackColor = true;
            this.btnProcessData.Click += new System.EventHandler(this.btnProcessData_Click);
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(12, 449);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(118, 43);
            this.btnLoadData.TabIndex = 8;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(12, 547);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(118, 43);
            this.btnTrain.TabIndex = 14;
            this.btnTrain.Text = "Train";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // nClusters
            // 
            this.nClusters.Location = new System.Drawing.Point(136, 547);
            this.nClusters.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nClusters.Name = "nClusters";
            this.nClusters.Size = new System.Drawing.Size(120, 22);
            this.nClusters.TabIndex = 15;
            this.nClusters.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnPresentResults
            // 
            this.btnPresentResults.Location = new System.Drawing.Point(262, 547);
            this.btnPresentResults.Name = "btnPresentResults";
            this.btnPresentResults.Size = new System.Drawing.Size(118, 43);
            this.btnPresentResults.TabIndex = 16;
            this.btnPresentResults.Text = "Present Results";
            this.btnPresentResults.UseVisualStyleBackColor = true;
            this.btnPresentResults.Click += new System.EventHandler(this.btnPresentResults_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 613);
            this.Controls.Add(this.btnPresentResults);
            this.Controls.Add(this.nClusters);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.end);
            this.Controls.Add(this.start);
            this.Controls.Add(this.btnProcessData);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.end)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nClusters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NumericUpDown end;
        private System.Windows.Forms.NumericUpDown start;
        private System.Windows.Forms.Button btnProcessData;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.NumericUpDown nClusters;
        private System.Windows.Forms.Button btnPresentResults;
    }
}

