using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextCopier
{
    public partial class Form1 : Form
    {
        Thread thread = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void FromFilebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "txt files (*.txt)|";
            fileDialog.ShowDialog();
            Fromtxtbox.Text = fileDialog.FileName;
        }

        private void ToFilebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "txt files (*.txt)|";
            fileDialog.ShowDialog();
            Totxtbox.Text = fileDialog.FileName;
        }

        private void CopyBtn_Click(object sender, EventArgs e)
        {

        }

        private void AbortBtn_Click(object sender, EventArgs e)
        {

        }

        private void ResumeBtn_Click(object sender, EventArgs e)
        {

        }

        private void SuspendBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
