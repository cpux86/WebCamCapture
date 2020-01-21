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
        private IOrderForm orderForm;
        private IOrderModel orderModel;

        public OrderPresenter(IOrderForm orderForm, IOrderModel orderModel)
        {
            this.orderForm = orderForm;
            this.orderModel = orderModel;
            
        }
    }
}
