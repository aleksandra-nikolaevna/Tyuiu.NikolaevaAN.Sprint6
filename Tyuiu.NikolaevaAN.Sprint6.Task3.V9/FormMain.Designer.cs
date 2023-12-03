
namespace Tyuiu.NikolaevaAN.Sprint6.Task3.V9
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
            this.groupBoxTask_NAN = new System.Windows.Forms.GroupBox();
            this.textBoxTextTask_NAN = new System.Windows.Forms.TextBox();
            this.dataGridViewTask_NAN = new System.Windows.Forms.DataGridView();
            this.groupBoxResult_NAN = new System.Windows.Forms.GroupBox();
            this.labelResult_NAN = new System.Windows.Forms.Label();
            this.dataGridViewResult_NAN = new System.Windows.Forms.DataGridView();
            this.buttonDone_NAN = new System.Windows.Forms.Button();
            this.buttonHelp_NAN = new System.Windows.Forms.Button();
            this.groupBoxTask_NAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTask_NAN)).BeginInit();
            this.groupBoxResult_NAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_NAN)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_NAN
            // 
            this.groupBoxTask_NAN.Controls.Add(this.dataGridViewTask_NAN);
            this.groupBoxTask_NAN.Controls.Add(this.textBoxTextTask_NAN);
            this.groupBoxTask_NAN.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_NAN.Name = "groupBoxTask_NAN";
            this.groupBoxTask_NAN.Size = new System.Drawing.Size(505, 425);
            this.groupBoxTask_NAN.TabIndex = 0;
            this.groupBoxTask_NAN.TabStop = false;
            this.groupBoxTask_NAN.Text = "Условие:";
            // 
            // textBoxTextTask_NAN
            // 
            this.textBoxTextTask_NAN.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.textBoxTextTask_NAN.Location = new System.Drawing.Point(7, 22);
            this.textBoxTextTask_NAN.Multiline = true;
            this.textBoxTextTask_NAN.Name = "textBoxTextTask_NAN";
            this.textBoxTextTask_NAN.ReadOnly = true;
            this.textBoxTextTask_NAN.Size = new System.Drawing.Size(227, 272);
            this.textBoxTextTask_NAN.TabIndex = 0;
            this.textBoxTextTask_NAN.Text = "Дана матрица 5 на 5\r\n-14 25  26 18  17\r\n28  10  6  -2  4\r\n30  25  -3 11  -10\r\n11 " +
    " 32  -5 -20 25\r\n2   -18 11 8   -20\r\nВыполнить сортировку по возрастанию в пятом " +
    "столбце.";
            // 
            // dataGridViewTask_NAN
            // 
            this.dataGridViewTask_NAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTask_NAN.ColumnHeadersVisible = false;
            this.dataGridViewTask_NAN.Location = new System.Drawing.Point(240, 22);
            this.dataGridViewTask_NAN.Name = "dataGridViewTask_NAN";
            this.dataGridViewTask_NAN.RowHeadersVisible = false;
            this.dataGridViewTask_NAN.RowHeadersWidth = 51;
            this.dataGridViewTask_NAN.RowTemplate.Height = 24;
            this.dataGridViewTask_NAN.Size = new System.Drawing.Size(258, 272);
            this.dataGridViewTask_NAN.TabIndex = 1;
            // 
            // groupBoxResult_NAN
            // 
            this.groupBoxResult_NAN.Controls.Add(this.dataGridViewResult_NAN);
            this.groupBoxResult_NAN.Controls.Add(this.labelResult_NAN);
            this.groupBoxResult_NAN.Location = new System.Drawing.Point(524, 13);
            this.groupBoxResult_NAN.Name = "groupBoxResult_NAN";
            this.groupBoxResult_NAN.Size = new System.Drawing.Size(342, 360);
            this.groupBoxResult_NAN.TabIndex = 1;
            this.groupBoxResult_NAN.TabStop = false;
            this.groupBoxResult_NAN.Text = "Вывод данных:";
            // 
            // labelResult_NAN
            // 
            this.labelResult_NAN.AutoSize = true;
            this.labelResult_NAN.Location = new System.Drawing.Point(6, 18);
            this.labelResult_NAN.Name = "labelResult_NAN";
            this.labelResult_NAN.Size = new System.Drawing.Size(80, 17);
            this.labelResult_NAN.TabIndex = 0;
            this.labelResult_NAN.Text = "Результат:";
            // 
            // dataGridViewResult_NAN
            // 
            this.dataGridViewResult_NAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_NAN.ColumnHeadersVisible = false;
            this.dataGridViewResult_NAN.Location = new System.Drawing.Point(7, 39);
            this.dataGridViewResult_NAN.Name = "dataGridViewResult_NAN";
            this.dataGridViewResult_NAN.RowHeadersVisible = false;
            this.dataGridViewResult_NAN.RowHeadersWidth = 51;
            this.dataGridViewResult_NAN.RowTemplate.Height = 24;
            this.dataGridViewResult_NAN.Size = new System.Drawing.Size(329, 255);
            this.dataGridViewResult_NAN.TabIndex = 1;
            // 
            // buttonDone_NAN
            // 
            this.buttonDone_NAN.Location = new System.Drawing.Point(720, 380);
            this.buttonDone_NAN.Name = "buttonDone_NAN";
            this.buttonDone_NAN.Size = new System.Drawing.Size(146, 58);
            this.buttonDone_NAN.TabIndex = 2;
            this.buttonDone_NAN.Text = "Выполнить";
            this.buttonDone_NAN.UseVisualStyleBackColor = true;
            this.buttonDone_NAN.Click += new System.EventHandler(this.buttonDone_NAN_Click);
            // 
            // buttonHelp_NAN
            // 
            this.buttonHelp_NAN.Location = new System.Drawing.Point(656, 380);
            this.buttonHelp_NAN.Name = "buttonHelp_NAN";
            this.buttonHelp_NAN.Size = new System.Drawing.Size(58, 58);
            this.buttonHelp_NAN.TabIndex = 3;
            this.buttonHelp_NAN.Text = "?";
            this.buttonHelp_NAN.UseVisualStyleBackColor = true;
            this.buttonHelp_NAN.Click += new System.EventHandler(this.buttonHelp_NAN_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 450);
            this.Controls.Add(this.buttonHelp_NAN);
            this.Controls.Add(this.buttonDone_NAN);
            this.Controls.Add(this.groupBoxResult_NAN);
            this.Controls.Add(this.groupBoxTask_NAN);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 9 | Николаева А. Н.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_NAN.ResumeLayout(false);
            this.groupBoxTask_NAN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTask_NAN)).EndInit();
            this.groupBoxResult_NAN.ResumeLayout(false);
            this.groupBoxResult_NAN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_NAN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_NAN;
        private System.Windows.Forms.TextBox textBoxTextTask_NAN;
        private System.Windows.Forms.DataGridView dataGridViewTask_NAN;
        private System.Windows.Forms.GroupBox groupBoxResult_NAN;
        private System.Windows.Forms.Label labelResult_NAN;
        private System.Windows.Forms.DataGridView dataGridViewResult_NAN;
        private System.Windows.Forms.Button buttonDone_NAN;
        private System.Windows.Forms.Button buttonHelp_NAN;
    }
}

