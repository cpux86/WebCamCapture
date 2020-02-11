namespace WebCamCapture.View
{
    partial class SettingForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deviceList = new System.Windows.Forms.ComboBox();
            this.modesList = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SettinAppPanel__FileDirView = new System.Windows.Forms.TextBox();
            this.SettingAppPanel__DirOkBtn = new System.Windows.Forms.Button();
            this.btnOkSettingDev = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.trackExposure = new System.Windows.Forms.TrackBar();
            this.numExposure = new System.Windows.Forms.NumericUpDown();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.trackFocus = new System.Windows.Forms.TrackBar();
            this.numFocus = new System.Windows.Forms.NumericUpDown();
            this.chFocusAuto = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.trackZoom = new System.Windows.Forms.TrackBar();
            this.numZoom = new System.Windows.Forms.NumericUpDown();
            this.chScaleAuto = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackExposure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExposure)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackFocus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFocus)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numZoom)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(355, 352);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnOkSettingDev);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(347, 324);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Источник";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.deviceList);
            this.groupBox2.Controls.Add(this.modesList);
            this.groupBox2.Location = new System.Drawing.Point(15, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 75);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Опции";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(168, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Разрешение";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Источник";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deviceList
            // 
            this.deviceList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.deviceList.DisplayMember = "5";
            this.deviceList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deviceList.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deviceList.FormattingEnabled = true;
            this.deviceList.Location = new System.Drawing.Point(6, 35);
            this.deviceList.Name = "deviceList";
            this.deviceList.Size = new System.Drawing.Size(155, 23);
            this.deviceList.TabIndex = 15;
            this.deviceList.SelectionChangeCommitted += new System.EventHandler(this.deviceList_SelectionChangeCommitted);
            // 
            // modesList
            // 
            this.modesList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.modesList.BackColor = System.Drawing.SystemColors.Window;
            this.modesList.DisplayMember = "5";
            this.modesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modesList.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modesList.FormattingEnabled = true;
            this.modesList.Location = new System.Drawing.Point(168, 35);
            this.modesList.Name = "modesList";
            this.modesList.Size = new System.Drawing.Size(130, 23);
            this.modesList.TabIndex = 14;
            this.modesList.SelectedIndexChanged += new System.EventHandler(this.modesList_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SettinAppPanel__FileDirView);
            this.groupBox1.Controls.Add(this.SettingAppPanel__DirOkBtn);
            this.groupBox1.Location = new System.Drawing.Point(15, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 57);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Каталог для файлов";
            // 
            // SettinAppPanel__FileDirView
            // 
            this.SettinAppPanel__FileDirView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SettinAppPanel__FileDirView.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettinAppPanel__FileDirView.Location = new System.Drawing.Point(6, 21);
            this.SettinAppPanel__FileDirView.Name = "SettinAppPanel__FileDirView";
            this.SettinAppPanel__FileDirView.ReadOnly = true;
            this.SettinAppPanel__FileDirView.Size = new System.Drawing.Size(245, 23);
            this.SettinAppPanel__FileDirView.TabIndex = 14;
            // 
            // SettingAppPanel__DirOkBtn
            // 
            this.SettingAppPanel__DirOkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SettingAppPanel__DirOkBtn.BackColor = System.Drawing.Color.Transparent;
            this.SettingAppPanel__DirOkBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SettingAppPanel__DirOkBtn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingAppPanel__DirOkBtn.ForeColor = System.Drawing.Color.Black;
            this.SettingAppPanel__DirOkBtn.Location = new System.Drawing.Point(262, 21);
            this.SettingAppPanel__DirOkBtn.Name = "SettingAppPanel__DirOkBtn";
            this.SettingAppPanel__DirOkBtn.Size = new System.Drawing.Size(36, 23);
            this.SettingAppPanel__DirOkBtn.TabIndex = 15;
            this.SettingAppPanel__DirOkBtn.Text = "...";
            this.SettingAppPanel__DirOkBtn.UseVisualStyleBackColor = false;
            this.SettingAppPanel__DirOkBtn.Click += new System.EventHandler(this.SettingAppPanel__DirOkBtn_Click);
            // 
            // btnOkSettingDev
            // 
            this.btnOkSettingDev.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOkSettingDev.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOkSettingDev.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOkSettingDev.Location = new System.Drawing.Point(15, 206);
            this.btnOkSettingDev.Name = "btnOkSettingDev";
            this.btnOkSettingDev.Size = new System.Drawing.Size(75, 33);
            this.btnOkSettingDev.TabIndex = 16;
            this.btnOkSettingDev.Text = "OK";
            this.btnOkSettingDev.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(347, 324);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Управление";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.trackBar2);
            this.groupBox7.Controls.Add(this.numericUpDown3);
            this.groupBox7.Controls.Add(this.checkBox3);
            this.groupBox7.Location = new System.Drawing.Point(27, 254);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(294, 56);
            this.groupBox7.TabIndex = 14;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Наклон";
            // 
            // trackBar2
            // 
            this.trackBar2.AutoSize = false;
            this.trackBar2.BackColor = System.Drawing.Color.White;
            this.trackBar2.Enabled = false;
            this.trackBar2.Location = new System.Drawing.Point(6, 17);
            this.trackBar2.Maximum = 500;
            this.trackBar2.Minimum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(212, 33);
            this.trackBar2.TabIndex = 3;
            this.trackBar2.TickFrequency = 50;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar2.Value = 100;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Enabled = false;
            this.numericUpDown3.Location = new System.Drawing.Point(224, 21);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(43, 22);
            this.numericUpDown3.TabIndex = 4;
            this.numericUpDown3.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(273, 24);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.trackBar1);
            this.groupBox6.Controls.Add(this.numericUpDown1);
            this.groupBox6.Controls.Add(this.checkBox1);
            this.groupBox6.Location = new System.Drawing.Point(27, 192);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(294, 56);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Сдвиг";
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.BackColor = System.Drawing.Color.White;
            this.trackBar1.Enabled = false;
            this.trackBar1.Location = new System.Drawing.Point(6, 17);
            this.trackBar1.Maximum = 500;
            this.trackBar1.Minimum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(212, 33);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.TickFrequency = 50;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar1.Value = 100;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(224, 21);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(43, 22);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(273, 24);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.trackExposure);
            this.groupBox5.Controls.Add(this.numExposure);
            this.groupBox5.Controls.Add(this.checkBox2);
            this.groupBox5.Location = new System.Drawing.Point(27, 130);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(294, 56);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Выдержка";
            // 
            // trackExposure
            // 
            this.trackExposure.AutoSize = false;
            this.trackExposure.BackColor = System.Drawing.Color.White;
            this.trackExposure.Location = new System.Drawing.Point(6, 17);
            this.trackExposure.Maximum = 500;
            this.trackExposure.Minimum = 100;
            this.trackExposure.Name = "trackExposure";
            this.trackExposure.Size = new System.Drawing.Size(212, 33);
            this.trackExposure.TabIndex = 3;
            this.trackExposure.TickFrequency = 50;
            this.trackExposure.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackExposure.Value = 100;
            this.trackExposure.Scroll += new System.EventHandler(this.TrackExposure_Scroll);
            // 
            // numExposure
            // 
            this.numExposure.Enabled = false;
            this.numExposure.Location = new System.Drawing.Point(224, 21);
            this.numExposure.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numExposure.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numExposure.Name = "numExposure";
            this.numExposure.Size = new System.Drawing.Size(43, 22);
            this.numExposure.TabIndex = 4;
            this.numExposure.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(273, 24);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.trackFocus);
            this.groupBox4.Controls.Add(this.numFocus);
            this.groupBox4.Controls.Add(this.chFocusAuto);
            this.groupBox4.Location = new System.Drawing.Point(27, 68);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(294, 56);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Фокус";
            // 
            // trackFocus
            // 
            this.trackFocus.AutoSize = false;
            this.trackFocus.BackColor = System.Drawing.Color.White;
            this.trackFocus.Enabled = false;
            this.trackFocus.Location = new System.Drawing.Point(6, 17);
            this.trackFocus.Maximum = 255;
            this.trackFocus.Name = "trackFocus";
            this.trackFocus.Size = new System.Drawing.Size(212, 33);
            this.trackFocus.TabIndex = 3;
            this.trackFocus.TickFrequency = 50;
            this.trackFocus.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackFocus.Scroll += new System.EventHandler(this.trackFocus_Scroll);
            // 
            // numFocus
            // 
            this.numFocus.Enabled = false;
            this.numFocus.Location = new System.Drawing.Point(224, 21);
            this.numFocus.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numFocus.Name = "numFocus";
            this.numFocus.Size = new System.Drawing.Size(43, 22);
            this.numFocus.TabIndex = 4;
            this.numFocus.ValueChanged += new System.EventHandler(this.NumFocus_ValueChanged);
            // 
            // chFocusAuto
            // 
            this.chFocusAuto.AutoSize = true;
            this.chFocusAuto.Checked = true;
            this.chFocusAuto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chFocusAuto.Location = new System.Drawing.Point(273, 24);
            this.chFocusAuto.Name = "chFocusAuto";
            this.chFocusAuto.Size = new System.Drawing.Size(15, 14);
            this.chFocusAuto.TabIndex = 5;
            this.chFocusAuto.UseVisualStyleBackColor = true;
            this.chFocusAuto.CheckedChanged += new System.EventHandler(this.ChFocusAuto_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.trackZoom);
            this.groupBox3.Controls.Add(this.numZoom);
            this.groupBox3.Controls.Add(this.chScaleAuto);
            this.groupBox3.Location = new System.Drawing.Point(27, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(294, 56);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Масштаб";
            // 
            // trackZoom
            // 
            this.trackZoom.AutoSize = false;
            this.trackZoom.BackColor = System.Drawing.Color.White;
            this.trackZoom.Enabled = false;
            this.trackZoom.Location = new System.Drawing.Point(6, 17);
            this.trackZoom.Maximum = 500;
            this.trackZoom.Minimum = 100;
            this.trackZoom.Name = "trackZoom";
            this.trackZoom.Size = new System.Drawing.Size(212, 33);
            this.trackZoom.TabIndex = 3;
            this.trackZoom.TickFrequency = 50;
            this.trackZoom.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackZoom.Value = 100;
            this.trackZoom.Scroll += new System.EventHandler(this.TrackZoom_Scroll);
            // 
            // numZoom
            // 
            this.numZoom.Enabled = false;
            this.numZoom.Location = new System.Drawing.Point(224, 21);
            this.numZoom.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numZoom.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numZoom.Name = "numZoom";
            this.numZoom.Size = new System.Drawing.Size(43, 22);
            this.numZoom.TabIndex = 4;
            this.numZoom.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numZoom.ValueChanged += new System.EventHandler(this.NumScale_ValueChanged);
            // 
            // chScaleAuto
            // 
            this.chScaleAuto.AutoSize = true;
            this.chScaleAuto.Checked = true;
            this.chScaleAuto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chScaleAuto.Location = new System.Drawing.Point(273, 24);
            this.chScaleAuto.Name = "chScaleAuto";
            this.chScaleAuto.Size = new System.Drawing.Size(15, 14);
            this.chScaleAuto.TabIndex = 5;
            this.chScaleAuto.UseVisualStyleBackColor = true;
            this.chScaleAuto.CheckedChanged += new System.EventHandler(this.ChScaleAuto_CheckedChanged);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 353);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки камеры";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackExposure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExposure)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackFocus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFocus)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numZoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SettinAppPanel__FileDirView;
        private System.Windows.Forms.Button SettingAppPanel__DirOkBtn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        public System.Windows.Forms.Button btnOkSettingDev;
        public System.Windows.Forms.ComboBox deviceList;
        public System.Windows.Forms.ComboBox modesList;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TrackBar trackExposure;
        private System.Windows.Forms.NumericUpDown numExposure;
        protected System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TrackBar trackFocus;
        private System.Windows.Forms.NumericUpDown numFocus;
        protected System.Windows.Forms.CheckBox chFocusAuto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TrackBar trackZoom;
        private System.Windows.Forms.NumericUpDown numZoom;
        protected System.Windows.Forms.CheckBox chScaleAuto;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        protected System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        protected System.Windows.Forms.CheckBox checkBox1;
    }
}