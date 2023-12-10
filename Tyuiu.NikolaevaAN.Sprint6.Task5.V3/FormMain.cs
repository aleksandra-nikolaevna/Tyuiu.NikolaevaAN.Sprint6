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
using Tyuiu.NikolaevaAN.Sprint6.Task5.V3.Lib;

namespace Tyuiu.NikolaevaAN.Sprint6.Task5.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        //string path = @"C:\Users\Николаевы\source\repos\c#\Tyuiu.NikolaevaAN.Sprint6\Tyuiu.NikolaevaAN.Sprint6.Task5.V3\bin\Debug\OutPutFileTask5V3.txt";
        string path = @"C:\DataSprint6\InPutFileTask5V3.txt";
        private void buttonHelp_NAN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы ПКТб-23-2 Николаева Александра Николаевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_NAN_Click(object sender, EventArgs e)
        {
            dataGridViewNums_NAN.ColumnCount = 2;
            dataGridViewNums_NAN.Columns[0].Width = 20;
            dataGridViewNums_NAN.Columns[1].Width = 50;

            this.chartDiag_NAN.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag_NAN.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiag_NAN.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);
            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewNums_NAN.Rows.Add(Convert.ToString(i+1), Convert.ToString(numsMass[i]));
                chartDiag_NAN.Series[0].Points.AddXY(i+1, numsMass[i]);
            }
        }

        private void buttonOpenFile_NAN_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
