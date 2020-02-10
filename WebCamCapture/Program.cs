using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebCamCapture.View;

namespace WebCamCapture
{
    static class Program
    {
        static Model.PlayerModel pleerModel;
        static Presenter.SettingPresenter playerSettingPresenter;
        static Presenter.OrderPresenter orderPresenter;
        static Model.OrderModel orderModel;
        static View.OrderForm orderForm;
        static View.SettingForm playerSettingForm;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var mainForm = new View.MainForm();

           
            pleerModel = new Model.PlayerModel();
            mainForm.ShowSettingForm += MainForm_ShowSettingForm;
            mainForm.OrderEditBtn += MainForm_OrderEditBtn;
            orderModel = new Model.OrderModel();


            orderForm = new OrderForm();
            orderPresenter = new Presenter.OrderPresenter(orderForm, orderModel);

            playerSettingForm = new SettingForm();
            new Presenter.MainPresenter(mainForm, pleerModel, orderModel);
            playerSettingPresenter = new Presenter.SettingPresenter(playerSettingForm, pleerModel);
            // Тест






            Model.Devices devices = new Model.Devices();
            int count = devices.Counter;
            List<string> devList = devices.GetDevicesNameList();

            Model.Device device = devices.SelectedDevice(0);

            List<string> modList = device.GetFrameSizeList();
            Model.ICurrentProperty currentPropertyZoom = device.CurrentZoom();

            Model.Player player = new Model.Player();
            player.Start();
           // player.Stop();
            player.NewFrame += Player_NewFrame;

            //var x = device.GetFrameSizeList();
            //var v = device.CurrentVerticalPosition();
            //var currentProperty = device.CurrentZoom();

            //devices

            var a = device.CurrentZoom();
            var b = device.CurrentFocus();
            var c = device.CurrentExposure();

            var a1 = device.GetZoomRange();
            var a2 = device.GetFocusRange();
            var a3 = device.GetExposureRange();



            //Model.Devices device 


            //device.GetDeviceNameList().
            // devielse.GetFrameSizeList
            //var x = device.GetFrameSizeList(1);
            //device.SetProperty(AForge.Video.DirectShow.CameraControlProperty.Zoom, 200, AForge.Video.DirectShow.CameraControlFlags.Manual);
            //Model.IPropertyRange y = device.GetZoomRange();
            //var t = (Model.Device)device;
            //var z = device.GetFocusRange();
            //var ex = device.GetExposureRange();
            //var xx = device.CurrentHorizontalPosition().Value;






            try
            {
                Application.Run(mainForm);
            }
            catch (InvalidOperationException e)
            {
                MessageBox.Show(e.Message);               
            }
            
           
        }

        private static void Player_NewFrame(System.Drawing.Image obj)
        {
            throw new NotImplementedException();
        }

        // отобразить форму заказа
        private static void MainForm_OrderEditBtn()
        {
            orderForm.ShowDialog();       
        }

        // отобразить форму настроек
        private static void MainForm_ShowSettingForm()
        {
            // отображаем форму настроек 
            playerSettingPresenter.Show();
            
        }
    }
}
