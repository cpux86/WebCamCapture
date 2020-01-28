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
        private readonly IOrders orders;
        private IOrder order;

        public OrderPresenter(IOrderView orderView, IOrders orders)
        {
            this.orderForm = orderView;
            this.orders = orders;
        }
        public void AddOrder()
        {
            order.Number = "100/10/5";
            order.Roller = "850";
            order.Operation = "Тест";
            order.User = "Каськов В.В";
            orders.Add(order);
        }
    }
}
