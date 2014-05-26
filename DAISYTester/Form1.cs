using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAISYSharp;
namespace DAISYTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            txtOPFFile.Text = openFileDialog1.FileName;

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            OPFFile file = new OPFFile(txtOPFFile.Text);
        }
    }
}
