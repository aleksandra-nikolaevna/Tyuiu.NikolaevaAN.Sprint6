using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.NikolaevaAN.Sprint6.Task1.V6.Lib;

namespace Tyuiu.NikolaevaAN.Sprint6.Task1.V6
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
                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_NAN.Text = "";
                textBoxResult_NAN.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_NAN.AppendText("|    X     |   F(x)   |" + Environment.NewLine);
                textBoxResult_NAN.AppendText("+----------+----------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1,6:f2}  |", startStep, valueArray[i]);
                    textBoxResult_NAN.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxResult_NAN.AppendText("+----------+----------+");
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_NAN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы ПКТб-23-2 Николаева Александра Николаевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
