using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

namespace WebCamCapture
{
    public partial class OrderForm : Form
    {
        //string order; // заказ
        //string roller; // ролик
        //string action; // операция
        //string user; // исполнитель
       
        public string Order { get => orderCbox.Text; set => orderCbox.Text = value; }
        public string Roller { get => rollerCbox.Text; set => rollerCbox.Text = value; }
        public string Action { get => operationList.Text; set => operationList.Text = value; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string User { get => userNameList.Text; set => userNameList.Text = value; }

        public OrderForm()
        {
            InitializeComponent();
            orderCbox.Validated += OrderTbox_Validated;
        }

        private void OrderTbox_Validated(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(orderCbox.Text))
            {
                errorProvider1.SetError(orderCbox, "Поля обязательно к заполнению!");
            }
        }

        private void OrderCbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // фильтруем ввод, только "0-9" и "/"
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 47 && number != 8)
            {
                e.Handled = true;
            }

        }

        private void RollerCbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // фильтруем ввод, только "0-9
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void UserNameList_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Буквы, пробел, BS, и точка.
            char number = e.KeyChar;
            if (!Char.IsLetter(number) && number != 8 && !Char.IsWhiteSpace(number) && number != 46)
            {
                
                e.Handled = true;
                
            }
            // преобразуем каждый введенный символ в врехний регистр.
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void OperationList_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Буквы, пробел, BS, и точка.
            char number = e.KeyChar;
            if (!Char.IsLetter(number) && number != 8 && !Char.IsWhiteSpace(number) && number != 46)
            {
                e.Handled = true;
            }
            // преобразуем каждый введенный символ в врехний регистр.
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ValidationContext context = new ValidationContext(this);
            var results = new List<ValidationResult>();;
            if (!Validator.TryValidateObject(this, context, results, true))
            {
                foreach (var error in results)
                {
                    MessageBox.Show(error.ErrorMessage);
                }
            }
        }
    }
}
