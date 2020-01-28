using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCamCapture.Model
{
    class Orders : Order, IOrders
    {
        List<IOrder> orders;
        public Orders()
        {
            orders = OrdersRequest();
        }

        public void Add(IOrder order)
        {
            orders.Add(order);
        }

        public Order GetOrder(int id)
        {
            throw new NotImplementedException();
        }

        public Orders GetOrders()
        {
            throw new NotImplementedException();
        }
        // получить из базы все заказы
        List<IOrder> OrdersRequest()
        {
            return new List<IOrder>(); // заглушка
        }
    }
}
