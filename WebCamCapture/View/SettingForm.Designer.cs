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
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.chScaleAuto = new System.Windows.Forms.CheckBox();
            this.numScale = new System.Windows.Forms.NumericUpDown();
            this.trackScale = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackScale)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(345, 224);
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
            this.tabPage1.Size = new System.Drawing.Size(337, 196);
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
            this.groupBox2.Location = new System.Drawing.Point(7, 69);
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
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
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
            this.btnOkSettingDev.Location = new System.Drawing.Point(13, 150);
            this.btnOkSettingDev.Name = "btnOkSettingDev";
            this.btnOkSettingDev.Size = new System.Drawing.Size(75, 30);
            this.btnOkSettingDev.TabIndex = 16;
            this.btnOkSettingDev.Text = "OK";
            this.btnOkSettingDev.UseVisualStyleBackColor = true;
            this.btnOkSettingDev.Click += new System.EventHandler(this.BtnOkSettingDev_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.trackBar2);
            this.tabPage2.Controls.Add(this.chScaleAuto);
            this.tabPage2.Controls.Add(this.numScale);
            this.tabPage2.Controls.Add(this.trackScale);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(337, 196);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Управление";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(81, 101);
            this.trackBar2.Maximum = 500;
            this.trackBar2.Minimum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(121, 45);
            this.trackBar2.TabIndex = 6;
            this.trackBar2.TickFrequency = 50;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar2.Value = 100;
            // 
            // chScaleAuto
            // 
            this.chScaleAuto.AutoSize = true;
            this.chScaleAuto.Checked = true;
            this.chScaleAuto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chScaleAuto.Location = new System.Drawing.Point(277, 31);
            this.chScaleAuto.Name = "chScaleAuto";
            this.chScaleAuto.Size = new System.Drawing.Size(15, 14);
            this.chScaleAuto.TabIndex = 5;
            this.chScaleAuto.UseVisualStyleBackColor = true;
            this.chScaleAuto.CheckedChanged += new System.EventHandler(this.ChScaleAuto_CheckedChanged);
            // 
            // numScale
            // 
            this.numScale.Enabled = false;
            this.numScale.Location = new System.Drawing.Point(219, 28);
            this.numScale.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numScale.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numScale.Name = "numScale";
            this.numScale.Size = new System.Drawing.Size(43, 22);
            this.numScale.TabIndex = 4;
            this.numScale.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numScale.ValueChanged += new System.EventHandler(this.NumScale_ValueChanged);
            // 
            // trackScale
            // 
            this.trackScale.Enabled = false;
            this.trackScale.Location = new System.Drawing.Point(81, 28);
            this.trackScale.Maximum = 500;
            this.trackScale.Minimum = 100;
            this.trackScale.Name = "trackScale";
            this.trackScale.Size = new System.Drawing.Size(121, 45);
            this.trackScale.TabIndex = 3;
            this.trackScale.TickFrequency = 50;
            this.trackScale.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackScale.Value = 100;
            this.trackScale.Scroll += new System.EventHandler(this.TrackScale_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Выдержка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Фокус";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Маштаб";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 225);
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
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackScale)).EndInit();
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
        private System.Windows.Forms.TrackBar trackScale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numScale;
        protected System.Windows.Forms.CheckBox chScaleAuto;
        private System.Windows.Forms.TrackBar trackBar2;
    }
}