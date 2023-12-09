
namespace Tyuiu.NikolaevaAN.Sprint6.Task4.V27
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxTask_NAN = new System.Windows.Forms.GroupBox();
            this.textBoxTask_NAN = new System.Windows.Forms.TextBox();
            this.groupBoxEnter_NAN = new System.Windows.Forms.GroupBox();
            this.labelStart_NAN = new System.Windows.Forms.Label();
            this.labelStop_NAN = new System.Windows.Forms.Label();
            this.textBoxStart_NAN = new System.Windows.Forms.TextBox();
            this.textBoxStop_NAN = new System.Windows.Forms.TextBox();
            this.buttonDone_NAN = new System.Windows.Forms.Button();
            this.buttonSave_NAN = new System.Windows.Forms.Button();
            this.buttonHelp_NAN = new System.Windows.Forms.Button();
            this.groupBoxResult_NAN = new System.Windows.Forms.GroupBox();
            this.textBoxResult_NAN = new System.Windows.Forms.TextBox();
            this.chartFunction_NAN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxTask_NAN.SuspendLayout();
            this.groupBoxEnter_NAN.SuspendLayout();
            this.groupBoxResult_NAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_NAN)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_NAN
            // 
            this.groupBoxTask_NAN.Controls.Add(this.textBoxTask_NAN);
            this.groupBoxTask_NAN.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_NAN.Name = "groupBoxTask_NAN";
            this.groupBoxTask_NAN.Size = new System.Drawing.Size(514, 89);
            this.groupBoxTask_NAN.TabIndex = 0;
            this.groupBoxTask_NAN.TabStop = false;
            this.groupBoxTask_NAN.Text = "Условие:";
            // 
            // textBoxTask_NAN
            // 
            this.textBoxTask_NAN.Location = new System.Drawing.Point(7, 22);
            this.textBoxTask_NAN.Multiline = true;
            this.textBoxTask_NAN.Name = "textBoxTask_NAN";
            this.textBoxTask_NAN.ReadOnly = true;
            this.textBoxTask_NAN.Size = new System.Drawing.Size(501, 61);
            this.textBoxTask_NAN.TabIndex = 0;
            this.textBoxTask_NAN.Text = "Протабулировать функцию на заданном диапазоне от -5 до 5.\r\nРезультат вывести в te" +
    "xtBox, построить график функции и сохранить в файл OutPutFileTask4V27.txt по наж" +
    "атию кнопки.";
            // 
            // groupBoxEnter_NAN
            // 
            this.groupBoxEnter_NAN.Controls.Add(this.textBoxStop_NAN);
            this.groupBoxEnter_NAN.Controls.Add(this.textBoxStart_NAN);
            this.groupBoxEnter_NAN.Controls.Add(this.labelStop_NAN);
            this.groupBoxEnter_NAN.Controls.Add(this.labelStart_NAN);
            this.groupBoxEnter_NAN.Location = new System.Drawing.Point(533, 12);
            this.groupBoxEnter_NAN.Name = "groupBoxEnter_NAN";
            this.groupBoxEnter_NAN.Size = new System.Drawing.Size(229, 89);
            this.groupBoxEnter_NAN.TabIndex = 1;
            this.groupBoxEnter_NAN.TabStop = false;
            this.groupBoxEnter_NAN.Text = "Ввод данных:";
            // 
            // labelStart_NAN
            // 
            this.labelStart_NAN.AutoSize = true;
            this.labelStart_NAN.Location = new System.Drawing.Point(7, 22);
            this.labelStart_NAN.Name = "labelStart_NAN";
            this.labelStart_NAN.Size = new System.Drawing.Size(87, 17);
            this.labelStart_NAN.TabIndex = 0;
            this.labelStart_NAN.Text = "Старт шага:";
            // 
            // labelStop_NAN
            // 
            this.labelStop_NAN.AutoSize = true;
            this.labelStop_NAN.Location = new System.Drawing.Point(117, 22);
            this.labelStop_NAN.Name = "labelStop_NAN";
            this.labelStop_NAN.Size = new System.Drawing.Size(89, 17);
            this.labelStop_NAN.TabIndex = 1;
            this.labelStop_NAN.Text = "Конец шага:";
            // 
            // textBoxStart_NAN
            // 
            this.textBoxStart_NAN.Location = new System.Drawing.Point(6, 42);
            this.textBoxStart_NAN.Multiline = true;
            this.textBoxStart_NAN.Name = "textBoxStart_NAN";
            this.textBoxStart_NAN.Size = new System.Drawing.Size(102, 31);
            this.textBoxStart_NAN.TabIndex = 2;
            this.textBoxStart_NAN.Text = "-5";
            // 
            // textBoxStop_NAN
            // 
            this.textBoxStop_NAN.Location = new System.Drawing.Point(120, 42);
            this.textBoxStop_NAN.Multiline = true;
            this.textBoxStop_NAN.Name = "textBoxStop_NAN";
            this.textBoxStop_NAN.Size = new System.Drawing.Size(102, 31);
            this.textBoxStop_NAN.TabIndex = 3;
            this.textBoxStop_NAN.Text = "5";
            // 
            // buttonDone_NAN
            // 
            this.buttonDone_NAN.BackColor = System.Drawing.Color.Green;
            this.buttonDone_NAN.Location = new System.Drawing.Point(769, 27);
            this.buttonDone_NAN.Name = "buttonDone_NAN";
            this.buttonDone_NAN.Size = new System.Drawing.Size(104, 58);
            this.buttonDone_NAN.TabIndex = 2;
            this.buttonDone_NAN.Text = "Выполнить";
            this.buttonDone_NAN.UseVisualStyleBackColor = false;
            this.buttonDone_NAN.Click += new System.EventHandler(this.buttonDone_NAN_Click);
            // 
            // buttonSave_NAN
            // 
            this.buttonSave_NAN.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSave_NAN.Location = new System.Drawing.Point(879, 27);
            this.buttonSave_NAN.Name = "buttonSave_NAN";
            this.buttonSave_NAN.Size = new System.Drawing.Size(104, 58);
            this.buttonSave_NAN.TabIndex = 3;
            this.buttonSave_NAN.Text = "Сохранить";
            this.buttonSave_NAN.UseVisualStyleBackColor = false;
            this.buttonSave_NAN.Click += new System.EventHandler(this.buttonSave_NAN_Click);
            // 
            // buttonHelp_NAN
            // 
            this.buttonHelp_NAN.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonHelp_NAN.Location = new System.Drawing.Point(989, 27);
            this.buttonHelp_NAN.Name = "buttonHelp_NAN";
            this.buttonHelp_NAN.Size = new System.Drawing.Size(104, 58);
            this.buttonHelp_NAN.TabIndex = 4;
            this.buttonHelp_NAN.Text = "Справка";
            this.buttonHelp_NAN.UseVisualStyleBackColor = false;
            this.buttonHelp_NAN.Click += new System.EventHandler(this.buttonHelp_NAN_Click);
            // 
            // groupBoxResult_NAN
            // 
            this.groupBoxResult_NAN.Controls.Add(this.textBoxResult_NAN);
            this.groupBoxResult_NAN.Location = new System.Drawing.Point(13, 108);
            this.groupBoxResult_NAN.Name = "groupBoxResult_NAN";
            this.groupBoxResult_NAN.Size = new System.Drawing.Size(253, 430);
            this.groupBoxResult_NAN.TabIndex = 5;
            this.groupBoxResult_NAN.TabStop = false;
            this.groupBoxResult_NAN.Text = "Вывод данных:";
            // 
            // textBoxResult_NAN
            // 
            this.textBoxResult_NAN.Location = new System.Drawing.Point(6, 22);
            this.textBoxResult_NAN.Multiline = true;
            this.textBoxResult_NAN.Name = "textBoxResult_NAN";
            this.textBoxResult_NAN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_NAN.Size = new System.Drawing.Size(241, 402);
            this.textBoxResult_NAN.TabIndex = 0;
            // 
            // chartFunction_NAN
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_NAN.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_NAN.Legends.Add(legend1);
            this.chartFunction_NAN.Location = new System.Drawing.Point(273, 114);
            this.chartFunction_NAN.Name = "chartFunction_NAN";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_NAN.Series.Add(series1);
            this.chartFunction_NAN.Size = new System.Drawing.Size(820, 424);
            this.chartFunction_NAN.TabIndex = 6;
            this.chartFunction_NAN.Text = "chartFunction";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            title1.ForeColor = System.Drawing.Color.MidnightBlue;
            title1.Name = "Title1";
            title1.Text = "График функции";
            this.chartFunction_NAN.Titles.Add(title1);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 550);
            this.Controls.Add(this.chartFunction_NAN);
            this.Controls.Add(this.groupBoxResult_NAN);
            this.Controls.Add(this.buttonHelp_NAN);
            this.Controls.Add(this.buttonSave_NAN);
            this.Controls.Add(this.buttonDone_NAN);
            this.Controls.Add(this.groupBoxEnter_NAN);
            this.Controls.Add(this.groupBoxTask_NAN);
            this.MinimumSize = new System.Drawing.Size(1121, 597);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 27 | Николаева А. Н.";
            this.groupBoxTask_NAN.ResumeLayout(false);
            this.groupBoxTask_NAN.PerformLayout();
            this.groupBoxEnter_NAN.ResumeLayout(false);
            this.groupBoxEnter_NAN.PerformLayout();
            this.groupBoxResult_NAN.ResumeLayout(false);
            this.groupBoxResult_NAN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_NAN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_NAN;
        private System.Windows.Forms.TextBox textBoxTask_NAN;
        private System.Windows.Forms.GroupBox groupBoxEnter_NAN;
        private System.Windows.Forms.Label labelStart_NAN;
        private System.Windows.Forms.Label labelStop_NAN;
        private System.Windows.Forms.TextBox textBoxStart_NAN;
        private System.Windows.Forms.TextBox textBoxStop_NAN;
        private System.Windows.Forms.Button buttonDone_NAN;
        private System.Windows.Forms.Button buttonSave_NAN;
        private System.Windows.Forms.Button buttonHelp_NAN;
        private System.Windows.Forms.GroupBox groupBoxResult_NAN;
        private System.Windows.Forms.TextBox textBoxResult_NAN;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_NAN;
    }
}

