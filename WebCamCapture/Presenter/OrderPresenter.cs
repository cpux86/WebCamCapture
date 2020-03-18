using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCamCapture.View;
using System.Windows.Forms;
using WebCamCapture.Model;

namespace WebCamCapture.Presenter
{
 
    class Order
    {
        public string OrderNumber { get; set; }
        public string Roller { get; set; }
        public string Process { get; set; }
        public string User { get; set; }

        /// <summary>
        /// Отобразить текущий заказ в главной форме 
        /// </summary>
        /// <param name="order"></param>
        public void Show(IOrderMainForm order)
        {
            order.OrderNumber = this.OrderNumber;
            order.Roller = this.Roller;
            order.Process = this.Process;
            order.User = this.User;           
        }
    }

    class OrderPresenter : Order
    {

        private readonly IOrderMainForm mainForm;
        private readonly ManagerAttributes manager;
        private int order = -1;
        private int roller = -1;
        private int process = -1;
        private int user = -1;
        public OrderPresenter(IOrderMainForm mainForm)
        {
            this.mainForm = mainForm;
            this.mainForm.ShowOrderForm += ShowOrderForm;
            manager = new ManagerAttributes().Init();

            mainForm.FormClosing += MainForm_FormClosing;
            
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            manager.Save();
        }


        private void ShowOrderForm()
        {
            IOrderForm orderForm = new OrderForm();
            #region Установить данные для формы
            orderForm.OrderList = manager.Order().List();
            orderForm.RollerList = manager.Roller().List();
            orderForm.ProcessList = manager.Process().List();
            orderForm.UsersList = manager.User().List();
            // отобразить текущий заказ


            // автозаполнение
            orderForm.OrderListAutoComplete = manager.Order().List();
            orderForm.RollerListAutoComplete = manager.Roller().List();
            orderForm.ProcessListAutoComplete = manager.Process().List();
            orderForm.UserListAutoComplete = manager.User().List();

            //
            orderForm.OrderIndex = this.order;
            orderForm.RollerIndex = this.roller;
            orderForm.ProcessIndex = this.process;
            orderForm.UserIndex = this.user;
            

            #endregion

            if (orderForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                #region Получить данные из формы

                this.OrderNumber = orderForm.Order;
                this.Roller = orderForm.Roller;
                this.Process = orderForm.Process;
                this.User = orderForm.User;

                this.order = manager.Order().Add(this.OrderNumber);
                this.roller = manager.Roller().Add(this.Roller);
                this.process = manager.Process().Add(this.Process);
                this.user = manager.User().Add(this.User);

                //
                this.Show(mainForm);

                //mainForm.Roller = orderForm.Roller;
                //mainForm.Process = orderForm.Process;
                //mainForm.User = orderForm.User;
                #endregion
            }
        }
    }
}
