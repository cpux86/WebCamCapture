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
        private int rollerIndex;
        private int processIndex;
        private int userIndex;

        private string roller;
        private string process;
        private string user;


        public int RollerIndex { get => rollerIndex; set => rollerIndex = value; }
        public int ProcessIndex { get => processIndex; set => processIndex = value; }
        public int UserIndex { get => userIndex; set => userIndex = value; }

        public string Roller { get => roller; set => roller = value; }
        public string Process { get => process; set => process = value; }
        public string User { get => user; set => user = value; }

        /// <summary>
        /// Отобразить текущий заказ в главной форме 
        /// </summary>
        /// <param name="order"></param>
        public void Show(IOrderMainForm order)
        {
            order.Roller = this.Roller;
            order.Process = this.Process;
            order.User = this.User;           
        }
    }

    class OrderPresenter : Order
    {

        private readonly IOrderMainForm mainForm;
        private readonly ManagerAttributes manager;
        //private Order order;
        public OrderPresenter(IOrderMainForm mainForm)
        {
            this.mainForm = mainForm;
            //this.order = new Order();
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
            orderForm.RollerList = manager.Roller().List();
            orderForm.ProcessList = manager.Process().List();
            orderForm.UsersList = manager.User().List();
            //orderForm.RollerIndex = 0;
            // отобразить текущий заказ

            
            // автозаполнение
            orderForm.RollerListAutoComplete = manager.Roller().List();
            orderForm.ProcessListAutoComplete = manager.Process().List();
            orderForm.UserListAutoComplete = manager.User().List();

            #endregion

            if (orderForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                #region Получить данные из формы
                this.Roller = orderForm.Roller;
                this.Process = orderForm.Process;
                this.User = orderForm.User;
                var i = manager.Roller().Add(this.Roller);
                manager.Process().Add(this.Process);
                manager.User().Add(this.User);
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
