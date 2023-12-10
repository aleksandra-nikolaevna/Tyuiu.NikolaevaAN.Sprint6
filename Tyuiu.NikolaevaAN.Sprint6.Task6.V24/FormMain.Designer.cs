
namespace Tyuiu.NikolaevaAN.Sprint6.Task6.V24
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelTop_NAN = new System.Windows.Forms.Panel();
            this.panelLeft_NAN = new System.Windows.Forms.Panel();
            this.splitterLeftRight_NAN = new System.Windows.Forms.Splitter();
            this.panelRight_NAN = new System.Windows.Forms.Panel();
            this.buttonOpenFile_NAN = new System.Windows.Forms.Button();
            this.panelTopButtons_NAN = new System.Windows.Forms.Panel();
            this.groupBoxTask_NAN = new System.Windows.Forms.GroupBox();
            this.textBoxTask_NAN = new System.Windows.Forms.TextBox();
            this.groupBoxEnter_NAN = new System.Windows.Forms.GroupBox();
            this.groupBoxResult_NAN = new System.Windows.Forms.GroupBox();
            this.textBoxEnter_NAN = new System.Windows.Forms.TextBox();
            this.textBoxResult_NAN = new System.Windows.Forms.TextBox();
            this.buttonDone_NAN = new System.Windows.Forms.Button();
            this.buttonHelp_NAN = new System.Windows.Forms.Button();
            this.openFileDialogTask_NAN = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_NAN = new System.Windows.Forms.ToolTip(this.components);
            this.panelTop_NAN.SuspendLayout();
            this.panelLeft_NAN.SuspendLayout();
            this.panelRight_NAN.SuspendLayout();
            this.panelTopButtons_NAN.SuspendLayout();
            this.groupBoxTask_NAN.SuspendLayout();
            this.groupBoxEnter_NAN.SuspendLayout();
            this.groupBoxResult_NAN.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop_NAN
            // 
            this.panelTop_NAN.Controls.Add(this.groupBoxTask_NAN);
            this.panelTop_NAN.Controls.Add(this.panelTopButtons_NAN);
            this.panelTop_NAN.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_NAN.Location = new System.Drawing.Point(0, 0);
            this.panelTop_NAN.Name = "panelTop_NAN";
            this.panelTop_NAN.Size = new System.Drawing.Size(850, 186);
            this.panelTop_NAN.TabIndex = 0;
            // 
            // panelLeft_NAN
            // 
            this.panelLeft_NAN.Controls.Add(this.groupBoxEnter_NAN);
            this.panelLeft_NAN.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_NAN.Location = new System.Drawing.Point(0, 186);
            this.panelLeft_NAN.Name = "panelLeft_NAN";
            this.panelLeft_NAN.Padding = new System.Windows.Forms.Padding(5);
            this.panelLeft_NAN.Size = new System.Drawing.Size(406, 307);
            this.panelLeft_NAN.TabIndex = 1;
            // 
            // splitterLeftRight_NAN
            // 
            this.splitterLeftRight_NAN.Location = new System.Drawing.Point(406, 186);
            this.splitterLeftRight_NAN.Name = "splitterLeftRight_NAN";
            this.splitterLeftRight_NAN.Size = new System.Drawing.Size(3, 307);
            this.splitterLeftRight_NAN.TabIndex = 2;
            this.splitterLeftRight_NAN.TabStop = false;
            // 
            // panelRight_NAN
            // 
            this.panelRight_NAN.Controls.Add(this.groupBoxResult_NAN);
            this.panelRight_NAN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_NAN.Location = new System.Drawing.Point(409, 186);
            this.panelRight_NAN.Name = "panelRight_NAN";
            this.panelRight_NAN.Padding = new System.Windows.Forms.Padding(5);
            this.panelRight_NAN.Size = new System.Drawing.Size(441, 307);
            this.panelRight_NAN.TabIndex = 3;
            // 
            // buttonOpenFile_NAN
            // 
            this.buttonOpenFile_NAN.BackColor = System.Drawing.Color.Teal;
            this.buttonOpenFile_NAN.Location = new System.Drawing.Point(3, 4);
            this.buttonOpenFile_NAN.Name = "buttonOpenFile_NAN";
            this.buttonOpenFile_NAN.Size = new System.Drawing.Size(102, 89);
            this.buttonOpenFile_NAN.TabIndex = 0;
            this.buttonOpenFile_NAN.Text = "Выбрать файл";
            this.toolTip_NAN.SetToolTip(this.buttonOpenFile_NAN, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.buttonOpenFile_NAN.UseVisualStyleBackColor = false;
            this.buttonOpenFile_NAN.Click += new System.EventHandler(this.buttonOpenFile_NAN_Click);
            // 
            // panelTopButtons_NAN
            // 
            this.panelTopButtons_NAN.Controls.Add(this.buttonHelp_NAN);
            this.panelTopButtons_NAN.Controls.Add(this.buttonDone_NAN);
            this.panelTopButtons_NAN.Controls.Add(this.buttonOpenFile_NAN);
            this.panelTopButtons_NAN.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopButtons_NAN.Location = new System.Drawing.Point(0, 0);
            this.panelTopButtons_NAN.Name = "panelTopButtons_NAN";
            this.panelTopButtons_NAN.Size = new System.Drawing.Size(850, 96);
            this.panelTopButtons_NAN.TabIndex = 1;
            // 
            // groupBoxTask_NAN
            // 
            this.groupBoxTask_NAN.Controls.Add(this.textBoxTask_NAN);
            this.groupBoxTask_NAN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_NAN.Location = new System.Drawing.Point(0, 96);
            this.groupBoxTask_NAN.Name = "groupBoxTask_NAN";
            this.groupBoxTask_NAN.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxTask_NAN.Size = new System.Drawing.Size(850, 90);
            this.groupBoxTask_NAN.TabIndex = 2;
            this.groupBoxTask_NAN.TabStop = false;
            this.groupBoxTask_NAN.Text = "Условие:";
            // 
            // textBoxTask_NAN
            // 
            this.textBoxTask_NAN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_NAN.Location = new System.Drawing.Point(5, 20);
            this.textBoxTask_NAN.Multiline = true;
            this.textBoxTask_NAN.Name = "textBoxTask_NAN";
            this.textBoxTask_NAN.ReadOnly = true;
            this.textBoxTask_NAN.Size = new System.Drawing.Size(840, 65);
            this.textBoxTask_NAN.TabIndex = 0;
            this.textBoxTask_NAN.Text = resources.GetString("textBoxTask_NAN.Text");
            // 
            // groupBoxEnter_NAN
            // 
            this.groupBoxEnter_NAN.Controls.Add(this.textBoxEnter_NAN);
            this.groupBoxEnter_NAN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxEnter_NAN.Location = new System.Drawing.Point(5, 5);
            this.groupBoxEnter_NAN.Name = "groupBoxEnter_NAN";
            this.groupBoxEnter_NAN.Size = new System.Drawing.Size(396, 297);
            this.groupBoxEnter_NAN.TabIndex = 0;
            this.groupBoxEnter_NAN.TabStop = false;
            this.groupBoxEnter_NAN.Text = "Ввод:";
            // 
            // groupBoxResult_NAN
            // 
            this.groupBoxResult_NAN.Controls.Add(this.textBoxResult_NAN);
            this.groupBoxResult_NAN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult_NAN.Location = new System.Drawing.Point(5, 5);
            this.groupBoxResult_NAN.Name = "groupBoxResult_NAN";
            this.groupBoxResult_NAN.Size = new System.Drawing.Size(431, 297);
            this.groupBoxResult_NAN.TabIndex = 0;
            this.groupBoxResult_NAN.TabStop = false;
            this.groupBoxResult_NAN.Text = "Вывод:";
            // 
            // textBoxEnter_NAN
            // 
            this.textBoxEnter_NAN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxEnter_NAN.Location = new System.Drawing.Point(3, 18);
            this.textBoxEnter_NAN.Multiline = true;
            this.textBoxEnter_NAN.Name = "textBoxEnter_NAN";
            this.textBoxEnter_NAN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxEnter_NAN.Size = new System.Drawing.Size(390, 276);
            this.textBoxEnter_NAN.TabIndex = 0;
            // 
            // textBoxResult_NAN
            // 
            this.textBoxResult_NAN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_NAN.Location = new System.Drawing.Point(3, 18);
            this.textBoxResult_NAN.Multiline = true;
            this.textBoxResult_NAN.Name = "textBoxResult_NAN";
            this.textBoxResult_NAN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_NAN.Size = new System.Drawing.Size(425, 276);
            this.textBoxResult_NAN.TabIndex = 0;
            // 
            // buttonDone_NAN
            // 
            this.buttonDone_NAN.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonDone_NAN.Enabled = false;
            this.buttonDone_NAN.Location = new System.Drawing.Point(111, 4);
            this.buttonDone_NAN.Name = "buttonDone_NAN";
            this.buttonDone_NAN.Size = new System.Drawing.Size(102, 89);
            this.buttonDone_NAN.TabIndex = 1;
            this.buttonDone_NAN.Text = "Выполнить";
            this.toolTip_NAN.SetToolTip(this.buttonDone_NAN, "Выводит первое слово каждой строки в результирующую строку");
            this.buttonDone_NAN.UseVisualStyleBackColor = false;
            this.buttonDone_NAN.Click += new System.EventHandler(this.buttonDone_NAN_Click);
            // 
            // buttonHelp_NAN
            // 
            this.buttonHelp_NAN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_NAN.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonHelp_NAN.Location = new System.Drawing.Point(744, 4);
            this.buttonHelp_NAN.Name = "buttonHelp_NAN";
            this.buttonHelp_NAN.Size = new System.Drawing.Size(101, 89);
            this.buttonHelp_NAN.TabIndex = 2;
            this.buttonHelp_NAN.Text = "Справка";
            this.toolTip_NAN.SetToolTip(this.buttonHelp_NAN, "Сведение о программе");
            this.buttonHelp_NAN.UseVisualStyleBackColor = false;
            this.buttonHelp_NAN.Click += new System.EventHandler(this.buttonHelp_NAN_Click);
            // 
            // openFileDialogTask_NAN
            // 
            this.openFileDialogTask_NAN.FileName = "openFileDialog1";
            // 
            // toolTip_NAN
            // 
            this.toolTip_NAN.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_NAN.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 493);
            this.Controls.Add(this.panelRight_NAN);
            this.Controls.Add(this.splitterLeftRight_NAN);
            this.Controls.Add(this.panelLeft_NAN);
            this.Controls.Add(this.panelTop_NAN);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 24 | Николаева А. Н.";
            this.panelTop_NAN.ResumeLayout(false);
            this.panelLeft_NAN.ResumeLayout(false);
            this.panelRight_NAN.ResumeLayout(false);
            this.panelTopButtons_NAN.ResumeLayout(false);
            this.groupBoxTask_NAN.ResumeLayout(false);
            this.groupBoxTask_NAN.PerformLayout();
            this.groupBoxEnter_NAN.ResumeLayout(false);
            this.groupBoxEnter_NAN.PerformLayout();
            this.groupBoxResult_NAN.ResumeLayout(false);
            this.groupBoxResult_NAN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_NAN;
        private System.Windows.Forms.Panel panelLeft_NAN;
        private System.Windows.Forms.Splitter splitterLeftRight_NAN;
        private System.Windows.Forms.Panel panelRight_NAN;
        private System.Windows.Forms.Button buttonOpenFile_NAN;
        private System.Windows.Forms.GroupBox groupBoxTask_NAN;
        private System.Windows.Forms.Panel panelTopButtons_NAN;
        private System.Windows.Forms.TextBox textBoxTask_NAN;
        private System.Windows.Forms.GroupBox groupBoxEnter_NAN;
        private System.Windows.Forms.GroupBox groupBoxResult_NAN;
        private System.Windows.Forms.TextBox textBoxEnter_NAN;
        private System.Windows.Forms.TextBox textBoxResult_NAN;
        private System.Windows.Forms.Button buttonDone_NAN;
        private System.Windows.Forms.Button buttonHelp_NAN;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_NAN;
        private System.Windows.Forms.ToolTip toolTip_NAN;
    }
}

