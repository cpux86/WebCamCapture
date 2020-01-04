using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebCamCapture.View;

namespace WebCamCapture.Presenter
{
    class MainPresenter
    {
        private readonly IMainView _view;
        public MainPresenter(IMainView view)
        {
            this._view = view;
           
            view.OrderNumber = "100/52";
            view.OperatorFullName = "Каськов Владимир Васильевич";
            view.ScreenCapture += View_ScreenCapture;
            
        }

        private void View_ScreenCapture(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Test");
        }
    }
}
