
namespace Tyuiu.NikolaevaAN.Sprint6.Task7.V23
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelInfo_NAN = new System.Windows.Forms.Label();
            this.buttonOk_NAN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 261);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelInfo_NAN
            // 
            this.labelInfo_NAN.AutoSize = true;
            this.labelInfo_NAN.Location = new System.Drawing.Point(226, 13);
            this.labelInfo_NAN.Name = "labelInfo_NAN";
            this.labelInfo_NAN.Size = new System.Drawing.Size(365, 153);
            this.labelInfo_NAN.TabIndex = 1;
            this.labelInfo_NAN.Text = resources.GetString("labelInfo_NAN.Text");
            // 
            // buttonOk_NAN
            // 
            this.buttonOk_NAN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk_NAN.Location = new System.Drawing.Point(488, 244);
            this.buttonOk_NAN.Name = "buttonOk_NAN";
            this.buttonOk_NAN.Size = new System.Drawing.Size(103, 29);
            this.buttonOk_NAN.TabIndex = 2;
            this.buttonOk_NAN.Text = "Ок";
            this.buttonOk_NAN.UseVisualStyleBackColor = true;
            this.buttonOk_NAN.Click += new System.EventHandler(this.buttonOk_NAN_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 289);
            this.Controls.Add(this.buttonOk_NAN);
            this.Controls.Add(this.labelInfo_NAN);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelInfo_NAN;
        private System.Windows.Forms.Button buttonOk_NAN;
    }
}