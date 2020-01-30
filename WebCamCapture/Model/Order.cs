using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCamCapture.Model
{
    class Order : IOrder
    {
        string order;
        string roller;
        string operation;
        string user;

        public string Number { get => order; set => order = value; }
        public string Roller { get => roller; set => roller = value; }
        public string Operation { get => operation; set => operation = value; }
        public string User { get => user; set => user = value; }

        
        public event Action UpdateOrder;

        public void SignalUpdate()
        {
            UpdateOrder();
        }
    }
}
