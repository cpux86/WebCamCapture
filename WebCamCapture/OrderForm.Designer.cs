namespace WebCamCapture
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
            this.userNameList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.operationList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rollerNumber = new System.Windows.Forms.Label();
            this.orderText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rollerCbox = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.orderCbox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameList
            // 
            this.userNameList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameList.AutoCompleteCustomSource.AddRange(new string[] {
            "Каськов В.В",
            "Кузнецов В.Ю",
            "Брянцев Н.А"});
            this.userNameList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.userNameList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.userNameList.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameList.FormattingEnabled = true;
            this.userNameList.Location = new System.Drawing.Point(182, 132);
            this.userNameList.MaximumSize = new System.Drawing.Size(600, 0);
            this.userNameList.MinimumSize = new System.Drawing.Size(151, 0);
            this.userNameList.Name = "userNameList";
            this.userNameList.Size = new System.Drawing.Size(295, 29);
            this.userNameList.TabIndex = 22;
            this.userNameList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserNameList_KeyPress);
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
            // operationList
            // 
            this.operationList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.operationList.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationList.FormattingEnabled = true;
            this.operationList.Location = new System.Drawing.Point(182, 96);
            this.operationList.MaximumSize = new System.Drawing.Size(600, 0);
            this.operationList.MinimumSize = new System.Drawing.Size(150, 0);
            this.operationList.Name = "operationList";
            this.operationList.Size = new System.Drawing.Size(294, 29);
            this.operationList.TabIndex = 21;
            this.operationList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OperationList_KeyPress);
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
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
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
            // orderCbox
            // 
            this.orderCbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderCbox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderCbox.FormattingEnabled = true;
            this.orderCbox.ItemHeight = 21;
            this.orderCbox.Location = new System.Drawing.Point(183, 25);
            this.orderCbox.MaximumSize = new System.Drawing.Size(300, 0);
            this.orderCbox.MinimumSize = new System.Drawing.Size(150, 0);
            this.orderCbox.Name = "orderCbox";
            this.orderCbox.Size = new System.Drawing.Size(294, 29);
            this.orderCbox.TabIndex = 29;
            this.orderCbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OrderCbox_KeyPress);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 242);
            this.Controls.Add(this.orderCbox);
            this.Controls.Add(this.rollerCbox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userNameList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.operationList);
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

        private System.Windows.Forms.ComboBox userNameList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox operationList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label rollerNumber;
        private System.Windows.Forms.Label orderText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox rollerCbox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox orderCbox;
    }
}