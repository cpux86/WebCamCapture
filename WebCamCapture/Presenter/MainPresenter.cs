using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using WebCamCapture.Model;
using WebCamCapture.View;

namespace WebCamCapture.Presenter
{
    class MainPresenter
    {
        private readonly IMainView _view;
        private readonly IPleer _pleer;
        private readonly IOrder _order;

        public MainPresenter(IMainView view, IPleer pleer, IOrder order)
        {
            this._view = view;
            _pleer = pleer;
            _view.OrderNumber = order.Number;
            _view.Roller = order.Roller;
            _view.Operation = order.Operation;
            _view.User = order.User;

            view.MakeSnapshot += View_MakeSnapshot;
           // _view.ShowSettingForm += View_ShowSettingForm;
            _pleer.NewFrame += _Pleer_NewFrame;
            _pleer.ChangeDeviceId += Pleer_ChangeDeviceId; 
            view.GetContext.FormClosing += GetContext_FormClosing;
            
        }

        private void Pleer_ChangeDeviceId(int x)
        {
            //MessageBox.Show(String.Format("Устройство {0} изменилось!", x.ToString()));
        }

        private void GetContext_FormClosing(object sender, FormClosingEventArgs e)
        {
            _view.GetContext.Invoke((MethodInvoker)(() => {
                _pleer.Stop();
            }));
            //
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Обработчик кнопки Cохранить снимок
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void View_MakeSnapshot()
        {
            _pleer.NewFrame -= Snapshot;
            // подписываемся на захват одного кадра
            _pleer.NewFrame += Snapshot;
        }
        /// <summary>
        /// Обработчик кадра полученного из модели
        /// </summary>
        /// <param name="frame"></param>
        public void _Pleer_NewFrame(Image frame)
        {
            _view.GetContext.Invoke((MethodInvoker)(() => {
                _view.ShowNewFrame(frame);
            }));
                     
        }
       
        /// <summary>
        /// Обработчик захваченного кадра (снимка)
        /// </summary>
        /// <param name="frame"></param>
        public void Snapshot(Image snapshot)
        {
            _view.ShowSnapshot = snapshot;
            _pleer.NewFrame -= Snapshot;       
        }
        
    }
}
