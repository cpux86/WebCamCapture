namespace WebCamCapture.View
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
            this.makeSnapshotBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.snapshotTable = new System.Windows.Forms.ListView();
            this.orderColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rollerColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.processColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderEditBtn = new System.Windows.Forms.Button();
            this.OrderPanel__TitleUser = new System.Windows.Forms.Label();
            this.OrderPanel__TitleOpreration = new System.Windows.Forms.Label();
            this.OrderPanel__TitleRoller = new System.Windows.Forms.Label();
            this.OrderPanel__TitleOrder = new System.Windows.Forms.Label();
            this.OrderViewPanel = new System.Windows.Forms.Panel();
            this.userLbl = new System.Windows.Forms.Label();
            this.processLbl = new System.Windows.Forms.Label();
            this.rollerLbl = new System.Windows.Forms.Label();
            this.orderLbl = new System.Windows.Forms.Label();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйЗаказToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showAppSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.deviceManagerItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.videoPlayer = new Accord.Controls.VideoSourcePlayer();
            this.snapshotView = new Accord.Controls.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.OrderViewPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.snapshotView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // makeSnapshotBtn
            // 
            this.makeSnapshotBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.makeSnapshotBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.makeSnapshotBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.makeSnapshotBtn.ForeColor = System.Drawing.Color.Black;
            this.makeSnapshotBtn.Location = new System.Drawing.Point(0, 0);
            this.makeSnapshotBtn.Name = "makeSnapshotBtn";
            this.makeSnapshotBtn.Size = new System.Drawing.Size(325, 30);
            this.makeSnapshotBtn.TabIndex = 3;
            this.makeSnapshotBtn.Text = "Снимок";
            this.makeSnapshotBtn.UseVisualStyleBackColor = true;
            this.makeSnapshotBtn.Click += new System.EventHandler(this.makeSnapshotBtn_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::WebCamCapture.Properties.Resources.Фон1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.button1.Location = new System.Drawing.Point(625, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 44);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.snapshotTable);
            this.panel1.Controls.Add(this.orderEditBtn);
            this.panel1.Controls.Add(this.makeSnapshotBtn);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 347);
            this.panel1.TabIndex = 10;
            // 
            // snapshotTable
            // 
            this.snapshotTable.AllowColumnReorder = true;
            this.snapshotTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.orderColumnHeader,
            this.dateColumnHeader,
            this.rollerColumnHeader,
            this.processColumnHeader,
            this.userColumnHeader});
            this.snapshotTable.Cursor = System.Windows.Forms.Cursors.Default;
            this.snapshotTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.snapshotTable.FullRowSelect = true;
            this.snapshotTable.GridLines = true;
            this.snapshotTable.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.snapshotTable.HideSelection = false;
            this.snapshotTable.Location = new System.Drawing.Point(0, 60);
            this.snapshotTable.Name = "snapshotTable";
            this.snapshotTable.Size = new System.Drawing.Size(325, 287);
            this.snapshotTable.TabIndex = 20;
            this.snapshotTable.UseCompatibleStateImageBehavior = false;
            this.snapshotTable.View = System.Windows.Forms.View.Details;
            // 
            // orderColumnHeader
            // 
            this.orderColumnHeader.Text = "Заказ";
            this.orderColumnHeader.Width = 0;
            // 
            // dateColumnHeader
            // 
            this.dateColumnHeader.Text = "Дата";
            this.dateColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dateColumnHeader.Width = 86;
            // 
            // rollerColumnHeader
            // 
            this.rollerColumnHeader.Text = "Ролик";
            this.rollerColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rollerColumnHeader.Width = 75;
            // 
            // processColumnHeader
            // 
            this.processColumnHeader.Text = "Процесс";
            this.processColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.processColumnHeader.Width = 89;
            // 
            // userColumnHeader
            // 
            this.userColumnHeader.Text = "Исполнитель";
            // 
            // orderEditBtn
            // 
            this.orderEditBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.orderEditBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderEditBtn.ForeColor = System.Drawing.Color.Black;
            this.orderEditBtn.Location = new System.Drawing.Point(0, 30);
            this.orderEditBtn.Name = "orderEditBtn";
            this.orderEditBtn.Size = new System.Drawing.Size(325, 30);
            this.orderEditBtn.TabIndex = 19;
            this.orderEditBtn.Text = "Заказ / Правка";
            this.orderEditBtn.UseVisualStyleBackColor = true;
            this.orderEditBtn.Click += new System.EventHandler(this.OrderEditBtn_Click);
            // 
            // OrderPanel__TitleUser
            // 
            this.OrderPanel__TitleUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OrderPanel__TitleUser.AutoSize = true;
            this.OrderPanel__TitleUser.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderPanel__TitleUser.Location = new System.Drawing.Point(3, 121);
            this.OrderPanel__TitleUser.Name = "OrderPanel__TitleUser";
            this.OrderPanel__TitleUser.Size = new System.Drawing.Size(119, 21);
            this.OrderPanel__TitleUser.TabIndex = 27;
            this.OrderPanel__TitleUser.Text = "Исполнитель:";
            // 
            // OrderPanel__TitleOpreration
            // 
            this.OrderPanel__TitleOpreration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OrderPanel__TitleOpreration.AutoSize = true;
            this.OrderPanel__TitleOpreration.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderPanel__TitleOpreration.Location = new System.Drawing.Point(39, 88);
            this.OrderPanel__TitleOpreration.Name = "OrderPanel__TitleOpreration";
            this.OrderPanel__TitleOpreration.Size = new System.Drawing.Size(83, 21);
            this.OrderPanel__TitleOpreration.TabIndex = 26;
            this.OrderPanel__TitleOpreration.Text = "Процесс:";
            // 
            // OrderPanel__TitleRoller
            // 
            this.OrderPanel__TitleRoller.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OrderPanel__TitleRoller.AutoSize = true;
            this.OrderPanel__TitleRoller.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderPanel__TitleRoller.Location = new System.Drawing.Point(59, 55);
            this.OrderPanel__TitleRoller.Name = "OrderPanel__TitleRoller";
            this.OrderPanel__TitleRoller.Size = new System.Drawing.Size(63, 21);
            this.OrderPanel__TitleRoller.TabIndex = 25;
            this.OrderPanel__TitleRoller.Text = "Ролик:";
            // 
            // OrderPanel__TitleOrder
            // 
            this.OrderPanel__TitleOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OrderPanel__TitleOrder.AutoSize = true;
            this.OrderPanel__TitleOrder.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderPanel__TitleOrder.Location = new System.Drawing.Point(65, 22);
            this.OrderPanel__TitleOrder.Name = "OrderPanel__TitleOrder";
            this.OrderPanel__TitleOrder.Size = new System.Drawing.Size(57, 21);
            this.OrderPanel__TitleOrder.TabIndex = 24;
            this.OrderPanel__TitleOrder.Text = "Заказ:";
            // 
            // OrderViewPanel
            // 
            this.OrderViewPanel.BackColor = System.Drawing.SystemColors.Control;
            this.OrderViewPanel.Controls.Add(this.groupBox1);
            this.OrderViewPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OrderViewPanel.Location = new System.Drawing.Point(0, 534);
            this.OrderViewPanel.Name = "OrderViewPanel";
            this.OrderViewPanel.Size = new System.Drawing.Size(671, 172);
            this.OrderViewPanel.TabIndex = 28;
            // 
            // userLbl
            // 
            this.userLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.userLbl.AutoSize = true;
            this.userLbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userLbl.Location = new System.Drawing.Point(125, 121);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(0, 21);
            this.userLbl.TabIndex = 31;
            // 
            // processLbl
            // 
            this.processLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.processLbl.AutoSize = true;
            this.processLbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.processLbl.Location = new System.Drawing.Point(125, 88);
            this.processLbl.Name = "processLbl";
            this.processLbl.Size = new System.Drawing.Size(0, 21);
            this.processLbl.TabIndex = 30;
            // 
            // rollerLbl
            // 
            this.rollerLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rollerLbl.AutoSize = true;
            this.rollerLbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rollerLbl.Location = new System.Drawing.Point(125, 55);
            this.rollerLbl.Name = "rollerLbl";
            this.rollerLbl.Size = new System.Drawing.Size(0, 21);
            this.rollerLbl.TabIndex = 29;
            // 
            // orderLbl
            // 
            this.orderLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.orderLbl.AutoSize = true;
            this.orderLbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderLbl.Location = new System.Drawing.Point(125, 22);
            this.orderLbl.Name = "orderLbl";
            this.orderLbl.Size = new System.Drawing.Size(0, 21);
            this.orderLbl.TabIndex = 28;
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
            this.новыйЗаказToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.новыйЗаказToolStripMenuItem.Text = "Новый заказ";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // настройкиToolStripMenuItem1
            // 
            this.настройкиToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAppSetting,
            this.deviceManagerItem});
            this.настройкиToolStripMenuItem1.Name = "настройкиToolStripMenuItem1";
            this.настройкиToolStripMenuItem1.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem1.Text = "Настройки";
            // 
            // showAppSetting
            // 
            this.showAppSetting.Name = "showAppSetting";
            this.showAppSetting.Size = new System.Drawing.Size(141, 22);
            this.showAppSetting.Text = "Общие";
            this.showAppSetting.Click += new System.EventHandler(this.ShowAppSetting_Click);
            // 
            // deviceManagerItem
            // 
            this.deviceManagerItem.Enabled = false;
            this.deviceManagerItem.Name = "deviceManagerItem";
            this.deviceManagerItem.Size = new System.Drawing.Size(141, 22);
            this.deviceManagerItem.Text = "Управление";
            this.deviceManagerItem.Click += new System.EventHandler(this.ShowDeviceManagerPanel_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.настройкиToolStripMenuItem1,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // videoPlayer
            // 
            this.videoPlayer.BackColor = System.Drawing.Color.Black;
            this.videoPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoPlayer.KeepAspectRatio = true;
            this.videoPlayer.Location = new System.Drawing.Point(0, 0);
            this.videoPlayer.Name = "videoPlayer";
            this.videoPlayer.Size = new System.Drawing.Size(325, 351);
            this.videoPlayer.TabIndex = 29;
            this.videoPlayer.Text = "videoSourcePlayer1";
            this.videoPlayer.VideoSource = null;
            // 
            // snapshotView
            // 
            this.snapshotView.BackColor = System.Drawing.Color.Black;
            this.snapshotView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.snapshotView.Image = null;
            this.snapshotView.Location = new System.Drawing.Point(0, 0);
            this.snapshotView.Name = "snapshotView";
            this.snapshotView.Size = new System.Drawing.Size(671, 534);
            this.snapshotView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.snapshotView.TabIndex = 30;
            this.snapshotView.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.snapshotView);
            this.splitContainer1.Panel1.Controls.Add(this.OrderViewPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1008, 710);
            this.splitContainer1.SplitterDistance = 675;
            this.splitContainer1.TabIndex = 31;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.videoPlayer);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panel1);
            this.splitContainer2.Size = new System.Drawing.Size(329, 710);
            this.splitContainer2.SplitterDistance = 355;
            this.splitContainer2.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.OrderPanel__TitleOpreration);
            this.groupBox1.Controls.Add(this.userLbl);
            this.groupBox1.Controls.Add(this.OrderPanel__TitleOrder);
            this.groupBox1.Controls.Add(this.processLbl);
            this.groupBox1.Controls.Add(this.OrderPanel__TitleRoller);
            this.groupBox1.Controls.Add(this.rollerLbl);
            this.groupBox1.Controls.Add(this.OrderPanel__TitleUser);
            this.groupBox1.Controls.Add(this.orderLbl);
            this.groupBox1.Location = new System.Drawing.Point(10, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(658, 156);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 734);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WebCamCapture";
            this.panel1.ResumeLayout(false);
            this.OrderViewPanel.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.snapshotView)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button makeSnapshotBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button orderEditBtn;
        private System.Windows.Forms.Label OrderPanel__TitleUser;
        private System.Windows.Forms.Label OrderPanel__TitleOpreration;
        private System.Windows.Forms.Label OrderPanel__TitleRoller;
        private System.Windows.Forms.Label OrderPanel__TitleOrder;
        private System.Windows.Forms.Panel OrderViewPanel;
        private System.Windows.Forms.Label orderLbl;
        private System.Windows.Forms.Label userLbl;
        private System.Windows.Forms.Label processLbl;
        private System.Windows.Forms.Label rollerLbl;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйЗаказToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showAppSetting;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private Accord.Controls.VideoSourcePlayer videoPlayer;
        private Accord.Controls.PictureBox snapshotView;
        private System.Windows.Forms.ToolStripMenuItem deviceManagerItem;
        private System.Windows.Forms.ListView snapshotTable;
        private System.Windows.Forms.ColumnHeader orderColumnHeader;
        private System.Windows.Forms.ColumnHeader dateColumnHeader;
        private System.Windows.Forms.ColumnHeader rollerColumnHeader;
        private System.Windows.Forms.ColumnHeader processColumnHeader;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ColumnHeader userColumnHeader;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

