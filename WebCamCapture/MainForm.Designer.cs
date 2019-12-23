namespace WebCamCapture
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnScreenCapture = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CamView = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOrderEdit = new System.Windows.Forms.Button();
            this.photoGalleraya = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userCardText = new System.Windows.Forms.Label();
            this.numberOprerationText = new System.Windows.Forms.Label();
            this.rollerNumberText = new System.Windows.Forms.Label();
            this.nomberOrderText = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйЗаказToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.камераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.путьСохраненияФайловToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ScreenView = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabScreenView = new System.Windows.Forms.TabPage();
            this.tabSetting = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFileDirOk = new System.Windows.Forms.Button();
            this.FileDirView = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ListCaptureDevices = new System.Windows.Forms.ComboBox();
            this.ListCaptutreModes = new System.Windows.Forms.ComboBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.CamView)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabScreenView.SuspendLayout();
            this.tabSetting.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnScreenCapture
            // 
            this.btnScreenCapture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScreenCapture.Enabled = false;
            this.btnScreenCapture.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnScreenCapture.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnScreenCapture.ForeColor = System.Drawing.Color.Black;
            this.btnScreenCapture.Location = new System.Drawing.Point(7, 17);
            this.btnScreenCapture.Name = "btnScreenCapture";
            this.btnScreenCapture.Size = new System.Drawing.Size(141, 30);
            this.btnScreenCapture.TabIndex = 3;
            this.btnScreenCapture.Text = "СКРИНШОТ";
            this.btnScreenCapture.UseVisualStyleBackColor = true;
            this.btnScreenCapture.Click += new System.EventHandler(this.BtnScreenCapture_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(151, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "TEST";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // CamView
            // 
            this.CamView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CamView.BackColor = System.Drawing.Color.Black;
            this.CamView.Location = new System.Drawing.Point(590, 12);
            this.CamView.Name = "CamView";
            this.CamView.Size = new System.Drawing.Size(350, 246);
            this.CamView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CamView.TabIndex = 1;
            this.CamView.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnOrderEdit);
            this.panel1.Controls.Add(this.photoGalleraya);
            this.panel1.Controls.Add(this.btnScreenCapture);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(590, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 369);
            this.panel1.TabIndex = 10;
            // 
            // btnOrderEdit
            // 
            this.btnOrderEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrderEdit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOrderEdit.ForeColor = System.Drawing.Color.Black;
            this.btnOrderEdit.Location = new System.Drawing.Point(203, 17);
            this.btnOrderEdit.Name = "btnOrderEdit";
            this.btnOrderEdit.Size = new System.Drawing.Size(141, 30);
            this.btnOrderEdit.TabIndex = 19;
            this.btnOrderEdit.Text = "ЗАКАЗ / ПРАВКА";
            this.btnOrderEdit.UseVisualStyleBackColor = true;
            this.btnOrderEdit.Click += new System.EventHandler(this.BtnOrderEdit_Click);
            // 
            // photoGalleraya
            // 
            this.photoGalleraya.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.photoGalleraya.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.photoGalleraya.FullRowSelect = true;
            this.photoGalleraya.HideSelection = false;
            this.photoGalleraya.Location = new System.Drawing.Point(0, 65);
            this.photoGalleraya.MultiSelect = false;
            this.photoGalleraya.Name = "photoGalleraya";
            this.photoGalleraya.Size = new System.Drawing.Size(350, 301);
            this.photoGalleraya.TabIndex = 9;
            this.photoGalleraya.UseCompatibleStateImageBehavior = false;
            this.photoGalleraya.View = System.Windows.Forms.View.Details;
            this.photoGalleraya.SelectedIndexChanged += new System.EventHandler(this.PhotoGalleraya_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Изобр.";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "№ Заказа";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 86;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Дата и время";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 97;
            // 
            // userCardText
            // 
            this.userCardText.AutoSize = true;
            this.userCardText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userCardText.Location = new System.Drawing.Point(5, 121);
            this.userCardText.Name = "userCardText";
            this.userCardText.Size = new System.Drawing.Size(152, 21);
            this.userCardText.TabIndex = 27;
            this.userCardText.Text = "ИСПОЛНИТЕЛЬ:";
            // 
            // numberOprerationText
            // 
            this.numberOprerationText.AutoSize = true;
            this.numberOprerationText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberOprerationText.Location = new System.Drawing.Point(21, 88);
            this.numberOprerationText.Name = "numberOprerationText";
            this.numberOprerationText.Size = new System.Drawing.Size(136, 21);
            this.numberOprerationText.TabIndex = 26;
            this.numberOprerationText.Text = "ОПЕРАЦИЯ №:";
            // 
            // rollerNumberText
            // 
            this.rollerNumberText.AutoSize = true;
            this.rollerNumberText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rollerNumberText.Location = new System.Drawing.Point(57, 55);
            this.rollerNumberText.Name = "rollerNumberText";
            this.rollerNumberText.Size = new System.Drawing.Size(100, 21);
            this.rollerNumberText.TabIndex = 25;
            this.rollerNumberText.Text = "РОЛИК №:";
            // 
            // nomberOrderText
            // 
            this.nomberOrderText.AutoSize = true;
            this.nomberOrderText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nomberOrderText.Location = new System.Drawing.Point(61, 22);
            this.nomberOrderText.Name = "nomberOrderText";
            this.nomberOrderText.Size = new System.Drawing.Size(96, 21);
            this.nomberOrderText.TabIndex = 24;
            this.nomberOrderText.Text = "ЗАКАЗ №:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.настройкиToolStripMenuItem1,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(946, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйЗаказToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // новыйЗаказToolStripMenuItem
            // 
            this.новыйЗаказToolStripMenuItem.Name = "новыйЗаказToolStripMenuItem";
            this.новыйЗаказToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.новыйЗаказToolStripMenuItem.Text = "Новый заказ";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // настройкиToolStripMenuItem1
            // 
            this.настройкиToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.камераToolStripMenuItem,
            this.путьСохраненияФайловToolStripMenuItem});
            this.настройкиToolStripMenuItem1.Name = "настройкиToolStripMenuItem1";
            this.настройкиToolStripMenuItem1.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem1.Text = "Настройки";
            // 
            // камераToolStripMenuItem
            // 
            this.камераToolStripMenuItem.Name = "камераToolStripMenuItem";
            this.камераToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.камераToolStripMenuItem.Text = "Камера";
            this.камераToolStripMenuItem.Click += new System.EventHandler(this.КамераToolStripMenuItem_Click);
            // 
            // путьСохраненияФайловToolStripMenuItem
            // 
            this.путьСохраненияФайловToolStripMenuItem.Name = "путьСохраненияФайловToolStripMenuItem";
            this.путьСохраненияФайловToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.путьСохраненияФайловToolStripMenuItem.Text = "Путь сохранения файлов";
            this.путьСохраненияФайловToolStripMenuItem.Click += new System.EventHandler(this.ПутьСохраненияФайловToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // ScreenView
            // 
            this.ScreenView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScreenView.BackColor = System.Drawing.Color.Black;
            this.ScreenView.Location = new System.Drawing.Point(0, 154);
            this.ScreenView.Name = "ScreenView";
            this.ScreenView.Size = new System.Drawing.Size(576, 442);
            this.ScreenView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ScreenView.TabIndex = 9;
            this.ScreenView.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabScreenView);
            this.tabControl1.Controls.Add(this.tabSetting);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(584, 625);
            this.tabControl1.TabIndex = 1;
            // 
            // tabScreenView
            // 
            this.tabScreenView.Controls.Add(this.userCardText);
            this.tabScreenView.Controls.Add(this.ScreenView);
            this.tabScreenView.Controls.Add(this.numberOprerationText);
            this.tabScreenView.Controls.Add(this.nomberOrderText);
            this.tabScreenView.Controls.Add(this.rollerNumberText);
            this.tabScreenView.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabScreenView.Location = new System.Drawing.Point(4, 22);
            this.tabScreenView.Name = "tabScreenView";
            this.tabScreenView.Padding = new System.Windows.Forms.Padding(3);
            this.tabScreenView.Size = new System.Drawing.Size(576, 599);
            this.tabScreenView.TabIndex = 0;
            this.tabScreenView.Text = "Обзор";
            this.tabScreenView.UseVisualStyleBackColor = true;
            // 
            // tabSetting
            // 
            this.tabSetting.Controls.Add(this.panel2);
            this.tabSetting.Controls.Add(this.groupBox1);
            this.tabSetting.Location = new System.Drawing.Point(4, 22);
            this.tabSetting.Name = "tabSetting";
            this.tabSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tabSetting.Size = new System.Drawing.Size(576, 599);
            this.tabSetting.TabIndex = 1;
            this.tabSetting.Text = "Настройки";
            this.tabSetting.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnFileDirOk);
            this.panel2.Controls.Add(this.FileDirView);
            this.panel2.Location = new System.Drawing.Point(33, 288);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(498, 100);
            this.panel2.TabIndex = 20;
            // 
            // btnFileDirOk
            // 
            this.btnFileDirOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFileDirOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnFileDirOk.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFileDirOk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFileDirOk.ForeColor = System.Drawing.Color.Black;
            this.btnFileDirOk.Location = new System.Drawing.Point(391, 38);
            this.btnFileDirOk.Name = "btnFileDirOk";
            this.btnFileDirOk.Size = new System.Drawing.Size(91, 30);
            this.btnFileDirOk.TabIndex = 4;
            this.btnFileDirOk.Text = "OK";
            this.btnFileDirOk.UseVisualStyleBackColor = true;
            this.btnFileDirOk.Click += new System.EventHandler(this.btnFileDirOk_Click);
            // 
            // FileDirView
            // 
            this.FileDirView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileDirView.Location = new System.Drawing.Point(13, 40);
            this.FileDirView.Name = "FileDirView";
            this.FileDirView.Size = new System.Drawing.Size(372, 26);
            this.FileDirView.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ListCaptureDevices);
            this.groupBox1.Controls.Add(this.ListCaptutreModes);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(33, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 143);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки камеры";
            // 
            // ListCaptureDevices
            // 
            this.ListCaptureDevices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ListCaptureDevices.DisplayMember = "5";
            this.ListCaptureDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListCaptureDevices.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListCaptureDevices.FormattingEnabled = true;
            this.ListCaptureDevices.Location = new System.Drawing.Point(190, 36);
            this.ListCaptureDevices.Name = "ListCaptureDevices";
            this.ListCaptureDevices.Size = new System.Drawing.Size(137, 27);
            this.ListCaptureDevices.TabIndex = 6;
            this.ListCaptureDevices.SelectionChangeCommitted += new System.EventHandler(this.ListCaptureDevices_SelectionChangeCommitted);
            this.ListCaptureDevices.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListCaptureDevices_MouseDown);
            // 
            // ListCaptutreModes
            // 
            this.ListCaptutreModes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ListCaptutreModes.BackColor = System.Drawing.SystemColors.Window;
            this.ListCaptutreModes.DisplayMember = "5";
            this.ListCaptutreModes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListCaptutreModes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListCaptutreModes.FormattingEnabled = true;
            this.ListCaptutreModes.Location = new System.Drawing.Point(17, 36);
            this.ListCaptutreModes.Name = "ListCaptutreModes";
            this.ListCaptutreModes.Size = new System.Drawing.Size(137, 27);
            this.ListCaptutreModes.TabIndex = 5;
            this.ListCaptutreModes.SelectedIndexChanged += new System.EventHandler(this.ListCaptutreModes_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 627);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CamView);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WebCamCapture";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CamView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabScreenView.ResumeLayout(false);
            this.tabScreenView.PerformLayout();
            this.tabSetting.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnScreenCapture;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox CamView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView photoGalleraya;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnOrderEdit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem камераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem путьСохраненияФайловToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйЗаказToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Label userCardText;
        private System.Windows.Forms.Label numberOprerationText;
        private System.Windows.Forms.Label rollerNumberText;
        private System.Windows.Forms.Label nomberOrderText;
        private System.Windows.Forms.PictureBox ScreenView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabScreenView;
        private System.Windows.Forms.TabPage tabSetting;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFileDirOk;
        private System.Windows.Forms.TextBox FileDirView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ListCaptureDevices;
        private System.Windows.Forms.ComboBox ListCaptutreModes;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
    }
}

