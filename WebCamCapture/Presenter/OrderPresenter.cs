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
        private readonly IOrder order;

        public OrderPresenter(IOrderView orderView, IOrder order)
        {
            this.orderForm = orderView;
            this.order = order;
            orderForm.RollerList = new string[] { "800M", "850R","900W" };
            order.Operation = "Тест № 1";
            order.User = "Каськов В.В";
            orderForm.Order = order.Number;
            orderForm.BtnOkOrderClick += OrderView_BtnOkOrderClick;
        }

        private void OrderView_BtnOkOrderClick()
        {
            order.Number = orderForm.Order;
            order.Roller = orderForm.SelectedRoller;

            order.SignalUpdate();
        }
    }
}
