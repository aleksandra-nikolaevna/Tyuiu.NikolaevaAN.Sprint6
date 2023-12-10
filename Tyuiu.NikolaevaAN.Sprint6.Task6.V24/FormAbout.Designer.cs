
namespace Tyuiu.NikolaevaAN.Sprint6.Task6.V24
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
            this.pictureBoxAvatar_NAN = new System.Windows.Forms.PictureBox();
            this.labelInfo_NAN = new System.Windows.Forms.Label();
            this.buttonOk_NAN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_NAN)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_NAN
            // 
            this.pictureBoxAvatar_NAN.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_NAN.Image")));
            this.pictureBoxAvatar_NAN.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxAvatar_NAN.Name = "pictureBoxAvatar_NAN";
            this.pictureBoxAvatar_NAN.Size = new System.Drawing.Size(177, 226);
            this.pictureBoxAvatar_NAN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar_NAN.TabIndex = 0;
            this.pictureBoxAvatar_NAN.TabStop = false;
            // 
            // labelInfo_NAN
            // 
            this.labelInfo_NAN.AutoSize = true;
            this.labelInfo_NAN.Location = new System.Drawing.Point(197, 13);
            this.labelInfo_NAN.Name = "labelInfo_NAN";
            this.labelInfo_NAN.Size = new System.Drawing.Size(365, 153);
            this.labelInfo_NAN.TabIndex = 1;
            this.labelInfo_NAN.Text = resources.GetString("labelInfo_NAN.Text");
            // 
            // buttonOk_NAN
            // 
            this.buttonOk_NAN.Location = new System.Drawing.Point(455, 205);
            this.buttonOk_NAN.Name = "buttonOk_NAN";
            this.buttonOk_NAN.Size = new System.Drawing.Size(107, 33);
            this.buttonOk_NAN.TabIndex = 2;
            this.buttonOk_NAN.Text = "Ок";
            this.buttonOk_NAN.UseVisualStyleBackColor = true;
            this.buttonOk_NAN.Click += new System.EventHandler(this.buttonOk_NAN_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 250);
            this.Controls.Add(this.buttonOk_NAN);
            this.Controls.Add(this.labelInfo_NAN);
            this.Controls.Add(this.pictureBoxAvatar_NAN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_NAN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_NAN;
        private System.Windows.Forms.Label labelInfo_NAN;
        private System.Windows.Forms.Button buttonOk_NAN;
    }
}