using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageClassification
{
    public partial class frmPresenter : Form
    {
        private List<UserControl1> _listBox;
        public frmPresenter()
        {
            InitializeComponent();
            _listBox = new List<UserControl1>();
            this.Width = 0;
        }

        public void AddList(string header)
        {
            UserControl1 uc = new UserControl1();
            uc.Dock = DockStyle.Left;
            uc.Width = 200;
            uc.SetUserControlHeader(header);
            _listBox.Add(uc);
            this.Controls.Add(uc);
            this.Width += 200;
        }

        public void AddItemToList(int indexList,string imageFilePath)
        {
            _listBox[indexList].AddItemToList(imageFilePath);
        }
    }
}
