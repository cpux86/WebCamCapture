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
            this.btnVideoCapture = new System.Windows.Forms.Button();
            this.CamView = new System.Windows.Forms.PictureBox();
            this.btnScreenCapture = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CamList = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.CamView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVideoCapture
            // 
            this.btnVideoCapture.Location = new System.Drawing.Point(658, 54);
            this.btnVideoCapture.Name = "btnVideoCapture";
            this.btnVideoCapture.Size = new System.Drawing.Size(97, 23);
            this.btnVideoCapture.TabIndex = 0;
            this.btnVideoCapture.Text = "Захват видео";
            this.btnVideoCapture.UseVisualStyleBackColor = true;
            this.btnVideoCapture.Click += new System.EventHandler(this.BtnVideoCapture_Click);
            // 
            // CamView
            // 
            this.CamView.BackColor = System.Drawing.Color.Black;
            this.CamView.Location = new System.Drawing.Point(12, 6);
            this.CamView.Name = "CamView";
            this.CamView.Size = new System.Drawing.Size(640, 480);
            this.CamView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CamView.TabIndex = 1;
            this.CamView.TabStop = false;
            // 
            // btnScreenCapture
            // 
            this.btnScreenCapture.Location = new System.Drawing.Point(771, 54);
            this.btnScreenCapture.Name = "btnScreenCapture";
            this.btnScreenCapture.Size = new System.Drawing.Size(75, 23);
            this.btnScreenCapture.TabIndex = 3;
            this.btnScreenCapture.Text = "Скриншот";
            this.btnScreenCapture.UseVisualStyleBackColor = true;
            this.btnScreenCapture.Click += new System.EventHandler(this.BtnScreenCapture_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Location = new System.Drawing.Point(771, 92);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(75, 23);
            this.btnSetting.TabIndex = 4;
            this.btnSetting.Text = "Настройка";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.BtnSetting_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "5";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(791, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(97, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // CamList
            // 
            this.CamList.DisplayMember = "5";
            this.CamList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CamList.FormattingEnabled = true;
            this.CamList.Location = new System.Drawing.Point(658, 6);
            this.CamList.Name = "CamList";
            this.CamList.Size = new System.Drawing.Size(127, 21);
            this.CamList.TabIndex = 6;
            this.CamList.SelectedIndexChanged += new System.EventHandler(this.CamList_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 498);
            this.Controls.Add(this.CamList);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnScreenCapture);
            this.Controls.Add(this.CamView);
            this.Controls.Add(this.btnVideoCapture);
            this.Name = "Form1";
            this.Text = "WebCamCapture";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CamView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVideoCapture;
        private System.Windows.Forms.PictureBox CamView;
        private System.Windows.Forms.Button btnScreenCapture;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox CamList;
    }
}

