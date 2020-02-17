using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCamCapture.View;
using WebCamCapture.Model;

namespace WebCamCapture.Presenter
{
    class SettingPresenter
    {
        readonly IPlayer player;
        public SettingPresenter(IPlayer mainForm)
        {
            this.player = mainForm;
            this.player.Load += Player_Load;
            
        }

        private void Player_Load(object sender, EventArgs e)
        {
            Devices devices = new Devices();
            Device device = devices.SelectedDevice(1);
            var devList = devices.GetDevicesNameList();
            var modList = device.GetFrameSizeList();
            var z = device.GetZoom();
            
            player.VideoSource = device.videoSource;
            player.Start();
            
            var f = player.CurrentFrame;
            //var s = f.Size;

        }
    }
}
