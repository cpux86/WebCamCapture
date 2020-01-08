using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCamCapture.View;

namespace WebCamCapture.Presenter
{
    class BasePresenter : IView
    {
        public void Show()
        {
            System.Windows.Forms.MessageBox.Show("Test");
        }
        public void Close()
        {

        }
    }
}
