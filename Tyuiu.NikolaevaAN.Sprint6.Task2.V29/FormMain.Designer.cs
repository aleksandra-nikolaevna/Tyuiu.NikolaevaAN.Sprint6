
namespace Tyuiu.NikolaevaAN.Sprint6.Task2.V29
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxTask_NAN = new System.Windows.Forms.GroupBox();
            this.textBoxTextTask_NAN = new System.Windows.Forms.TextBox();
            this.groupBoxEnter_NAN = new System.Windows.Forms.GroupBox();
            this.textBoxEnterStart_NAN = new System.Windows.Forms.TextBox();
            this.textBoxEnterStop_NAN = new System.Windows.Forms.TextBox();
            this.labelStart_NAN = new System.Windows.Forms.Label();
            this.labelStop_NAN = new System.Windows.Forms.Label();
            this.buttonHelp_NAN = new System.Windows.Forms.Button();
            this.buttonDone_NAN = new System.Windows.Forms.Button();
            this.groupBoxResult_NAN = new System.Windows.Forms.GroupBox();
            this.dataGridViewFunction_NAN = new System.Windows.Forms.DataGridView();
            this.labelResult_NAN = new System.Windows.Forms.Label();
            this.chartFunction_NAN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBoxFormula_NAN = new System.Windows.Forms.PictureBox();
            this.groupBoxTask_NAN.SuspendLayout();
            this.groupBoxEnter_NAN.SuspendLayout();
            this.groupBoxResult_NAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_NAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_NAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_NAN)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_NAN
            // 
            this.groupBoxTask_NAN.Controls.Add(this.pictureBoxFormula_NAN);
            this.groupBoxTask_NAN.Controls.Add(this.textBoxTextTask_NAN);
            this.groupBoxTask_NAN.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_NAN.Name = "groupBoxTask_NAN";
            this.groupBoxTask_NAN.Size = new System.Drawing.Size(568, 289);
            this.groupBoxTask_NAN.TabIndex = 0;
            this.groupBoxTask_NAN.TabStop = false;
            this.groupBoxTask_NAN.Text = "Условие:";
            // 
            // textBoxTextTask_NAN
            // 
            this.textBoxTextTask_NAN.Location = new System.Drawing.Point(7, 22);
            this.textBoxTextTask_NAN.Multiline = true;
            this.textBoxTextTask_NAN.Name = "textBoxTextTask_NAN";
            this.textBoxTextTask_NAN.ReadOnly = true;
            this.textBoxTextTask_NAN.Size = new System.Drawing.Size(555, 259);
            this.textBoxTextTask_NAN.TabIndex = 0;
            this.textBoxTextTask_NAN.Text = "Протабулировать функцию\r\n\r\n\r\n\r\nна заданном диапазоне.\r\nРезультат вывести в DataGr" +
    "idView и построить график функции.";
            // 
            // groupBoxEnter_NAN
            // 
            this.groupBoxEnter_NAN.Controls.Add(this.labelStop_NAN);
            this.groupBoxEnter_NAN.Controls.Add(this.labelStart_NAN);
            this.groupBoxEnter_NAN.Controls.Add(this.textBoxEnterStop_NAN);
            this.groupBoxEnter_NAN.Controls.Add(this.textBoxEnterStart_NAN);
            this.groupBoxEnter_NAN.Location = new System.Drawing.Point(13, 308);
            this.groupBoxEnter_NAN.Name = "groupBoxEnter_NAN";
            this.groupBoxEnter_NAN.Size = new System.Drawing.Size(355, 130);
            this.groupBoxEnter_NAN.TabIndex = 1;
            this.groupBoxEnter_NAN.TabStop = false;
            this.groupBoxEnter_NAN.Text = "Ввод данных:";
            // 
            // textBoxEnterStart_NAN
            // 
            this.textBoxEnterStart_NAN.Location = new System.Drawing.Point(7, 82);
            this.textBoxEnterStart_NAN.Multiline = true;
            this.textBoxEnterStart_NAN.Name = "textBoxEnterStart_NAN";
            this.textBoxEnterStart_NAN.Size = new System.Drawing.Size(117, 42);
            this.textBoxEnterStart_NAN.TabIndex = 0;
            // 
            // textBoxEnterStop_NAN
            // 
            this.textBoxEnterStop_NAN.Location = new System.Drawing.Point(154, 82);
            this.textBoxEnterStop_NAN.Multiline = true;
            this.textBoxEnterStop_NAN.Name = "textBoxEnterStop_NAN";
            this.textBoxEnterStop_NAN.Size = new System.Drawing.Size(118, 42);
            this.textBoxEnterStop_NAN.TabIndex = 1;
            // 
            // labelStart_NAN
            // 
            this.labelStart_NAN.AutoSize = true;
            this.labelStart_NAN.Location = new System.Drawing.Point(7, 59);
            this.labelStart_NAN.Name = "labelStart_NAN";
            this.labelStart_NAN.Size = new System.Drawing.Size(87, 17);
            this.labelStart_NAN.TabIndex = 2;
            this.labelStart_NAN.Text = "Старт шага:";
            // 
            // labelStop_NAN
            // 
            this.labelStop_NAN.AutoSize = true;
            this.labelStop_NAN.Location = new System.Drawing.Point(155, 59);
            this.labelStop_NAN.Name = "labelStop_NAN";
            this.labelStop_NAN.Size = new System.Drawing.Size(89, 17);
            this.labelStop_NAN.TabIndex = 3;
            this.labelStop_NAN.Text = "Конец шага:";
            // 
            // buttonHelp_NAN
            // 
            this.buttonHelp_NAN.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_NAN.Location = new System.Drawing.Point(374, 341);
            this.buttonHelp_NAN.Name = "buttonHelp_NAN";
            this.buttonHelp_NAN.Size = new System.Drawing.Size(77, 69);
            this.buttonHelp_NAN.TabIndex = 2;
            this.buttonHelp_NAN.Text = "Справка";
            this.buttonHelp_NAN.UseVisualStyleBackColor = false;
            this.buttonHelp_NAN.Click += new System.EventHandler(this.buttonHelp_NAN_Click);
            // 
            // buttonDone_NAN
            // 
            this.buttonDone_NAN.BackColor = System.Drawing.Color.Green;
            this.buttonDone_NAN.Location = new System.Drawing.Point(457, 341);
            this.buttonDone_NAN.Name = "buttonDone_NAN";
            this.buttonDone_NAN.Size = new System.Drawing.Size(124, 69);
            this.buttonDone_NAN.TabIndex = 3;
            this.buttonDone_NAN.Text = "Выполнить";
            this.buttonDone_NAN.UseVisualStyleBackColor = false;
            this.buttonDone_NAN.Click += new System.EventHandler(this.buttonDone_NAN_Click);
            this.buttonDone_NAN.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_NAN_MouseDown);
            this.buttonDone_NAN.MouseEnter += new System.EventHandler(this.buttonDone_NAN_MouseEnter);
            this.buttonDone_NAN.MouseLeave += new System.EventHandler(this.buttonDone_NAN_MouseLeave);
            // 
            // groupBoxResult_NAN
            // 
            this.groupBoxResult_NAN.Controls.Add(this.chartFunction_NAN);
            this.groupBoxResult_NAN.Controls.Add(this.labelResult_NAN);
            this.groupBoxResult_NAN.Controls.Add(this.dataGridViewFunction_NAN);
            this.groupBoxResult_NAN.Location = new System.Drawing.Point(587, 13);
            this.groupBoxResult_NAN.Name = "groupBoxResult_NAN";
            this.groupBoxResult_NAN.Size = new System.Drawing.Size(533, 425);
            this.groupBoxResult_NAN.TabIndex = 4;
            this.groupBoxResult_NAN.TabStop = false;
            this.groupBoxResult_NAN.Text = "Вывод данных:";
            // 
            // dataGridViewFunction_NAN
            // 
            this.dataGridViewFunction_NAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_NAN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Fx});
            this.dataGridViewFunction_NAN.Location = new System.Drawing.Point(7, 48);
            this.dataGridViewFunction_NAN.Name = "dataGridViewFunction_NAN";
            this.dataGridViewFunction_NAN.RowHeadersVisible = false;
            this.dataGridViewFunction_NAN.RowHeadersWidth = 51;
            this.dataGridViewFunction_NAN.RowTemplate.Height = 24;
            this.dataGridViewFunction_NAN.Size = new System.Drawing.Size(182, 371);
            this.dataGridViewFunction_NAN.TabIndex = 0;
            // 
            // labelResult_NAN
            // 
            this.labelResult_NAN.AutoSize = true;
            this.labelResult_NAN.Location = new System.Drawing.Point(7, 22);
            this.labelResult_NAN.Name = "labelResult_NAN";
            this.labelResult_NAN.Size = new System.Drawing.Size(80, 17);
            this.labelResult_NAN.TabIndex = 1;
            this.labelResult_NAN.Text = "Результат:";
            // 
            // chartFunction_NAN
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_NAN.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_NAN.Legends.Add(legend1);
            this.chartFunction_NAN.Location = new System.Drawing.Point(195, 48);
            this.chartFunction_NAN.Name = "chartFunction_NAN";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_NAN.Series.Add(series1);
            this.chartFunction_NAN.Size = new System.Drawing.Size(332, 371);
            this.chartFunction_NAN.TabIndex = 2;
            this.chartFunction_NAN.Text = "chart1";
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.Width = 65;
            // 
            // Fx
            // 
            this.Fx.HeaderText = "Fx";
            this.Fx.MinimumWidth = 6;
            this.Fx.Name = "Fx";
            this.Fx.Width = 65;
            // 
            // pictureBoxFormula_NAN
            // 
            this.pictureBoxFormula_NAN.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_NAN.Image")));
            this.pictureBoxFormula_NAN.Location = new System.Drawing.Point(10, 48);
            this.pictureBoxFormula_NAN.Name = "pictureBoxFormula_NAN";
            this.pictureBoxFormula_NAN.Size = new System.Drawing.Size(552, 43);
            this.pictureBoxFormula_NAN.TabIndex = 1;
            this.pictureBoxFormula_NAN.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 450);
            this.Controls.Add(this.groupBoxResult_NAN);
            this.Controls.Add(this.buttonDone_NAN);
            this.Controls.Add(this.buttonHelp_NAN);
            this.Controls.Add(this.groupBoxEnter_NAN);
            this.Controls.Add(this.groupBoxTask_NAN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 29 | Николаева А. Н.";
            this.groupBoxTask_NAN.ResumeLayout(false);
            this.groupBoxTask_NAN.PerformLayout();
            this.groupBoxEnter_NAN.ResumeLayout(false);
            this.groupBoxEnter_NAN.PerformLayout();
            this.groupBoxResult_NAN.ResumeLayout(false);
            this.groupBoxResult_NAN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_NAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_NAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_NAN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_NAN;
        private System.Windows.Forms.TextBox textBoxTextTask_NAN;
        private System.Windows.Forms.GroupBox groupBoxEnter_NAN;
        private System.Windows.Forms.Label labelStart_NAN;
        private System.Windows.Forms.TextBox textBoxEnterStop_NAN;
        private System.Windows.Forms.TextBox textBoxEnterStart_NAN;
        private System.Windows.Forms.Label labelStop_NAN;
        private System.Windows.Forms.Button buttonHelp_NAN;
        private System.Windows.Forms.Button buttonDone_NAN;
        private System.Windows.Forms.GroupBox groupBoxResult_NAN;
        private System.Windows.Forms.Label labelResult_NAN;
        private System.Windows.Forms.DataGridView dataGridViewFunction_NAN;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_NAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fx;
        private System.Windows.Forms.PictureBox pictureBoxFormula_NAN;
    }
}

