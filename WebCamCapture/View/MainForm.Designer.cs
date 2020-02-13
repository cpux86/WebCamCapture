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
            this.orderEditBtn = new System.Windows.Forms.Button();
            this.photoGalleraya = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderPanel__TitleUser = new System.Windows.Forms.Label();
            this.OrderPanel__TitleOpreration = new System.Windows.Forms.Label();
            this.OrderPanel__TitleRoller = new System.Windows.Forms.Label();
            this.OrderPanel__TitleOrder = new System.Windows.Forms.Label();
            this.OrderViewPanel = new System.Windows.Forms.Panel();
            this.OrderPanel__OperatorFullName = new System.Windows.Forms.Label();
            this.OrderPanel__TextOpreration = new System.Windows.Forms.Label();
            this.OrderPanel__TextRoller = new System.Windows.Forms.Label();
            this.OrderPanel__TextOrder = new System.Windows.Forms.Label();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйЗаказToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showSettingBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.videoPlayer = new AForge.Controls.VideoSourcePlayer();
            this.pictureBox1 = new AForge.Controls.PictureBox();
            this.panel1.SuspendLayout();
            this.OrderViewPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // makeSnapshotBtn
            // 
            this.makeSnapshotBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.makeSnapshotBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.makeSnapshotBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.makeSnapshotBtn.ForeColor = System.Drawing.Color.Black;
            this.makeSnapshotBtn.Location = new System.Drawing.Point(7, 17);
            this.makeSnapshotBtn.Name = "makeSnapshotBtn";
            this.makeSnapshotBtn.Size = new System.Drawing.Size(141, 30);
            this.makeSnapshotBtn.TabIndex = 3;
            this.makeSnapshotBtn.Text = "Снимок";
            this.makeSnapshotBtn.UseVisualStyleBackColor = true;
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
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.orderEditBtn);
            this.panel1.Controls.Add(this.photoGalleraya);
            this.panel1.Controls.Add(this.makeSnapshotBtn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(590, 263);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 365);
            this.panel1.TabIndex = 10;
            // 
            // orderEditBtn
            // 
            this.orderEditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.orderEditBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderEditBtn.ForeColor = System.Drawing.Color.Black;
            this.orderEditBtn.Location = new System.Drawing.Point(203, 17);
            this.orderEditBtn.Name = "orderEditBtn";
            this.orderEditBtn.Size = new System.Drawing.Size(141, 30);
            this.orderEditBtn.TabIndex = 19;
            this.orderEditBtn.Text = "Заказ / Правка";
            this.orderEditBtn.UseVisualStyleBackColor = true;
            // 
            // photoGalleraya
            // 
            this.photoGalleraya.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.photoGalleraya.BackColor = System.Drawing.SystemColors.Window;
            this.photoGalleraya.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.photoGalleraya.FullRowSelect = true;
            this.photoGalleraya.HideSelection = false;
            this.photoGalleraya.Location = new System.Drawing.Point(6, 65);
            this.photoGalleraya.MultiSelect = false;
            this.photoGalleraya.Name = "photoGalleraya";
            this.photoGalleraya.Size = new System.Drawing.Size(350, 297);
            this.photoGalleraya.TabIndex = 9;
            this.photoGalleraya.UseCompatibleStateImageBehavior = false;
            this.photoGalleraya.View = System.Windows.Forms.View.Details;
            this.photoGalleraya.VirtualListSize = 25;
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
            // OrderPanel__TitleUser
            // 
            this.OrderPanel__TitleUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OrderPanel__TitleUser.AutoSize = true;
            this.OrderPanel__TitleUser.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderPanel__TitleUser.Location = new System.Drawing.Point(13, 111);
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
            this.OrderPanel__TitleOpreration.Location = new System.Drawing.Point(39, 78);
            this.OrderPanel__TitleOpreration.Name = "OrderPanel__TitleOpreration";
            this.OrderPanel__TitleOpreration.Size = new System.Drawing.Size(93, 21);
            this.OrderPanel__TitleOpreration.TabIndex = 26;
            this.OrderPanel__TitleOpreration.Text = "Операция:";
            // 
            // OrderPanel__TitleRoller
            // 
            this.OrderPanel__TitleRoller.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OrderPanel__TitleRoller.AutoSize = true;
            this.OrderPanel__TitleRoller.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderPanel__TitleRoller.Location = new System.Drawing.Point(69, 45);
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
            this.OrderPanel__TitleOrder.Location = new System.Drawing.Point(52, 12);
            this.OrderPanel__TitleOrder.Name = "OrderPanel__TitleOrder";
            this.OrderPanel__TitleOrder.Size = new System.Drawing.Size(80, 21);
            this.OrderPanel__TitleOrder.TabIndex = 24;
            this.OrderPanel__TitleOrder.Text = "Заказ №:";
            // 
            // OrderViewPanel
            // 
            this.OrderViewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderViewPanel.BackColor = System.Drawing.SystemColors.Control;
            this.OrderViewPanel.Controls.Add(this.OrderPanel__OperatorFullName);
            this.OrderViewPanel.Controls.Add(this.OrderPanel__TextOpreration);
            this.OrderViewPanel.Controls.Add(this.OrderPanel__TextRoller);
            this.OrderViewPanel.Controls.Add(this.OrderPanel__TextOrder);
            this.OrderViewPanel.Controls.Add(this.OrderPanel__TitleUser);
            this.OrderViewPanel.Controls.Add(this.OrderPanel__TitleRoller);
            this.OrderViewPanel.Controls.Add(this.OrderPanel__TitleOpreration);
            this.OrderViewPanel.Controls.Add(this.OrderPanel__TitleOrder);
            this.OrderViewPanel.Location = new System.Drawing.Point(12, 474);
            this.OrderViewPanel.Name = "OrderViewPanel";
            this.OrderViewPanel.Size = new System.Drawing.Size(564, 145);
            this.OrderViewPanel.TabIndex = 28;
            // 
            // OrderPanel__OperatorFullName
            // 
            this.OrderPanel__OperatorFullName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OrderPanel__OperatorFullName.AutoSize = true;
            this.OrderPanel__OperatorFullName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderPanel__OperatorFullName.Location = new System.Drawing.Point(135, 111);
            this.OrderPanel__OperatorFullName.Name = "OrderPanel__OperatorFullName";
            this.OrderPanel__OperatorFullName.Size = new System.Drawing.Size(0, 21);
            this.OrderPanel__OperatorFullName.TabIndex = 31;
            // 
            // OrderPanel__TextOpreration
            // 
            this.OrderPanel__TextOpreration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OrderPanel__TextOpreration.AutoSize = true;
            this.OrderPanel__TextOpreration.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderPanel__TextOpreration.Location = new System.Drawing.Point(135, 78);
            this.OrderPanel__TextOpreration.Name = "OrderPanel__TextOpreration";
            this.OrderPanel__TextOpreration.Size = new System.Drawing.Size(0, 21);
            this.OrderPanel__TextOpreration.TabIndex = 30;
            // 
            // OrderPanel__TextRoller
            // 
            this.OrderPanel__TextRoller.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OrderPanel__TextRoller.AutoSize = true;
            this.OrderPanel__TextRoller.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderPanel__TextRoller.Location = new System.Drawing.Point(135, 45);
            this.OrderPanel__TextRoller.Name = "OrderPanel__TextRoller";
            this.OrderPanel__TextRoller.Size = new System.Drawing.Size(0, 21);
            this.OrderPanel__TextRoller.TabIndex = 29;
            // 
            // OrderPanel__TextOrder
            // 
            this.OrderPanel__TextOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OrderPanel__TextOrder.AutoSize = true;
            this.OrderPanel__TextOrder.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderPanel__TextOrder.Location = new System.Drawing.Point(135, 12);
            this.OrderPanel__TextOrder.Name = "OrderPanel__TextOrder";
            this.OrderPanel__TextOrder.Size = new System.Drawing.Size(0, 21);
            this.OrderPanel__TextOrder.TabIndex = 28;
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
            this.showSettingBtn});
            this.настройкиToolStripMenuItem1.Name = "настройкиToolStripMenuItem1";
            this.настройкиToolStripMenuItem1.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem1.Text = "Настройки";
            // 
            // showSettingBtn
            // 
            this.showSettingBtn.Name = "showSettingBtn";
            this.showSettingBtn.Size = new System.Drawing.Size(115, 22);
            this.showSettingBtn.Text = "Камера";
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
            this.menuStrip1.Size = new System.Drawing.Size(946, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // videoPlayer
            // 
            this.videoPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.videoPlayer.BackColor = System.Drawing.Color.Black;
            this.videoPlayer.Location = new System.Drawing.Point(590, 22);
            this.videoPlayer.Name = "videoPlayer";
            this.videoPlayer.Size = new System.Drawing.Size(350, 235);
            this.videoPlayer.TabIndex = 29;
            this.videoPlayer.Text = "videoSourcePlayer1";
            this.videoPlayer.VideoSource = null;
            this.videoPlayer.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.VideoPlayer_NewFrame);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = null;
            this.pictureBox1.Location = new System.Drawing.Point(8, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(576, 442);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 627);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.videoPlayer);
            this.Controls.Add(this.OrderViewPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WebCamCapture";
            this.panel1.ResumeLayout(false);
            this.OrderViewPanel.ResumeLayout(false);
            this.OrderViewPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button makeSnapshotBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView photoGalleraya;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button orderEditBtn;
        private System.Windows.Forms.Label OrderPanel__TitleUser;
        private System.Windows.Forms.Label OrderPanel__TitleOpreration;
        private System.Windows.Forms.Label OrderPanel__TitleRoller;
        private System.Windows.Forms.Label OrderPanel__TitleOrder;
        private System.Windows.Forms.Panel OrderViewPanel;
        private System.Windows.Forms.Label OrderPanel__TextOrder;
        private System.Windows.Forms.Label OrderPanel__OperatorFullName;
        private System.Windows.Forms.Label OrderPanel__TextOpreration;
        private System.Windows.Forms.Label OrderPanel__TextRoller;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйЗаказToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showSettingBtn;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private AForge.Controls.VideoSourcePlayer videoPlayer;
        private AForge.Controls.PictureBox pictureBox1;
    }
}

