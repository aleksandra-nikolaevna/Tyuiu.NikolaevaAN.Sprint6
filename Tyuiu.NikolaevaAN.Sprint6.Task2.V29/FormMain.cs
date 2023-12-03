using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.NikolaevaAN.Sprint6.Task2.V29.Lib;

namespace Tyuiu.NikolaevaAN.Sprint6.Task2.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonDone_NAN_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxEnterStart_NAN.Text);
                int stopStep = Convert.ToInt32(textBoxEnterStop_NAN.Text);
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartFunction_NAN.Titles.Add("График функции");
                this.chartFunction_NAN.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_NAN.ChartAreas[0].AxisY.Title = "Ось Y";
                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_NAN.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_NAN.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_NAN_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_NAN.BackColor = Color.Red;
        }

        private void buttonDone_NAN_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_NAN.BackColor = Color.Blue;
        }

        private void buttonDone_NAN_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_NAN.BackColor = Color.Green;
        }

        private void buttonHelp_NAN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила студентка группы ПКТб-23-2 Николаева Александра Николаевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
