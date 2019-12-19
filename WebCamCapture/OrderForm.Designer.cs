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
            this.numberOperation = new System.Windows.Forms.TextBox();
            this.rollerNumber = new System.Windows.Forms.Label();
            this.orderText = new System.Windows.Forms.Label();
            this.nomberOrder = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNameList
            // 
            this.userNameList.FormattingEnabled = true;
            this.userNameList.Location = new System.Drawing.Point(182, 133);
            this.userNameList.Name = "userNameList";
            this.userNameList.Size = new System.Drawing.Size(113, 21);
            this.userNameList.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "ИСПОЛНИТЕЛЬ";
            // 
            // numberRollerList
            // 
            this.numberRollerList.FormattingEnabled = true;
            this.numberRollerList.Location = new System.Drawing.Point(182, 96);
            this.numberRollerList.Name = "numberRollerList";
            this.numberRollerList.Size = new System.Drawing.Size(113, 21);
            this.numberRollerList.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(37, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "№ ОПЕРАЦИИ";
            // 
            // numberOperation
            // 
            this.numberOperation.Location = new System.Drawing.Point(182, 60);
            this.numberOperation.Name = "numberOperation";
            this.numberOperation.Size = new System.Drawing.Size(113, 20);
            this.numberOperation.TabIndex = 22;
            // 
            // rollerNumber
            // 
            this.rollerNumber.AutoSize = true;
            this.rollerNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rollerNumber.Location = new System.Drawing.Point(61, 64);
            this.rollerNumber.Name = "rollerNumber";
            this.rollerNumber.Size = new System.Drawing.Size(94, 20);
            this.rollerNumber.TabIndex = 21;
            this.rollerNumber.Text = "№ РОЛИКА";
            // 
            // orderText
            // 
            this.orderText.AutoSize = true;
            this.orderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderText.Location = new System.Drawing.Point(62, 29);
            this.orderText.Name = "orderText";
            this.orderText.Size = new System.Drawing.Size(93, 20);
            this.orderText.TabIndex = 20;
            this.orderText.Text = "№ ЗАКАЗА";
            // 
            // nomberOrder
            // 
            this.nomberOrder.Location = new System.Drawing.Point(182, 24);
            this.nomberOrder.Name = "nomberOrder";
            this.nomberOrder.Size = new System.Drawing.Size(113, 20);
            this.nomberOrder.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(27, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 43);
            this.button1.TabIndex = 27;
            this.button1.Text = "ПРИМЕНИТЬ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 257);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userNameList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numberRollerList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberOperation);
            this.Controls.Add(this.rollerNumber);
            this.Controls.Add(this.orderText);
            this.Controls.Add(this.nomberOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderForm";
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
        private System.Windows.Forms.TextBox numberOperation;
        private System.Windows.Forms.Label rollerNumber;
        private System.Windows.Forms.Label orderText;
        private System.Windows.Forms.TextBox nomberOrder;
        private System.Windows.Forms.Button button1;
    }
}