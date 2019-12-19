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
            this.btnScreenCapture = new System.Windows.Forms.Button();
            this.ListCaptutreModes = new System.Windows.Forms.ComboBox();
            this.ListCaptureDevices = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ScreenView = new System.Windows.Forms.PictureBox();
            this.CamView = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOrderEdit = new System.Windows.Forms.Button();
            this.userNameList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numberRollerList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numberOperation = new System.Windows.Forms.TextBox();
            this.rollerNumber = new System.Windows.Forms.Label();
            this.orderText = new System.Windows.Forms.Label();
            this.nomberOrder = new System.Windows.Forms.TextBox();
            this.photoGalleraya = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйЗаказToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.камераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.путьСохраненияФайловToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CamView)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnScreenCapture
            // 
            this.btnScreenCapture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScreenCapture.Enabled = false;
            this.btnScreenCapture.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnScreenCapture.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnScreenCapture.Location = new System.Drawing.Point(5, 0);
            this.btnScreenCapture.Name = "btnScreenCapture";
            this.btnScreenCapture.Size = new System.Drawing.Size(113, 30);
            this.btnScreenCapture.TabIndex = 3;
            this.btnScreenCapture.Text = "Скриншот";
            this.btnScreenCapture.UseVisualStyleBackColor = true;
            this.btnScreenCapture.Click += new System.EventHandler(this.BtnScreenCapture_Click);
            // 
            // ListCaptutreModes
            // 
            this.ListCaptutreModes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ListCaptutreModes.BackColor = System.Drawing.SystemColors.Window;
            this.ListCaptutreModes.DisplayMember = "5";
            this.ListCaptutreModes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListCaptutreModes.FormattingEnabled = true;
            this.ListCaptutreModes.Location = new System.Drawing.Point(123, 3);
            this.ListCaptutreModes.Name = "ListCaptutreModes";
            this.ListCaptutreModes.Size = new System.Drawing.Size(87, 21);
            this.ListCaptutreModes.TabIndex = 5;
            this.ListCaptutreModes.SelectedIndexChanged += new System.EventHandler(this.ListCaptutreModes_SelectedIndexChanged);
            // 
            // ListCaptureDevices
            // 
            this.ListCaptureDevices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ListCaptureDevices.DisplayMember = "5";
            this.ListCaptureDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListCaptureDevices.FormattingEnabled = true;
            this.ListCaptureDevices.Location = new System.Drawing.Point(215, 3);
            this.ListCaptureDevices.Name = "ListCaptureDevices";
            this.ListCaptureDevices.Size = new System.Drawing.Size(102, 21);
            this.ListCaptureDevices.TabIndex = 6;
            this.ListCaptureDevices.SelectionChangeCommitted += new System.EventHandler(this.ListCaptureDevices_SelectionChangeCommitted);
            this.ListCaptureDevices.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListCaptureDevices_MouseDown);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(110, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 8;
            this.button1.Text = "TEST";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ScreenView
            // 
            this.ScreenView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScreenView.BackColor = System.Drawing.Color.Black;
            this.ScreenView.Location = new System.Drawing.Point(5, 27);
            this.ScreenView.Name = "ScreenView";
            this.ScreenView.Size = new System.Drawing.Size(887, 849);
            this.ScreenView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ScreenView.TabIndex = 9;
            this.ScreenView.TabStop = false;
            // 
            // CamView
            // 
            this.CamView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CamView.BackColor = System.Drawing.Color.Black;
            this.CamView.Location = new System.Drawing.Point(898, 27);
            this.CamView.Name = "CamView";
            this.CamView.Size = new System.Drawing.Size(308, 226);
            this.CamView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CamView.TabIndex = 1;
            this.CamView.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnOrderEdit);
            this.panel1.Controls.Add(this.userNameList);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numberRollerList);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numberOperation);
            this.panel1.Controls.Add(this.rollerNumber);
            this.panel1.Controls.Add(this.orderText);
            this.panel1.Controls.Add(this.nomberOrder);
            this.panel1.Controls.Add(this.photoGalleraya);
            this.panel1.Controls.Add(this.btnScreenCapture);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ListCaptutreModes);
            this.panel1.Controls.Add(this.ListCaptureDevices);
            this.panel1.Location = new System.Drawing.Point(893, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 623);
            this.panel1.TabIndex = 10;
            // 
            // btnOrderEdit
            // 
            this.btnOrderEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrderEdit.Location = new System.Drawing.Point(199, 95);
            this.btnOrderEdit.Name = "btnOrderEdit";
            this.btnOrderEdit.Size = new System.Drawing.Size(102, 24);
            this.btnOrderEdit.TabIndex = 19;
            this.btnOrderEdit.Text = "Заказ/Правка";
            this.btnOrderEdit.UseVisualStyleBackColor = true;
            this.btnOrderEdit.Click += new System.EventHandler(this.BtnOrderEdit_Click);
            // 
            // userNameList
            // 
            this.userNameList.FormattingEnabled = true;
            this.userNameList.Location = new System.Drawing.Point(199, 58);
            this.userNameList.Name = "userNameList";
            this.userNameList.Size = new System.Drawing.Size(113, 21);
            this.userNameList.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "ИСПОЛНИТЕЛЬ";
            // 
            // numberRollerList
            // 
            this.numberRollerList.FormattingEnabled = true;
            this.numberRollerList.Location = new System.Drawing.Point(114, 58);
            this.numberRollerList.Name = "numberRollerList";
            this.numberRollerList.Size = new System.Drawing.Size(75, 21);
            this.numberRollerList.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "№ ОПЕРАЦИИ";
            // 
            // numberOperation
            // 
            this.numberOperation.Location = new System.Drawing.Point(5, 98);
            this.numberOperation.Name = "numberOperation";
            this.numberOperation.Size = new System.Drawing.Size(99, 20);
            this.numberOperation.TabIndex = 14;
            // 
            // rollerNumber
            // 
            this.rollerNumber.AutoSize = true;
            this.rollerNumber.Location = new System.Drawing.Point(118, 41);
            this.rollerNumber.Name = "rollerNumber";
            this.rollerNumber.Size = new System.Drawing.Size(66, 13);
            this.rollerNumber.TabIndex = 13;
            this.rollerNumber.Text = "№ РОЛИКА";
            // 
            // orderText
            // 
            this.orderText.AutoSize = true;
            this.orderText.Location = new System.Drawing.Point(23, 41);
            this.orderText.Name = "orderText";
            this.orderText.Size = new System.Drawing.Size(63, 13);
            this.orderText.TabIndex = 11;
            this.orderText.Text = "№ ЗАКАЗА";
            // 
            // nomberOrder
            // 
            this.nomberOrder.Location = new System.Drawing.Point(5, 57);
            this.nomberOrder.Name = "nomberOrder";
            this.nomberOrder.Size = new System.Drawing.Size(99, 20);
            this.nomberOrder.TabIndex = 10;
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
            this.photoGalleraya.Location = new System.Drawing.Point(5, 134);
            this.photoGalleraya.MultiSelect = false;
            this.photoGalleraya.Name = "photoGalleraya";
            this.photoGalleraya.Size = new System.Drawing.Size(308, 483);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.настройкиToolStripMenuItem1,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1212, 24);
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
            this.новыйЗаказToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.новыйЗаказToolStripMenuItem.Text = "Новый заказ";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 881);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CamView);
            this.Controls.Add(this.ScreenView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "WebCamCapture";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ScreenView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CamView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnScreenCapture;
        private System.Windows.Forms.ComboBox ListCaptutreModes;
        private System.Windows.Forms.ComboBox ListCaptureDevices;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox ScreenView;
        private System.Windows.Forms.PictureBox CamView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView photoGalleraya;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberOperation;
        private System.Windows.Forms.Label rollerNumber;
        private System.Windows.Forms.Label orderText;
        private System.Windows.Forms.TextBox nomberOrder;
        private System.Windows.Forms.ComboBox numberRollerList;
        private System.Windows.Forms.ComboBox userNameList;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

