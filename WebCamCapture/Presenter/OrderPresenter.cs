using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCamCapture.View;
using System.Windows.Forms;

namespace WebCamCapture.Presenter
{
    class Order
    {
        // Состояние
        public string[] RollerList { get; set; }
        public string[] OperationsList { get; set; }
        public string[] UsersList { get; set; }

        public string SelectedRoller => throw new NotImplementedException();

        public string SelectedOperation => throw new NotImplementedException();

        public string SelectedUser => throw new NotImplementedException();
        /// <summary>
        /// Инициализируем свойства из ресурсов программы
        /// </summary>
        public void Init()
        {
            this.RollerList = this.GetRollerList();
            this.OperationsList = this.GetOperationsList();
            this.UsersList = this.GetUsersList();
        }

        #region Получение данных из ресурсов программы
        private string[] GetRollerList()
        {
            throw new NotImplementedException();
        }
        private string[] GetOperationsList()
        {
            throw new NotImplementedException();
        }
        private string[] GetUsersList()
        {
            throw new NotImplementedException();
        }
 
        #endregion

    }
    class OrderPresenter
    {
        readonly private IOrderMainForm mainForm;
        readonly Order order;
        public OrderPresenter(IOrderMainForm mainForm)
        {
            this.mainForm = mainForm;
            this.mainForm.ShowOrderForm += ShowOrderForm;
            order = new Order();
        }

        private void ShowOrderForm()
        {
            IOrderForm orderForm = new OrderForm();
            #region Установить данные для формы
            
            #endregion

            this.mainForm.User = "Каськов В.В";
            if (orderForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                #region Получить данные из формы

                #endregion
            }
        }
    }
}
