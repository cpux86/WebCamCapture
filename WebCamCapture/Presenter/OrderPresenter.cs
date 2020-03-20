﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCamCapture.View;
using System.Windows.Forms;
using WebCamCapture.Model;

namespace WebCamCapture.Presenter
{
 
    static class Order
    {
        /// <summary>
        /// Текущий номер заказа
        /// </summary>
        public static string OrderNumber { get; set; }
        /// <summary>
        /// Текущий номер ролика
        /// </summary>
        public static string Roller { get; set; }
        /// <summary>
        /// Текущий процесс
        /// </summary>
        public static string Process { get; set; }
        /// <summary>
        /// Текущий пользователь
        /// </summary>
        public static string User { get; set; }

        /// <summary>
        /// Отобразить текущий заказ в главной форме 
        /// </summary>
        /// <param name="order"></param>
        public static void Show(IOrderMainForm order)
        {
            order.OrderNumber = OrderNumber;
            order.Roller = Roller;
            order.Process = Process;
            order.User = User;           
        }
    }

    class OrderPresenter
    {

        private readonly IOrderMainForm mainForm;
        private readonly ManagerAttributes manager;
        // индекс списка по умолчанию
        private int orderIndex = -1;
        private int rollerIndex = -1;
        private int processIndex = -1;
        private int userIndex = -1;
        public OrderPresenter(IOrderMainForm mainForm)
        {
            this.mainForm = mainForm;
            this.mainForm.ShowOrderForm += ShowOrderForm;
            manager = new ManagerAttributes().Init();
            mainForm.FormClosing += MainForm_FormClosing;           
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // При закрытии главной формы программы, сохраняем состояния формы заказа в файле
            manager.Save();
        }

        private void ShowOrderForm()
        {
            IOrderForm orderForm = new OrderForm();
            #region Заполняем списки данными
            orderForm.OrderList = manager.Order().List();
            orderForm.RollerList = manager.Roller().List();
            orderForm.ProcessList = manager.Process().List();
            orderForm.UsersList = manager.User().List();

            #region Заполняем списки автозаполнения данными 
            orderForm.OrderListAutoComplete = manager.Order().List();
            orderForm.RollerListAutoComplete = manager.Roller().List();
            orderForm.ProcessListAutoComplete = manager.Process().List();
            orderForm.UserListAutoComplete = manager.User().List();
            #endregion

            #region Устанавливаем текущий индекс для списка
            orderForm.OrderIndex = this.orderIndex;
            orderForm.RollerIndex = this.rollerIndex;
            orderForm.ProcessIndex = this.processIndex;
            orderForm.UserIndex = this.userIndex;
            #endregion

            #endregion

            if (orderForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                #region Получить данные из формы

                Order.OrderNumber = orderForm.OrderNumber;
                Order.Roller = orderForm.Roller;
                Order.Process = orderForm.Process;
                Order.User = orderForm.User;

                this.orderIndex = manager.Order().Add(Order.OrderNumber);
                this.rollerIndex = manager.Roller().Add(Order.Roller);
                this.processIndex = manager.Process().Add(Order.Process);
                this.userIndex = manager.User().Add(Order.User);

                // отобразить состояния заказа в главной форме 
                Order.Show(mainForm);

                #endregion
            }
        }
    }
}
