using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCamCapture.Model
{
    interface IOrders : IOrder
    {
        void Add(IOrder id);
        Order GetOrder(int id);
        Orders GetOrders();
    }
}
