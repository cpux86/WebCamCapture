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
        private readonly IPlayerModel _pleer;
        private readonly IOrderModel _order;

        public MainPresenter(IMainView view, IPlayerModel pleer, IOrderModel order)
        {
            this._view = view;
            _pleer = pleer;
            _order = order;
            _view.OrderNumber = order.Number;
            _view.Roller = order.Roller;
            _view.Operation = order.Operation;
            _view.User = order.User;

            view.MakeSnapshot += View_MakeSnapshot;
            // _view.ShowSettingForm += View_ShowSettingForm;
            //_pleer.NewFrame += _Pleer_NewFrame;
            view.GetContext.FormClosing += GetContext_FormClosing;
            order.UpdateOrder += _order_UpdateOrder;
            
            
        }
        // произошло обнолвене заказа
        private void _order_UpdateOrder()
        {
            _view.OrderNumber = _order.Number;
            _view.Roller = _order.Roller;
            _view.Operation = _order.Operation;
            _view.User = _order.User;
        }

        private void GetContext_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Завершаем работу программы
            _pleer.Shutdown();
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
        Image _frame;
        /// <summary>
        /// Обработчик кадра полученного из модели
        /// </summary>
        /// <param name="frame"></param>
        public void _Pleer_NewFrame(Image frame)
        {
            if (_frame != null)
            {
                _frame.Dispose();
                _frame = null;

            }
            _frame = (Bitmap)frame.Clone();
            //_frame1 = new Bitmap((Bitmap)frame,new Size(320,240));
            //_view.ShowNewFrame(_frame);

        }
        Image _snapshot;
        /// <summary>
        /// Обработчик захваченного кадра (снимка)
        /// </summary>
        /// <param name="frame"></param>
        public void Snapshot(Image snapshot)
        {
            if (_snapshot != null)
            {
                _snapshot.Dispose();
                _snapshot = null;
            }
            
            _snapshot = (Bitmap)snapshot.Clone();
            //_view.ShowSnapshot = _snapshot;
            using (Image x = (Bitmap)snapshot.Clone())
            {
                x.Save("1.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                _pleer.NewFrame -= Snapshot;
            }
            //Image x = (Bitmap)_snapshot.Clone();
            
        }

    }
}
