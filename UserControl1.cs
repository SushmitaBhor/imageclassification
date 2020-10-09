using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageClassification
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public void SetUserControlHeader(string header)
        {
            label1.Text = header;
        }
        public void AddItemToList(string item)
        {
            listBox1.Items.Add(item);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox.BackgroundImage = Image.FromFile(listBox1.Items[listBox1.SelectedIndex].ToString());
        }
    }
}
