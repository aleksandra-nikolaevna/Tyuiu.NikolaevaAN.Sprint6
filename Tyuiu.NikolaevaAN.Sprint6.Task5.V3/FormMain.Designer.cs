
namespace Tyuiu.NikolaevaAN.Sprint6.Task5.V3
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop_NAN = new System.Windows.Forms.Panel();
            this.panelLeft_NAN = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelRight_NAN = new System.Windows.Forms.Panel();
            this.groupBoxTask_NAN = new System.Windows.Forms.GroupBox();
            this.textBoxTask_NAN = new System.Windows.Forms.TextBox();
            this.buttonDone_NAN = new System.Windows.Forms.Button();
            this.buttonOpenFile_NAN = new System.Windows.Forms.Button();
            this.buttonHelp_NAN = new System.Windows.Forms.Button();
            this.groupBoxResult_NAN = new System.Windows.Forms.GroupBox();
            this.chartDiag_NAN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewNums_NAN = new System.Windows.Forms.DataGridView();
            this.panelTop_NAN.SuspendLayout();
            this.panelLeft_NAN.SuspendLayout();
            this.panelRight_NAN.SuspendLayout();
            this.groupBoxTask_NAN.SuspendLayout();
            this.groupBoxResult_NAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_NAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_NAN)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_NAN
            // 
            this.panelTop_NAN.BackColor = System.Drawing.SystemColors.Control;
            this.panelTop_NAN.Controls.Add(this.buttonHelp_NAN);
            this.panelTop_NAN.Controls.Add(this.buttonOpenFile_NAN);
            this.panelTop_NAN.Controls.Add(this.buttonDone_NAN);
            this.panelTop_NAN.Controls.Add(this.groupBoxTask_NAN);
            this.panelTop_NAN.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_NAN.Location = new System.Drawing.Point(0, 0);
            this.panelTop_NAN.Name = "panelTop_NAN";
            this.panelTop_NAN.Size = new System.Drawing.Size(832, 98);
            this.panelTop_NAN.TabIndex = 0;
            // 
            // panelLeft_NAN
            // 
            this.panelLeft_NAN.BackColor = System.Drawing.SystemColors.Control;
            this.panelLeft_NAN.Controls.Add(this.groupBoxResult_NAN);
            this.panelLeft_NAN.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_NAN.Location = new System.Drawing.Point(0, 98);
            this.panelLeft_NAN.Name = "panelLeft_NAN";
            this.panelLeft_NAN.Padding = new System.Windows.Forms.Padding(6);
            this.panelLeft_NAN.Size = new System.Drawing.Size(217, 405);
            this.panelLeft_NAN.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(217, 98);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 405);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // panelRight_NAN
            // 
            this.panelRight_NAN.BackColor = System.Drawing.SystemColors.Control;
            this.panelRight_NAN.Controls.Add(this.chartDiag_NAN);
            this.panelRight_NAN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_NAN.Location = new System.Drawing.Point(220, 98);
            this.panelRight_NAN.Name = "panelRight_NAN";
            this.panelRight_NAN.Size = new System.Drawing.Size(612, 405);
            this.panelRight_NAN.TabIndex = 3;
            // 
            // groupBoxTask_NAN
            // 
            this.groupBoxTask_NAN.Controls.Add(this.textBoxTask_NAN);
            this.groupBoxTask_NAN.Location = new System.Drawing.Point(4, 4);
            this.groupBoxTask_NAN.Name = "groupBoxTask_NAN";
            this.groupBoxTask_NAN.Size = new System.Drawing.Size(504, 91);
            this.groupBoxTask_NAN.TabIndex = 0;
            this.groupBoxTask_NAN.TabStop = false;
            this.groupBoxTask_NAN.Text = "Условие:";
            // 
            // textBoxTask_NAN
            // 
            this.textBoxTask_NAN.Location = new System.Drawing.Point(9, 22);
            this.textBoxTask_NAN.Multiline = true;
            this.textBoxTask_NAN.Name = "textBoxTask_NAN";
            this.textBoxTask_NAN.ReadOnly = true;
            this.textBoxTask_NAN.Size = new System.Drawing.Size(489, 63);
            this.textBoxTask_NAN.TabIndex = 0;
            this.textBoxTask_NAN.Text = "Прочитать данные из файла InPutFileTask5V3.txt. Вывести в dataGridVew вещественны" +
    "е числа и построить диаграмму по этим значениям.";
            // 
            // buttonDone_NAN
            // 
            this.buttonDone_NAN.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonDone_NAN.Location = new System.Drawing.Point(515, 26);
            this.buttonDone_NAN.Name = "buttonDone_NAN";
            this.buttonDone_NAN.Size = new System.Drawing.Size(96, 51);
            this.buttonDone_NAN.TabIndex = 1;
            this.buttonDone_NAN.Text = "Выполнить";
            this.buttonDone_NAN.UseVisualStyleBackColor = false;
            this.buttonDone_NAN.Click += new System.EventHandler(this.buttonDone_NAN_Click);
            // 
            // buttonOpenFile_NAN
            // 
            this.buttonOpenFile_NAN.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonOpenFile_NAN.Location = new System.Drawing.Point(617, 26);
            this.buttonOpenFile_NAN.Name = "buttonOpenFile_NAN";
            this.buttonOpenFile_NAN.Size = new System.Drawing.Size(96, 51);
            this.buttonOpenFile_NAN.TabIndex = 2;
            this.buttonOpenFile_NAN.Text = "Открыть файл";
            this.buttonOpenFile_NAN.UseVisualStyleBackColor = false;
            this.buttonOpenFile_NAN.Click += new System.EventHandler(this.buttonOpenFile_NAN_Click);
            // 
            // buttonHelp_NAN
            // 
            this.buttonHelp_NAN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_NAN.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonHelp_NAN.Location = new System.Drawing.Point(719, 26);
            this.buttonHelp_NAN.Name = "buttonHelp_NAN";
            this.buttonHelp_NAN.Size = new System.Drawing.Size(96, 51);
            this.buttonHelp_NAN.TabIndex = 3;
            this.buttonHelp_NAN.Text = "Справка";
            this.buttonHelp_NAN.UseVisualStyleBackColor = false;
            this.buttonHelp_NAN.Click += new System.EventHandler(this.buttonHelp_NAN_Click);
            // 
            // groupBoxResult_NAN
            // 
            this.groupBoxResult_NAN.Controls.Add(this.dataGridViewNums_NAN);
            this.groupBoxResult_NAN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult_NAN.Location = new System.Drawing.Point(6, 6);
            this.groupBoxResult_NAN.Name = "groupBoxResult_NAN";
            this.groupBoxResult_NAN.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxResult_NAN.Size = new System.Drawing.Size(205, 393);
            this.groupBoxResult_NAN.TabIndex = 0;
            this.groupBoxResult_NAN.TabStop = false;
            this.groupBoxResult_NAN.Text = "Вывод данных:";
            // 
            // chartDiag_NAN
            // 
            chartArea9.Name = "ChartArea1";
            this.chartDiag_NAN.ChartAreas.Add(chartArea9);
            this.chartDiag_NAN.Dock = System.Windows.Forms.DockStyle.Fill;
            legend9.Name = "Legend1";
            this.chartDiag_NAN.Legends.Add(legend9);
            this.chartDiag_NAN.Location = new System.Drawing.Point(0, 0);
            this.chartDiag_NAN.Name = "chartDiag_NAN";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.IsVisibleInLegend = false;
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chartDiag_NAN.Series.Add(series9);
            this.chartDiag_NAN.Size = new System.Drawing.Size(612, 405);
            this.chartDiag_NAN.TabIndex = 0;
            this.chartDiag_NAN.Text = "chart1";
            // 
            // dataGridViewNums_NAN
            // 
            this.dataGridViewNums_NAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNums_NAN.ColumnHeadersVisible = false;
            this.dataGridViewNums_NAN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewNums_NAN.Location = new System.Drawing.Point(5, 20);
            this.dataGridViewNums_NAN.Name = "dataGridViewNums_NAN";
            this.dataGridViewNums_NAN.RowHeadersVisible = false;
            this.dataGridViewNums_NAN.RowHeadersWidth = 51;
            this.dataGridViewNums_NAN.RowTemplate.Height = 24;
            this.dataGridViewNums_NAN.Size = new System.Drawing.Size(195, 368);
            this.dataGridViewNums_NAN.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 503);
            this.Controls.Add(this.panelRight_NAN);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelLeft_NAN);
            this.Controls.Add(this.panelTop_NAN);
            this.MinimumSize = new System.Drawing.Size(850, 550);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 3 | Николаева А. Н.";
            this.panelTop_NAN.ResumeLayout(false);
            this.panelLeft_NAN.ResumeLayout(false);
            this.panelRight_NAN.ResumeLayout(false);
            this.groupBoxTask_NAN.ResumeLayout(false);
            this.groupBoxTask_NAN.PerformLayout();
            this.groupBoxResult_NAN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_NAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_NAN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_NAN;
        private System.Windows.Forms.Panel panelLeft_NAN;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panelRight_NAN;
        private System.Windows.Forms.GroupBox groupBoxTask_NAN;
        private System.Windows.Forms.TextBox textBoxTask_NAN;
        private System.Windows.Forms.Button buttonHelp_NAN;
        private System.Windows.Forms.Button buttonOpenFile_NAN;
        private System.Windows.Forms.Button buttonDone_NAN;
        private System.Windows.Forms.GroupBox groupBoxResult_NAN;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_NAN;
        private System.Windows.Forms.DataGridView dataGridViewNums_NAN;
    }
}

