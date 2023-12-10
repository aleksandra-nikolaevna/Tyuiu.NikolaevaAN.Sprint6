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
using Tyuiu.NikolaevaAN.Sprint6.Task7.V23.Lib;

namespace Tyuiu.NikolaevaAN.Sprint6.Task7.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_NAN.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_NAN.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            
            rows = lines.Length;
            columns = lines[0].Split(';').Length;
            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonOpenFile_NAN_Click(object sender, EventArgs e)
        {
            openFileDialogTask_NAN.ShowDialog();
            openFilePath = openFileDialogTask_NAN.FileName;

            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInMatrix_NAN.ColumnCount = columns;
            dataGridViewInMatrix_NAN.RowCount = rows;
            dataGridViewOutMatrix_NAN.ColumnCount = columns;
            dataGridViewOutMatrix_NAN.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInMatrix_NAN.Columns[i].Width = 25;
                dataGridViewOutMatrix_NAN.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInMatrix_NAN.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(LoadFromFileData(openFilePath));
            buttonDone_NAN.Enabled = true;
        }

        private void buttonHelp_NAN_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDone_NAN_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(LoadFromFileData(openFilePath));

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutMatrix_NAN.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSaveFile_NAN.Enabled = true;
        }

        private void buttonSaveFile_NAN_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_NAN.FileName = "OutPutFileTask7V23.csv";
            saveFileDialogMatrix_NAN.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_NAN.ShowDialog();

            string path = saveFileDialogMatrix_NAN.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutMatrix_NAN.RowCount;
            int columns = dataGridViewOutMatrix_NAN.ColumnCount;

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutMatrix_NAN.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutMatrix_NAN.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInMatrix_NAN.ColumnCount = 50;
            dataGridViewOutMatrix_NAN.ColumnCount = 50;
            dataGridViewOutMatrix_NAN.RowCount = 50;
            dataGridViewInMatrix_NAN.RowCount = 50;
            panelLeft_NAN.Width = this.Width / 2;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewInMatrix_NAN.Columns[i].Width = 25;
                dataGridViewOutMatrix_NAN.Columns[i].Width = 25;
            }
        }

        private void buttonOpenFile_NAN_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_NAN.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_NAN_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_NAN.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_NAN_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_NAN.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_NAN_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_NAN.ToolTipTitle = "Справка";
        }
    }
}
