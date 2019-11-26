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
            this.CamsList = new System.Windows.Forms.ListBox();
            this.btnScreenCapture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CamView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVideoCapture
            // 
            this.btnVideoCapture.Location = new System.Drawing.Point(452, 127);
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
            this.CamView.Location = new System.Drawing.Point(33, 26);
            this.CamView.Name = "CamView";
            this.CamView.Size = new System.Drawing.Size(392, 395);
            this.CamView.TabIndex = 1;
            this.CamView.TabStop = false;
            // 
            // CamsList
            // 
            this.CamsList.FormattingEnabled = true;
            this.CamsList.Location = new System.Drawing.Point(452, 26);
            this.CamsList.Name = "CamsList";
            this.CamsList.Size = new System.Drawing.Size(199, 95);
            this.CamsList.TabIndex = 2;
            // 
            // btnScreenCapture
            // 
            this.btnScreenCapture.Location = new System.Drawing.Point(576, 127);
            this.btnScreenCapture.Name = "btnScreenCapture";
            this.btnScreenCapture.Size = new System.Drawing.Size(75, 23);
            this.btnScreenCapture.TabIndex = 3;
            this.btnScreenCapture.Text = "Скриншот";
            this.btnScreenCapture.UseVisualStyleBackColor = true;
            this.btnScreenCapture.Click += new System.EventHandler(this.BtnScreenCapture_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnScreenCapture);
            this.Controls.Add(this.CamsList);
            this.Controls.Add(this.CamView);
            this.Controls.Add(this.btnVideoCapture);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.CamView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVideoCapture;
        private System.Windows.Forms.PictureBox CamView;
        private System.Windows.Forms.ListBox CamsList;
        private System.Windows.Forms.Button btnScreenCapture;
    }
}

