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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deviceList = new System.Windows.Forms.ComboBox();
            this.modesList = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SettinAppPanel__FileDirView = new System.Windows.Forms.TextBox();
            this.SettingAppPanel__DirOkBtn = new System.Windows.Forms.Button();
            this.btnOkSettingDev = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.deviceList);
            this.groupBox2.Controls.Add(this.modesList);
            this.groupBox2.Location = new System.Drawing.Point(18, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 75);
            this.groupBox2.TabIndex = 21;
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
            this.deviceList.BackColor = System.Drawing.Color.White;
            this.deviceList.DisplayMember = "5";
            this.deviceList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deviceList.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deviceList.FormattingEnabled = true;
            this.deviceList.Location = new System.Drawing.Point(6, 35);
            this.deviceList.Name = "deviceList";
            this.deviceList.Size = new System.Drawing.Size(155, 23);
            this.deviceList.TabIndex = 15;
            this.deviceList.SelectedIndexChanged += new System.EventHandler(this.deviceList_SelectionChangeCommitted);
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
            this.modesList.Size = new System.Drawing.Size(174, 23);
            this.modesList.TabIndex = 14;
            this.modesList.SelectedIndexChanged += new System.EventHandler(this.modesList_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SettinAppPanel__FileDirView);
            this.groupBox1.Controls.Add(this.SettingAppPanel__DirOkBtn);
            this.groupBox1.Location = new System.Drawing.Point(18, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 57);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Каталог для файлов";
            // 
            // SettinAppPanel__FileDirView
            // 
            this.SettinAppPanel__FileDirView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SettinAppPanel__FileDirView.BackColor = System.Drawing.Color.White;
            this.SettinAppPanel__FileDirView.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettinAppPanel__FileDirView.Location = new System.Drawing.Point(6, 21);
            this.SettinAppPanel__FileDirView.Name = "SettinAppPanel__FileDirView";
            this.SettinAppPanel__FileDirView.ReadOnly = true;
            this.SettinAppPanel__FileDirView.Size = new System.Drawing.Size(289, 23);
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
            this.SettingAppPanel__DirOkBtn.Location = new System.Drawing.Point(306, 21);
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
            this.btnOkSettingDev.Location = new System.Drawing.Point(18, 193);
            this.btnOkSettingDev.Name = "btnOkSettingDev";
            this.btnOkSettingDev.Size = new System.Drawing.Size(75, 27);
            this.btnOkSettingDev.TabIndex = 19;
            this.btnOkSettingDev.Text = "OK";
            this.btnOkSettingDev.UseVisualStyleBackColor = true;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 242);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOkSettingDev);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки камеры";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox deviceList;
        public System.Windows.Forms.ComboBox modesList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SettinAppPanel__FileDirView;
        private System.Windows.Forms.Button SettingAppPanel__DirOkBtn;
        public System.Windows.Forms.Button btnOkSettingDev;
    }
}