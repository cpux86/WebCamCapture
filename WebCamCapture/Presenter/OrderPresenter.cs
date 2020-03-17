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

    }

    class OrderPresenter
    {

        private readonly IOrderMainForm mainForm;
        private readonly ManagerAttributes manager;
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
            orderForm.RollerList = manager.Roller().List();
            orderForm.ProcessList = manager.Process().List();
            orderForm.UsersList = manager.User().List();
            // автозаполнение
            orderForm.RollerListAutoComplete = manager.Roller().List();
            orderForm.ProcessListAutoComplete = manager.Process().List();
            orderForm.UserListAutoComplete = manager.User().List();

            #endregion

            if (orderForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                #region Получить данные из формы
                manager.Roller().Add(orderForm.SelectedRoller);
                manager.Process().Add(orderForm.SelectedProcess);
                manager.User().Add(orderForm.SelectedUser);
                

                mainForm.Roller = orderForm.SelectedRoller;
                mainForm.Process = orderForm.SelectedProcess;
                mainForm.User = orderForm.SelectedUser;
                #endregion
            }
        }
    }
}
