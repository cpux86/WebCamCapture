namespace WebCamCapture.View
{
    partial class OrderForm
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
            this.components = new System.ComponentModel.Container();
            this.userNameCbox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.operationCbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rollerNumber = new System.Windows.Forms.Label();
            this.orderText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rollerCbox = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.orderTbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameCbox
            // 
            this.userNameCbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameCbox.AutoCompleteCustomSource.AddRange(new string[] {
            "Каськов В.В",
            "Кузнецов В.Ю",
            "Брянцев Н.А"});
            this.userNameCbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.userNameCbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.userNameCbox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameCbox.FormattingEnabled = true;
            this.userNameCbox.Location = new System.Drawing.Point(182, 132);
            this.userNameCbox.MaximumSize = new System.Drawing.Size(600, 0);
            this.userNameCbox.MinimumSize = new System.Drawing.Size(151, 0);
            this.userNameCbox.Name = "userNameCbox";
            this.userNameCbox.Size = new System.Drawing.Size(295, 29);
            this.userNameCbox.TabIndex = 22;
            this.userNameCbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserNameList_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "ИСПОЛНИТЕЛЬ:";
            // 
            // operationCbox
            // 
            this.operationCbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.operationCbox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationCbox.FormattingEnabled = true;
            this.operationCbox.Location = new System.Drawing.Point(182, 96);
            this.operationCbox.MaximumSize = new System.Drawing.Size(600, 0);
            this.operationCbox.MinimumSize = new System.Drawing.Size(150, 0);
            this.operationCbox.Name = "operationCbox";
            this.operationCbox.Size = new System.Drawing.Size(294, 29);
            this.operationCbox.TabIndex = 21;
            this.operationCbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OperationList_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(37, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "№ ОПЕРАЦИИ:";
            // 
            // rollerNumber
            // 
            this.rollerNumber.AutoSize = true;
            this.rollerNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rollerNumber.Location = new System.Drawing.Point(61, 64);
            this.rollerNumber.Name = "rollerNumber";
            this.rollerNumber.Size = new System.Drawing.Size(98, 20);
            this.rollerNumber.TabIndex = 21;
            this.rollerNumber.Text = "№ РОЛИКА:";
            // 
            // orderText
            // 
            this.orderText.AutoSize = true;
            this.orderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderText.Location = new System.Drawing.Point(62, 29);
            this.orderText.Name = "orderText";
            this.orderText.Size = new System.Drawing.Size(97, 20);
            this.orderText.TabIndex = 20;
            this.orderText.Text = "№ ЗАКАЗА:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(183, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 43);
            this.button1.TabIndex = 27;
            this.button1.Text = "ПРИМЕНИТЬ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(337, 177);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 43);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "ОТМЕНА";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // rollerCbox
            // 
            this.rollerCbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rollerCbox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rollerCbox.FormattingEnabled = true;
            this.rollerCbox.ItemHeight = 21;
            this.rollerCbox.Location = new System.Drawing.Point(182, 60);
            this.rollerCbox.MaximumSize = new System.Drawing.Size(300, 0);
            this.rollerCbox.MinimumSize = new System.Drawing.Size(150, 0);
            this.rollerCbox.Name = "rollerCbox";
            this.rollerCbox.Size = new System.Drawing.Size(294, 29);
            this.rollerCbox.TabIndex = 20;
            this.rollerCbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RollerCbox_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // orderTbox
            // 
            this.orderTbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderTbox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderTbox.Location = new System.Drawing.Point(182, 25);
            this.orderTbox.MaximumSize = new System.Drawing.Size(300, 29);
            this.orderTbox.MinimumSize = new System.Drawing.Size(150, 29);
            this.orderTbox.Name = "orderTbox";
            this.orderTbox.Size = new System.Drawing.Size(293, 29);
            this.orderTbox.TabIndex = 29;
            this.orderTbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OrderTbox_KeyPress);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 242);
            this.Controls.Add(this.orderTbox);
            this.Controls.Add(this.rollerCbox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userNameCbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.operationCbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rollerNumber);
            this.Controls.Add(this.orderText);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(832, 281);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(391, 266);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма заказа";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox userNameCbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox operationCbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label rollerNumber;
        private System.Windows.Forms.Label orderText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox rollerCbox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox orderTbox;
    }
}