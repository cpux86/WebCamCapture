using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebCamCapture.Model;
using WebCamCapture.View;

namespace WebCamCapture.Presenter
{
    class PlayerSettingPresenter
    {
        private ISettingView setting;
        private IPlayer player;
       

        public void Show(ISettingView setting, IPlayer player)
        {
            this.setting = setting;
            this.player = player;

            this.setting.DeviceList = player.DeviceList.ToArray();
            this.setting.SnapshotFolder = Properties.Settings.Default.FileDir;

            if (!this.player.IsRunning)
            {
                this.setting.ModesList = player.ListVideoModes.ToArray();

                this.setting.DeviceIndex = player.DeviceIndex;
                this.setting.ModeIndex = player.ModeIndex;
            }
            if (this.setting.ShowDialog() == DialogResult.OK)
            {
                // если выбран другой режим
                if (this.setting.ModeIndex != this.player.ModeIndex)
                {
                    this.player.Start(this.player.ListVideoModes[this.setting.DeviceIndex], this.player.ListVideoModes[this.setting.ModeIndex]);
                   

                }
                // сохраняем путь к снимкам 
                Properties.Settings.Default.FileDir = this.setting.SnapshotFolder;
                Properties.Settings.Default.SelectedDeviceName = player.DeviceList[this.setting.DeviceIndex];
                Properties.Settings.Default.SelectedFrameSize = player.ListVideoModes[this.player.ModeIndex];
            }
        }
    }
}
