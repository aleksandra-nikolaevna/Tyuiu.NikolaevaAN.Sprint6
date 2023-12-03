
namespace Tyuiu.NikolaevaAN.Sprint6.Task0.V26
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxTask_NAN = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_NAN = new System.Windows.Forms.PictureBox();
            this.groupBoxEnter_NAN = new System.Windows.Forms.GroupBox();
            this.textBoxVarX_NAN = new System.Windows.Forms.TextBox();
            this.groupBoxResult_NAN = new System.Windows.Forms.GroupBox();
            this.textBoxResult_NAN = new System.Windows.Forms.TextBox();
            this.buttonDone_NAN = new System.Windows.Forms.Button();
            this.buttonHelp_NAN = new System.Windows.Forms.Button();
            this.textBoxTask_NAN = new System.Windows.Forms.TextBox();
            this.textBoxTextVarX_NAN = new System.Windows.Forms.TextBox();
            this.textBoxTextResult_NAN = new System.Windows.Forms.TextBox();
            this.groupBoxTask_NAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_NAN)).BeginInit();
            this.groupBoxEnter_NAN.SuspendLayout();
            this.groupBoxResult_NAN.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_NAN
            // 
            this.groupBoxTask_NAN.Controls.Add(this.textBoxTask_NAN);
            this.groupBoxTask_NAN.Controls.Add(this.pictureBoxFormula_NAN);
            this.groupBoxTask_NAN.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_NAN.Name = "groupBoxTask_NAN";
            this.groupBoxTask_NAN.Size = new System.Drawing.Size(776, 236);
            this.groupBoxTask_NAN.TabIndex = 0;
            this.groupBoxTask_NAN.TabStop = false;
            this.groupBoxTask_NAN.Text = "Условие";
            // 
            // pictureBoxFormula_NAN
            // 
            this.pictureBoxFormula_NAN.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_NAN.Image")));
            this.pictureBoxFormula_NAN.Location = new System.Drawing.Point(565, 21);
            this.pictureBoxFormula_NAN.Name = "pictureBoxFormula_NAN";
            this.pictureBoxFormula_NAN.Size = new System.Drawing.Size(205, 76);
            this.pictureBoxFormula_NAN.TabIndex = 0;
            this.pictureBoxFormula_NAN.TabStop = false;
            // 
            // groupBoxEnter_NAN
            // 
            this.groupBoxEnter_NAN.Controls.Add(this.textBoxTextVarX_NAN);
            this.groupBoxEnter_NAN.Controls.Add(this.textBoxVarX_NAN);
            this.groupBoxEnter_NAN.Location = new System.Drawing.Point(13, 255);
            this.groupBoxEnter_NAN.Name = "groupBoxEnter_NAN";
            this.groupBoxEnter_NAN.Size = new System.Drawing.Size(385, 128);
            this.groupBoxEnter_NAN.TabIndex = 1;
            this.groupBoxEnter_NAN.TabStop = false;
            this.groupBoxEnter_NAN.Text = "Ввод данных";
            // 
            // textBoxVarX_NAN
            // 
            this.textBoxVarX_NAN.Location = new System.Drawing.Point(7, 71);
            this.textBoxVarX_NAN.Name = "textBoxVarX_NAN";
            this.textBoxVarX_NAN.Size = new System.Drawing.Size(111, 22);
            this.textBoxVarX_NAN.TabIndex = 0;
            this.textBoxVarX_NAN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_NAN_KeyPress);
            // 
            // groupBoxResult_NAN
            // 
            this.groupBoxResult_NAN.Controls.Add(this.textBoxTextResult_NAN);
            this.groupBoxResult_NAN.Controls.Add(this.textBoxResult_NAN);
            this.groupBoxResult_NAN.Location = new System.Drawing.Point(404, 256);
            this.groupBoxResult_NAN.Name = "groupBoxResult_NAN";
            this.groupBoxResult_NAN.Size = new System.Drawing.Size(384, 128);
            this.groupBoxResult_NAN.TabIndex = 2;
            this.groupBoxResult_NAN.TabStop = false;
            this.groupBoxResult_NAN.Text = "Вывод данных";
            // 
            // textBoxResult_NAN
            // 
            this.textBoxResult_NAN.Location = new System.Drawing.Point(15, 72);
            this.textBoxResult_NAN.Name = "textBoxResult_NAN";
            this.textBoxResult_NAN.ReadOnly = true;
            this.textBoxResult_NAN.Size = new System.Drawing.Size(115, 22);
            this.textBoxResult_NAN.TabIndex = 0;
            // 
            // buttonDone_NAN
            // 
            this.buttonDone_NAN.Location = new System.Drawing.Point(614, 390);
            this.buttonDone_NAN.Name = "buttonDone_NAN";
            this.buttonDone_NAN.Size = new System.Drawing.Size(174, 48);
            this.buttonDone_NAN.TabIndex = 3;
            this.buttonDone_NAN.Text = "Выполнить";
            this.buttonDone_NAN.UseVisualStyleBackColor = true;
            this.buttonDone_NAN.Click += new System.EventHandler(this.buttonDone_NAN_Click);
            // 
            // buttonHelp_NAN
            // 
            this.buttonHelp_NAN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_NAN.Location = new System.Drawing.Point(561, 390);
            this.buttonHelp_NAN.Name = "buttonHelp_NAN";
            this.buttonHelp_NAN.Size = new System.Drawing.Size(47, 48);
            this.buttonHelp_NAN.TabIndex = 4;
            this.buttonHelp_NAN.Text = "?";
            this.buttonHelp_NAN.UseVisualStyleBackColor = true;
            this.buttonHelp_NAN.Click += new System.EventHandler(this.buttonHelp_NAN_Click);
            // 
            // textBoxTask_NAN
            // 
            this.textBoxTask_NAN.Location = new System.Drawing.Point(8, 22);
            this.textBoxTask_NAN.Multiline = true;
            this.textBoxTask_NAN.Name = "textBoxTask_NAN";
            this.textBoxTask_NAN.ReadOnly = true;
            this.textBoxTask_NAN.Size = new System.Drawing.Size(551, 174);
            this.textBoxTask_NAN.TabIndex = 1;
            this.textBoxTask_NAN.Text = "Вычислить выражение по формуле";
            // 
            // textBoxTextVarX_NAN
            // 
            this.textBoxTextVarX_NAN.Location = new System.Drawing.Point(7, 38);
            this.textBoxTextVarX_NAN.Multiline = true;
            this.textBoxTextVarX_NAN.Name = "textBoxTextVarX_NAN";
            this.textBoxTextVarX_NAN.ReadOnly = true;
            this.textBoxTextVarX_NAN.Size = new System.Drawing.Size(111, 27);
            this.textBoxTextVarX_NAN.TabIndex = 1;
            this.textBoxTextVarX_NAN.Text = "Переменная X:";
            // 
            // textBoxTextResult_NAN
            // 
            this.textBoxTextResult_NAN.Location = new System.Drawing.Point(15, 36);
            this.textBoxTextResult_NAN.Multiline = true;
            this.textBoxTextResult_NAN.Name = "textBoxTextResult_NAN";
            this.textBoxTextResult_NAN.ReadOnly = true;
            this.textBoxTextResult_NAN.Size = new System.Drawing.Size(115, 28);
            this.textBoxTextResult_NAN.TabIndex = 1;
            this.textBoxTextResult_NAN.Text = "Результат:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHelp_NAN);
            this.Controls.Add(this.buttonDone_NAN);
            this.Controls.Add(this.groupBoxResult_NAN);
            this.Controls.Add(this.groupBoxEnter_NAN);
            this.Controls.Add(this.groupBoxTask_NAN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 26 | Николаева А. Н.";
            this.groupBoxTask_NAN.ResumeLayout(false);
            this.groupBoxTask_NAN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_NAN)).EndInit();
            this.groupBoxEnter_NAN.ResumeLayout(false);
            this.groupBoxEnter_NAN.PerformLayout();
            this.groupBoxResult_NAN.ResumeLayout(false);
            this.groupBoxResult_NAN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_NAN;
        private System.Windows.Forms.PictureBox pictureBoxFormula_NAN;
        private System.Windows.Forms.GroupBox groupBoxEnter_NAN;
        private System.Windows.Forms.GroupBox groupBoxResult_NAN;
        private System.Windows.Forms.TextBox textBoxResult_NAN;
        private System.Windows.Forms.Button buttonDone_NAN;
        private System.Windows.Forms.TextBox textBoxVarX_NAN;
        private System.Windows.Forms.Button buttonHelp_NAN;
        private System.Windows.Forms.TextBox textBoxTask_NAN;
        private System.Windows.Forms.TextBox textBoxTextVarX_NAN;
        private System.Windows.Forms.TextBox textBoxTextResult_NAN;
    }
}

