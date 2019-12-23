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
            this.userNameList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numberRollerList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rollerNumber = new System.Windows.Forms.Label();
            this.orderText = new System.Windows.Forms.Label();
            this.nomberOrder = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // userNameList
            // 
            this.userNameList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameList.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameList.FormattingEnabled = true;
            this.userNameList.Location = new System.Drawing.Point(182, 132);
            this.userNameList.MaximumSize = new System.Drawing.Size(600, 0);
            this.userNameList.MinimumSize = new System.Drawing.Size(151, 0);
            this.userNameList.Name = "userNameList";
            this.userNameList.Size = new System.Drawing.Size(295, 29);
            this.userNameList.TabIndex = 22;
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
            // numberRollerList
            // 
            this.numberRollerList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numberRollerList.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberRollerList.FormattingEnabled = true;
            this.numberRollerList.Location = new System.Drawing.Point(182, 96);
            this.numberRollerList.MaximumSize = new System.Drawing.Size(600, 0);
            this.numberRollerList.MinimumSize = new System.Drawing.Size(150, 0);
            this.numberRollerList.Name = "numberRollerList";
            this.numberRollerList.Size = new System.Drawing.Size(294, 29);
            this.numberRollerList.TabIndex = 21;
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
            // nomberOrder
            // 
            this.nomberOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nomberOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomberOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nomberOrder.Location = new System.Drawing.Point(182, 24);
            this.nomberOrder.MaximumSize = new System.Drawing.Size(300, 29);
            this.nomberOrder.MinimumSize = new System.Drawing.Size(150, 29);
            this.nomberOrder.Name = "nomberOrder";
            this.nomberOrder.Size = new System.Drawing.Size(294, 29);
            this.nomberOrder.TabIndex = 19;
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
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 21;
            this.comboBox1.Location = new System.Drawing.Point(182, 60);
            this.comboBox1.MaximumSize = new System.Drawing.Size(300, 0);
            this.comboBox1.MinimumSize = new System.Drawing.Size(150, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(294, 29);
            this.comboBox1.TabIndex = 20;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 242);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userNameList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numberRollerList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rollerNumber);
            this.Controls.Add(this.orderText);
            this.Controls.Add(this.nomberOrder);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(832, 281);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(391, 266);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма заказа";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox userNameList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox numberRollerList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label rollerNumber;
        private System.Windows.Forms.Label orderText;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox nomberOrder;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}