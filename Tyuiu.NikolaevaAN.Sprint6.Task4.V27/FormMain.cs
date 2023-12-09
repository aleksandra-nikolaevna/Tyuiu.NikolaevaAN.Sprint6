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
using Tyuiu.NikolaevaAN.Sprint6.Task4.V27.Lib;

namespace Tyuiu.NikolaevaAN.Sprint6.Task4.V27
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
                int startStep = Convert.ToInt32(textBoxStart_NAN.Text);
                int stopStep = Convert.ToInt32(textBoxStop_NAN.Text);
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_NAN.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_NAN.ChartAreas[0].AxisY.Title = "Ось Y";
                textBoxResult_NAN.Text = "";
                chartFunction_NAN.Series[0].Points.Clear();
                for (int i = 0; i <= len; i++)
                {
                    this.chartFunction_NAN.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_NAN.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_NAN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнила студентка группы ПКТб-23-2 Николаева Александра Николаевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_NAN_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V27.txt";
                File.WriteAllText(path, textBoxResult_NAN.Text);
                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
