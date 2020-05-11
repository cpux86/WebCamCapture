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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.makeSnapshotBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.orderEditBtn = new System.Windows.Forms.Button();
            this.OrderPanel__TitleUser = new System.Windows.Forms.Label();
            this.OrderPanel__TitleOpreration = new System.Windows.Forms.Label();
            this.OrderPanel__TitleRoller = new System.Windows.Forms.Label();
            this.OrderPanel__TitleOrder = new System.Windows.Forms.Label();
            this.OrderViewPanel = new System.Windows.Forms.Panel();
            this.OperatorFullNameMainForm = new System.Windows.Forms.Label();
            this.TextOprerationMainForm = new System.Windows.Forms.Label();
            this.TextRollerMainForm = new System.Windows.Forms.Label();
            this.TextOrderMainForm = new System.Windows.Forms.Label();
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.process = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.OrderViewPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.snapshotView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.makeSnapshotBtn.Click += new System.EventHandler(this.makeSnapshotBtn_Click);
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.orderEditBtn);
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
            this.orderEditBtn.Click += new System.EventHandler(this.OrderEditBtn_Click);
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
            this.OrderPanel__TitleOpreration.Location = new System.Drawing.Point(49, 78);
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
            this.OrderPanel__TitleOrder.Location = new System.Drawing.Point(75, 12);
            this.OrderPanel__TitleOrder.Name = "OrderPanel__TitleOrder";
            this.OrderPanel__TitleOrder.Size = new System.Drawing.Size(57, 21);
            this.OrderPanel__TitleOrder.TabIndex = 24;
            this.OrderPanel__TitleOrder.Text = "Заказ:";
            // 
            // OrderViewPanel
            // 
            this.OrderViewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderViewPanel.BackColor = System.Drawing.SystemColors.Control;
            this.OrderViewPanel.Controls.Add(this.OperatorFullNameMainForm);
            this.OrderViewPanel.Controls.Add(this.TextOprerationMainForm);
            this.OrderViewPanel.Controls.Add(this.TextRollerMainForm);
            this.OrderViewPanel.Controls.Add(this.TextOrderMainForm);
            this.OrderViewPanel.Controls.Add(this.OrderPanel__TitleUser);
            this.OrderViewPanel.Controls.Add(this.OrderPanel__TitleRoller);
            this.OrderViewPanel.Controls.Add(this.OrderPanel__TitleOpreration);
            this.OrderViewPanel.Controls.Add(this.OrderPanel__TitleOrder);
            this.OrderViewPanel.Location = new System.Drawing.Point(12, 474);
            this.OrderViewPanel.Name = "OrderViewPanel";
            this.OrderViewPanel.Size = new System.Drawing.Size(572, 145);
            this.OrderViewPanel.TabIndex = 28;
            // 
            // OperatorFullNameMainForm
            // 
            this.OperatorFullNameMainForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OperatorFullNameMainForm.AutoSize = true;
            this.OperatorFullNameMainForm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OperatorFullNameMainForm.Location = new System.Drawing.Point(135, 111);
            this.OperatorFullNameMainForm.Name = "OperatorFullNameMainForm";
            this.OperatorFullNameMainForm.Size = new System.Drawing.Size(0, 21);
            this.OperatorFullNameMainForm.TabIndex = 31;
            // 
            // TextOprerationMainForm
            // 
            this.TextOprerationMainForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TextOprerationMainForm.AutoSize = true;
            this.TextOprerationMainForm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextOprerationMainForm.Location = new System.Drawing.Point(135, 78);
            this.TextOprerationMainForm.Name = "TextOprerationMainForm";
            this.TextOprerationMainForm.Size = new System.Drawing.Size(0, 21);
            this.TextOprerationMainForm.TabIndex = 30;
            // 
            // TextRollerMainForm
            // 
            this.TextRollerMainForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TextRollerMainForm.AutoSize = true;
            this.TextRollerMainForm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextRollerMainForm.Location = new System.Drawing.Point(135, 45);
            this.TextRollerMainForm.Name = "TextRollerMainForm";
            this.TextRollerMainForm.Size = new System.Drawing.Size(0, 21);
            this.TextRollerMainForm.TabIndex = 29;
            // 
            // TextOrderMainForm
            // 
            this.TextOrderMainForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TextOrderMainForm.AutoSize = true;
            this.TextOrderMainForm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextOrderMainForm.Location = new System.Drawing.Point(135, 12);
            this.TextOrderMainForm.Name = "TextOrderMainForm";
            this.TextOrderMainForm.Size = new System.Drawing.Size(0, 21);
            this.TextOrderMainForm.TabIndex = 28;
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
            this.showAppSetting,
            this.deviceManagerItem});
            this.настройкиToolStripMenuItem1.Name = "настройкиToolStripMenuItem1";
            this.настройкиToolStripMenuItem1.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem1.Text = "Настройки";
            // 
            // showAppSetting
            // 
            this.showAppSetting.Name = "showAppSetting";
            this.showAppSetting.Size = new System.Drawing.Size(140, 22);
            this.showAppSetting.Text = "Общие";
            this.showAppSetting.Click += new System.EventHandler(this.ShowAppSetting_Click);
            // 
            // deviceManagerItem
            // 
            this.deviceManagerItem.Enabled = false;
            this.deviceManagerItem.Name = "deviceManagerItem";
            this.deviceManagerItem.Size = new System.Drawing.Size(140, 22);
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
            this.menuStrip1.Size = new System.Drawing.Size(946, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // videoPlayer
            // 
            this.videoPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.videoPlayer.BackColor = System.Drawing.Color.Black;
            this.videoPlayer.Location = new System.Drawing.Point(590, 27);
            this.videoPlayer.Name = "videoPlayer";
            this.videoPlayer.Size = new System.Drawing.Size(350, 230);
            this.videoPlayer.TabIndex = 29;
            this.videoPlayer.Text = "videoSourcePlayer1";
            this.videoPlayer.VideoSource = null;
            // 
            // snapshotView
            // 
            this.snapshotView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.snapshotView.BackColor = System.Drawing.Color.Black;
            this.snapshotView.Image = null;
            this.snapshotView.Location = new System.Drawing.Point(12, 27);
            this.snapshotView.Name = "snapshotView";
            this.snapshotView.Size = new System.Drawing.Size(572, 441);
            this.snapshotView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.snapshotView.TabIndex = 30;
            this.snapshotView.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.order,
            this.dateTime,
            this.process,
            this.roller,
            this.user});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(7, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(337, 307);
            this.dataGridView1.TabIndex = 20;
            // 
            // order
            // 
            this.order.HeaderText = "Заказ";
            this.order.Name = "order";
            this.order.ReadOnly = true;
            // 
            // dateTime
            // 
            this.dateTime.HeaderText = "Дата";
            this.dateTime.Name = "dateTime";
            this.dateTime.ReadOnly = true;
            // 
            // process
            // 
            this.process.HeaderText = "Процесс";
            this.process.Name = "process";
            this.process.ReadOnly = true;
            // 
            // roller
            // 
            this.roller.HeaderText = "Ролик";
            this.roller.Name = "roller";
            this.roller.ReadOnly = true;
            // 
            // user
            // 
            this.user.HeaderText = "Исполнитель";
            this.user.Name = "user";
            this.user.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 627);
            this.Controls.Add(this.snapshotView);
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
            ((System.ComponentModel.ISupportInitialize)(this.snapshotView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label TextOrderMainForm;
        private System.Windows.Forms.Label OperatorFullNameMainForm;
        private System.Windows.Forms.Label TextOprerationMainForm;
        private System.Windows.Forms.Label TextRollerMainForm;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn order;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn process;
        private System.Windows.Forms.DataGridViewTextBoxColumn roller;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
    }
}

