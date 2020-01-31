using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCamCapture.Model;
using WebCamCapture.View;

namespace WebCamCapture.Presenter
{
    class OrderPresenter
    {
        private readonly IOrderView orderForm;
        private readonly IOrderModel orderModel;

        public OrderPresenter(IOrderView orderView, IOrderModel order)
        {
            this.orderForm = orderView;
            this.orderModel = order;
            this.orderForm.RollerList = new string[] { "800M", "850R","900W" };
            this.orderForm.OperationsList = new string[] {"Тест № 1","Тест № 2","Тест № 3" };
            this.orderForm.UsersList = new string[] {"Иванов И.И","Петров П.П","Сидоров С.С" };
            orderForm.BtnOkOrderClick += OrderView_BtnOkOrderClick;
        }
        /// <summary>
        /// Обработчик щелчка по кнопке Ok формы заказа
        /// </summary>
        private void OrderView_BtnOkOrderClick()
        {
            // Заполняем модель данными о заказе из формы ввода
            orderModel.Number = orderForm.Order;
            orderModel.Roller = orderForm.SelectedRoller;
            orderModel.Operation = orderForm.SelectedOperation;
            orderModel.User = orderForm.SelectedUser;
            // уведомляем модель, что данные в ней были изменены
            orderModel.SignalUpdate();
        }
    }
}
