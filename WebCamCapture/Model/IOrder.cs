using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCamCapture.Model
{
    interface IOrder
    {
        string Number { get; set; }
        string Roller { get; set; }
        string Operation { get; set; }
        string User { get; set; }
        event Action UpdateOrder;
        void SignalUpdate();
    }
}
