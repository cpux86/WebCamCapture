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
            this.components = new System.ComponentModel.Container();
            this.btnScreenCapture = new System.Windows.Forms.Button();
            this.ListCaptutreModes = new System.Windows.Forms.ComboBox();
            this.ListCaptureDevices = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ScreenView = new System.Windows.Forms.PictureBox();
            this.CamView = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userCardText = new System.Windows.Forms.Label();
            this.numberOprerationText = new System.Windows.Forms.Label();
            this.rollerNumberText = new System.Windows.Forms.Label();
            this.nomberOrderText = new System.Windows.Forms.Label();
            this.btnOrderEdit = new System.Windows.Forms.Button();
            this.photoGalleraya = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.numberRollerList = new System.Windows.Forms.ComboBox();
            this.rollerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderDataSet = new WebCamCapture.orderDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.rollerNumber = new System.Windows.Forms.Label();
            this.orderText = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйЗаказToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.камераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.путьСохраненияФайловToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabScreenView = new System.Windows.Forms.TabPage();
            this.tabCardOrder = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nomberOrder = new System.Windows.Forms.TextBox();
            this.numberOperationList = new System.Windows.Forms.ComboBox();
            this.operationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderDataSet1 = new WebCamCapture.orderDataSet1();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnCardOrderOk = new System.Windows.Forms.Button();
            this.userCardList = new System.Windows.Forms.ComboBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderDataSet2 = new WebCamCapture.orderDataSet2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rollerTableAdapter = new WebCamCapture.orderDataSetTableAdapters.rollerTableAdapter();
            this.operationTableAdapter = new WebCamCapture.orderDataSet1TableAdapters.operationTableAdapter();
            this.userTableAdapter = new WebCamCapture.orderDataSet2TableAdapters.userTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CamView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rollerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabScreenView.SuspendLayout();
            this.tabCardOrder.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.operationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataSet2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnScreenCapture
            // 
            this.btnScreenCapture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScreenCapture.Enabled = false;
            this.btnScreenCapture.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnScreenCapture.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnScreenCapture.Location = new System.Drawing.Point(3, 3);
            this.btnScreenCapture.Name = "btnScreenCapture";
            this.btnScreenCapture.Size = new System.Drawing.Size(153, 30);
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
            this.ListCaptutreModes.Location = new System.Drawing.Point(20, 63);
            this.ListCaptutreModes.Name = "ListCaptutreModes";
            this.ListCaptutreModes.Size = new System.Drawing.Size(107, 21);
            this.ListCaptutreModes.TabIndex = 5;
            this.ListCaptutreModes.SelectedIndexChanged += new System.EventHandler(this.ListCaptutreModes_SelectedIndexChanged);
            // 
            // ListCaptureDevices
            // 
            this.ListCaptureDevices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ListCaptureDevices.DisplayMember = "5";
            this.ListCaptureDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListCaptureDevices.FormattingEnabled = true;
            this.ListCaptureDevices.Location = new System.Drawing.Point(142, 63);
            this.ListCaptureDevices.Name = "ListCaptureDevices";
            this.ListCaptureDevices.Size = new System.Drawing.Size(102, 21);
            this.ListCaptureDevices.TabIndex = 6;
            this.ListCaptureDevices.SelectionChangeCommitted += new System.EventHandler(this.ListCaptureDevices_SelectionChangeCommitted);
            this.ListCaptureDevices.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListCaptureDevices_MouseDown);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(148, 165);
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
            this.ScreenView.Location = new System.Drawing.Point(0, 0);
            this.ScreenView.Name = "ScreenView";
            this.ScreenView.Size = new System.Drawing.Size(879, 856);
            this.ScreenView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ScreenView.TabIndex = 9;
            this.ScreenView.TabStop = false;
            // 
            // CamView
            // 
            this.CamView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CamView.BackColor = System.Drawing.Color.Black;
            this.CamView.Location = new System.Drawing.Point(856, 27);
            this.CamView.Name = "CamView";
            this.CamView.Size = new System.Drawing.Size(350, 226);
            this.CamView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CamView.TabIndex = 1;
            this.CamView.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.userCardText);
            this.panel1.Controls.Add(this.numberOprerationText);
            this.panel1.Controls.Add(this.rollerNumberText);
            this.panel1.Controls.Add(this.nomberOrderText);
            this.panel1.Controls.Add(this.btnOrderEdit);
            this.panel1.Controls.Add(this.photoGalleraya);
            this.panel1.Controls.Add(this.btnScreenCapture);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(856, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 623);
            this.panel1.TabIndex = 10;
            // 
            // userCardText
            // 
            this.userCardText.AutoSize = true;
            this.userCardText.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userCardText.Location = new System.Drawing.Point(4, 119);
            this.userCardText.Name = "userCardText";
            this.userCardText.Size = new System.Drawing.Size(152, 21);
            this.userCardText.TabIndex = 27;
            this.userCardText.Text = "ИСПОЛНИТЕЛЬ:";
            // 
            // numberOprerationText
            // 
            this.numberOprerationText.AutoSize = true;
            this.numberOprerationText.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberOprerationText.Location = new System.Drawing.Point(20, 93);
            this.numberOprerationText.Name = "numberOprerationText";
            this.numberOprerationText.Size = new System.Drawing.Size(136, 21);
            this.numberOprerationText.TabIndex = 26;
            this.numberOprerationText.Text = "№ ОПЕРАЦИИ:";
            // 
            // rollerNumberText
            // 
            this.rollerNumberText.AutoSize = true;
            this.rollerNumberText.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rollerNumberText.Location = new System.Drawing.Point(43, 67);
            this.rollerNumberText.Name = "rollerNumberText";
            this.rollerNumberText.Size = new System.Drawing.Size(113, 21);
            this.rollerNumberText.TabIndex = 25;
            this.rollerNumberText.Text = "№ РОЛИКА:";
            // 
            // nomberOrderText
            // 
            this.nomberOrderText.AutoSize = true;
            this.nomberOrderText.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nomberOrderText.Location = new System.Drawing.Point(42, 41);
            this.nomberOrderText.Name = "nomberOrderText";
            this.nomberOrderText.Size = new System.Drawing.Size(114, 21);
            this.nomberOrderText.TabIndex = 24;
            this.nomberOrderText.Text = "№ ЗАКАЗА :";
            // 
            // btnOrderEdit
            // 
            this.btnOrderEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrderEdit.Location = new System.Drawing.Point(234, 163);
            this.btnOrderEdit.Name = "btnOrderEdit";
            this.btnOrderEdit.Size = new System.Drawing.Size(102, 24);
            this.btnOrderEdit.TabIndex = 19;
            this.btnOrderEdit.Text = "Заказ/Правка";
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
            this.photoGalleraya.Location = new System.Drawing.Point(5, 193);
            this.photoGalleraya.MultiSelect = false;
            this.photoGalleraya.Name = "photoGalleraya";
            this.photoGalleraya.Size = new System.Drawing.Size(308, 424);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(28, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "ИСПОЛНИТЕЛЬ:";
            // 
            // numberRollerList
            // 
            this.numberRollerList.DataSource = this.rollerBindingSource;
            this.numberRollerList.DisplayMember = "roller";
            this.numberRollerList.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberRollerList.FormattingEnabled = true;
            this.numberRollerList.Location = new System.Drawing.Point(202, 73);
            this.numberRollerList.Name = "numberRollerList";
            this.numberRollerList.Size = new System.Drawing.Size(170, 27);
            this.numberRollerList.TabIndex = 16;
            // 
            // rollerBindingSource
            // 
            this.rollerBindingSource.DataMember = "roller";
            this.rollerBindingSource.DataSource = this.orderDataSet;
            // 
            // orderDataSet
            // 
            this.orderDataSet.DataSetName = "orderDataSet";
            this.orderDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(44, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "№ ОПЕРАЦИИ:";
            // 
            // rollerNumber
            // 
            this.rollerNumber.AutoSize = true;
            this.rollerNumber.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rollerNumber.Location = new System.Drawing.Point(67, 72);
            this.rollerNumber.Name = "rollerNumber";
            this.rollerNumber.Size = new System.Drawing.Size(113, 21);
            this.rollerNumber.TabIndex = 13;
            this.rollerNumber.Text = "№ РОЛИКА:";
            // 
            // orderText
            // 
            this.orderText.AutoSize = true;
            this.orderText.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderText.Location = new System.Drawing.Point(67, 20);
            this.orderText.Name = "orderText";
            this.orderText.Size = new System.Drawing.Size(114, 21);
            this.orderText.TabIndex = 11;
            this.orderText.Text = "№ ЗАКАЗА :";
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
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // новыйЗаказToolStripMenuItem
            // 
            this.новыйЗаказToolStripMenuItem.Name = "новыйЗаказToolStripMenuItem";
            this.новыйЗаказToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.новыйЗаказToolStripMenuItem.Text = "Новый заказ";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // настройкиToolStripMenuItem1
            // 
            this.настройкиToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.камераToolStripMenuItem,
            this.путьСохраненияФайловToolStripMenuItem});
            this.настройкиToolStripMenuItem1.Name = "настройкиToolStripMenuItem1";
            this.настройкиToolStripMenuItem1.Size = new System.Drawing.Size(82, 20);
            this.настройкиToolStripMenuItem1.Text = "Настройки";
            // 
            // камераToolStripMenuItem
            // 
            this.камераToolStripMenuItem.Name = "камераToolStripMenuItem";
            this.камераToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.камераToolStripMenuItem.Text = "Камера";
            this.камераToolStripMenuItem.Click += new System.EventHandler(this.КамераToolStripMenuItem_Click);
            // 
            // путьСохраненияФайловToolStripMenuItem
            // 
            this.путьСохраненияФайловToolStripMenuItem.Name = "путьСохраненияФайловToolStripMenuItem";
            this.путьСохраненияФайловToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.путьСохраненияФайловToolStripMenuItem.Text = "Путь сохранения файлов";
            this.путьСохраненияФайловToolStripMenuItem.Click += new System.EventHandler(this.ПутьСохраненияФайловToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabScreenView);
            this.tabControl1.Controls.Add(this.tabCardOrder);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(854, 882);
            this.tabControl1.TabIndex = 1;
            // 
            // tabScreenView
            // 
            this.tabScreenView.Controls.Add(this.ScreenView);
            this.tabScreenView.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabScreenView.Location = new System.Drawing.Point(4, 22);
            this.tabScreenView.Name = "tabScreenView";
            this.tabScreenView.Padding = new System.Windows.Forms.Padding(3);
            this.tabScreenView.Size = new System.Drawing.Size(846, 856);
            this.tabScreenView.TabIndex = 0;
            this.tabScreenView.Text = "Обзор";
            this.tabScreenView.UseVisualStyleBackColor = true;
            // 
            // tabCardOrder
            // 
            this.tabCardOrder.Controls.Add(this.panel2);
            this.tabCardOrder.Controls.Add(this.groupBox1);
            this.tabCardOrder.Location = new System.Drawing.Point(4, 22);
            this.tabCardOrder.Name = "tabCardOrder";
            this.tabCardOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabCardOrder.Size = new System.Drawing.Size(846, 856);
            this.tabCardOrder.TabIndex = 1;
            this.tabCardOrder.Text = "Заказ";
            this.tabCardOrder.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.nomberOrder);
            this.panel2.Controls.Add(this.numberOperationList);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btnCardOrderOk);
            this.panel2.Controls.Add(this.userCardList);
            this.panel2.Controls.Add(this.orderText);
            this.panel2.Controls.Add(this.numberRollerList);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.rollerNumber);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(240, 253);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(551, 382);
            this.panel2.TabIndex = 21;
            // 
            // nomberOrder
            // 
            this.nomberOrder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nomberOrder.Location = new System.Drawing.Point(202, 22);
            this.nomberOrder.Name = "nomberOrder";
            this.nomberOrder.Size = new System.Drawing.Size(170, 26);
            this.nomberOrder.TabIndex = 27;
            // 
            // numberOperationList
            // 
            this.numberOperationList.DataSource = this.operationBindingSource;
            this.numberOperationList.DisplayMember = "operation";
            this.numberOperationList.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberOperationList.FormattingEnabled = true;
            this.numberOperationList.Location = new System.Drawing.Point(202, 125);
            this.numberOperationList.Name = "numberOperationList";
            this.numberOperationList.Size = new System.Drawing.Size(322, 27);
            this.numberOperationList.TabIndex = 26;
            // 
            // operationBindingSource
            // 
            this.operationBindingSource.DataMember = "operation";
            this.operationBindingSource.DataSource = this.orderDataSet1;
            // 
            // orderDataSet1
            // 
            this.orderDataSet1.DataSetName = "orderDataSet1";
            this.orderDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(297, 255);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 25;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(170, 255);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "ОТМЕНА";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnCardOrderOk
            // 
            this.btnCardOrderOk.Location = new System.Drawing.Point(42, 255);
            this.btnCardOrderOk.Name = "btnCardOrderOk";
            this.btnCardOrderOk.Size = new System.Drawing.Size(75, 23);
            this.btnCardOrderOk.TabIndex = 23;
            this.btnCardOrderOk.Text = "ПРИМЕНИТЬ";
            this.btnCardOrderOk.UseVisualStyleBackColor = true;
            this.btnCardOrderOk.Click += new System.EventHandler(this.BtnCardOrderOk_Click);
            // 
            // userCardList
            // 
            this.userCardList.DataSource = this.userBindingSource;
            this.userCardList.DisplayMember = "user";
            this.userCardList.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userCardList.FormattingEnabled = true;
            this.userCardList.Location = new System.Drawing.Point(202, 176);
            this.userCardList.Name = "userCardList";
            this.userCardList.Size = new System.Drawing.Size(170, 27);
            this.userCardList.TabIndex = 22;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            this.userBindingSource.DataSource = this.orderDataSet2;
            // 
            // orderDataSet2
            // 
            this.orderDataSet2.DataSetName = "orderDataSet2";
            this.orderDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ListCaptureDevices);
            this.groupBox1.Controls.Add(this.ListCaptutreModes);
            this.groupBox1.Location = new System.Drawing.Point(547, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 145);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки камеры";
            // 
            // rollerTableAdapter
            // 
            this.rollerTableAdapter.ClearBeforeFill = true;
            // 
            // operationTableAdapter
            // 
            this.operationTableAdapter.ClearBeforeFill = true;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 881);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CamView);
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
            ((System.ComponentModel.ISupportInitialize)(this.rollerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabScreenView.ResumeLayout(false);
            this.tabCardOrder.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.operationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataSet2)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.Label rollerNumber;
        private System.Windows.Forms.Label orderText;
        private System.Windows.Forms.ComboBox numberRollerList;
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabScreenView;
        private System.Windows.Forms.TabPage tabCardOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnCardOrderOk;
        private System.Windows.Forms.ComboBox userCardList;
        private System.Windows.Forms.ComboBox numberOperationList;
        private orderDataSet orderDataSet;
        private System.Windows.Forms.BindingSource rollerBindingSource;
        private orderDataSetTableAdapters.rollerTableAdapter rollerTableAdapter;
        private orderDataSet1 orderDataSet1;
        private System.Windows.Forms.BindingSource operationBindingSource;
        private orderDataSet1TableAdapters.operationTableAdapter operationTableAdapter;
        private orderDataSet2 orderDataSet2;
        private System.Windows.Forms.BindingSource userBindingSource;
        private orderDataSet2TableAdapters.userTableAdapter userTableAdapter;
        private System.Windows.Forms.Label userCardText;
        private System.Windows.Forms.Label numberOprerationText;
        private System.Windows.Forms.Label rollerNumberText;
        private System.Windows.Forms.Label nomberOrderText;
        private System.Windows.Forms.TextBox nomberOrder;
    }
}

