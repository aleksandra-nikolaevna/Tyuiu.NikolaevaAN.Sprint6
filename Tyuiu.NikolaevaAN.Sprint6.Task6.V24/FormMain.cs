using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.NikolaevaAN.Sprint6.Task6.V24.Lib;

namespace Tyuiu.NikolaevaAN.Sprint6.Task6.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string openFilePath;
        DataService ds = new DataService();
        private void buttonOpenFile_NAN_Click(object sender, EventArgs e)
        {
            openFileDialogTask_NAN.ShowDialog();
            openFilePath = openFileDialogTask_NAN.FileName;
            textBoxEnter_NAN.Text = File.ReadAllText(openFilePath);
            groupBoxEnter_NAN.Text = groupBoxEnter_NAN.Text + " " + openFileDialogTask_NAN.FileName;
            buttonDone_NAN.Enabled = true;
        }

        private void buttonDone_NAN_Click(object sender, EventArgs e)
        {
            string str = " ";
            textBoxResult_NAN.Text = ds.CollectTextFromFile(str, openFilePath);
        }

        private void buttonHelp_NAN_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
