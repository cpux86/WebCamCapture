namespace WebCamCapture
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.ScreenView = new System.Windows.Forms.PictureBox();
            this.CamView = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CamView)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.btnScreenCapture.Size = new System.Drawing.Size(126, 30);
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
            this.ListCaptutreModes.Location = new System.Drawing.Point(163, 0);
            this.ListCaptutreModes.Name = "ListCaptutreModes";
            this.ListCaptutreModes.Size = new System.Drawing.Size(90, 21);
            this.ListCaptutreModes.TabIndex = 5;
            this.ListCaptutreModes.SelectionChangeCommitted += new System.EventHandler(this.ListCaptureDevices_SelectionChangeCommitted);
            // 
            // ListCaptureDevices
            // 
            this.ListCaptureDevices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ListCaptureDevices.DisplayMember = "5";
            this.ListCaptureDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListCaptureDevices.FormattingEnabled = true;
            this.ListCaptureDevices.Location = new System.Drawing.Point(163, 33);
            this.ListCaptureDevices.Name = "ListCaptureDevices";
            this.ListCaptureDevices.Size = new System.Drawing.Size(90, 21);
            this.ListCaptureDevices.TabIndex = 6;
            this.ListCaptureDevices.SelectedIndexChanged += new System.EventHandler(this.ListCapureDevices_SelectedIndexChanged);
            this.ListCaptureDevices.SelectionChangeCommitted += new System.EventHandler(this.ListCaptureDevices_SelectionChangeCommitted);
            this.ListCaptureDevices.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListCaptureDevices_MouseDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(308, 276);
            this.dataGridView1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(5, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "TEST";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Button1_KeyDown);
            // 
            // ScreenView
            // 
            this.ScreenView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScreenView.BackColor = System.Drawing.Color.Black;
            this.ScreenView.Location = new System.Drawing.Point(5, 7);
            this.ScreenView.Name = "ScreenView";
            this.ScreenView.Size = new System.Drawing.Size(624, 596);
            this.ScreenView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ScreenView.TabIndex = 9;
            this.ScreenView.TabStop = false;
            this.ScreenView.DoubleClick += new System.EventHandler(this.ScreenView_DoubleClick);
            // 
            // CamView
            // 
            this.CamView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CamView.BackColor = System.Drawing.Color.Black;
            this.CamView.Location = new System.Drawing.Point(635, 7);
            this.CamView.Name = "CamView";
            this.CamView.Size = new System.Drawing.Size(308, 246);
            this.CamView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CamView.TabIndex = 1;
            this.CamView.TabStop = false;
            this.CamView.DoubleClick += new System.EventHandler(this.CamView_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnScreenCapture);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ListCaptutreModes);
            this.panel1.Controls.Add(this.ListCaptureDevices);
            this.panel1.Location = new System.Drawing.Point(630, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 350);
            this.panel1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 608);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CamView);
            this.Controls.Add(this.ScreenView);
            this.Name = "Form1";
            this.Text = "WebCamCapture";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CamView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnScreenCapture;
        private System.Windows.Forms.ComboBox ListCaptutreModes;
        private System.Windows.Forms.ComboBox ListCaptureDevices;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox ScreenView;
        private System.Windows.Forms.PictureBox CamView;
        private System.Windows.Forms.Panel panel1;
    }
}

