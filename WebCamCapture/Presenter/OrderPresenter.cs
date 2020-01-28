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
        private readonly OrderModel orderModel;

        public OrderPresenter(IOrderView orderView, OrderModel orderModel)
        {
            this.orderForm = orderView;
            this.orderModel = orderModel;
            
            
        }
    }
}
