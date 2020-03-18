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
    internal interface IOrderForm
    {
        string[] RollerList { set; }
        string[] ProcessList { set; }
        string[] UsersList { set; }

        string Order { get; }
        string Roller { get; }
        string Process { get; }
        string User { get; }

        int RollerIndex { get; set; }

        #region Автозаполние списков в форме заказа
        /// <summary>
        /// Данные для атозаполнения списка роликов
        /// </summary>
        string[] RollerListAutoComplete { set; }
        /// <summary>
        /// Данные для атозаполнения списка процессов
        /// </summary>
        string[] ProcessListAutoComplete { set; }      
        /// <summary>
        /// Данные для атозаполнения списка пользователей
        /// </summary>
        string[] UserListAutoComplete { set; }
        #endregion


        DialogResult ShowDialog();

        event Action BtnOkOrderClick;
    }

    public partial class OrderForm : Form, IOrderForm
    {
        public string[] RollerList { set => rollerCbox.Items.AddRange(value); }
        public string[] ProcessList { set => processCbox.Items.AddRange(value); }
        public string[] UsersList { set => userNameCbox.Items.AddRange(value); }

        public int RollerIndex { get => rollerCbox.SelectedIndex; set => rollerCbox.SelectedIndex = value; }

        #region Автозаполнение списков в форме заказа
        // Данные для атозаполнения списка роликов
        public string[] RollerListAutoComplete { set => rollerCbox.AutoCompleteCustomSource.AddRange(value); }
        // Данные для атозаполнения списка процессов
        public string[] ProcessListAutoComplete { set => processCbox.AutoCompleteCustomSource.AddRange(value); }
        // Данные для атозаполнения списка пользователей
        public string[] UserListAutoComplete { set => userNameCbox.AutoCompleteCustomSource.AddRange(value); }
        
        #endregion


        public string Order { get => orderTbox.Text; set => orderTbox.Text = value; }
        public string Roller { get => rollerCbox.Text; }
        public string Process { get => processCbox.Text; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string User { get => userNameCbox.Text; set => userNameCbox.Text = value; }

        public event Action BtnOkOrderClick;

        public OrderForm()
        {
            InitializeComponent();
            orderTbox.Validated += OrderTbox_Validated;
            this.KeyPreview = true;
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
            if (!Char.IsDigit(number) && number != 8 && !Char.IsLetter(number) && !Char.IsWhiteSpace(number) && number != 46)
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
            //e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void OperationList_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Цифры, буквы, пробел, BS, и точка.
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && !Char.IsLetter(number) && number != 8 && !Char.IsWhiteSpace(number) && number != 46)
            {
                e.Handled = true;
            }

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

            //BtnOkOrderClick();
        }

        private void OrderForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Control p;
                //p = ((Button)sender).Parent;
                //p.SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
    }


}
