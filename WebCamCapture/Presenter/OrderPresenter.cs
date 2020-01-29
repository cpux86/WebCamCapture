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
            orders.Number = "100/10/5";
            orders.Roller = "850";
            orders.Operation = "Тест";
            orders.User = "Каськов В.В";
            List<string> str = new List<string>();
            str.Add("100/10/5");
            orderView.OrderList = str.ToArray();
        }
    }
}
