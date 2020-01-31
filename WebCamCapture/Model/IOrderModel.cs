using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCamCapture.Model
{
    interface IOrderModel
    {
        string Number { get; set; }
        string Roller { get; set; }
        string Operation { get; set; }
        string User { get; set; }

        /// <summary>
        /// Сигнал, данные в модели заказа были изменены
        /// </summary>
        event Action UpdateOrder;
        void SignalUpdate();
    }
}
