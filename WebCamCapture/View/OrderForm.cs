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

namespace WebCamCapture.View
{
    public partial class OrderForm : Form, IOrderView
    {
        public string[] RollerList { set => rollerCbox.Items.AddRange(value); }
        public string[] OperationsList { set => operationCbox.Items.AddRange(value); }
        public string[] UsersList { set => userNameCbox.Items.AddRange(value); }

        public string Order { get => orderTbox.Text; set => orderTbox.Text = value; }
        public string SelectedRoller { get => rollerCbox.Text; }
        public string SelectedOperation { get => operationCbox.SelectedText; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string SelectedUser { get => userNameCbox.Text; set => userNameCbox.Text = value; }

        public event Action BtnOkOrderClick;

        public OrderForm()
        {
            InitializeComponent();
            orderTbox.Validated += OrderTbox_Validated;
        }

        private void OrderTbox_Validated(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(orderTbox.Text))
            {
                errorProvider1.SetError(orderTbox, "Поля обязательно к заполнению!");
            }
        }

        private void OrderTbox_KeyPress(object sender, KeyPressEventArgs e)
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
            var results = new List<ValidationResult>();
            if (!Validator.TryValidateObject(this, context, results, true))
            {
                foreach (var error in results)
                {
                   // MessageBox.Show(error.ErrorMessage);
                }
            }

            BtnOkOrderClick();
        }
    }
}
