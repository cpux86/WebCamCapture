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
    class SettingPresenter
    {
        private ISettingView setting;
        private IPleer pleer;
       

        public void Show(ISettingView setting, IPleer pleer)
        {
            this.setting = setting;
            this.pleer = pleer;

            this.setting.DeviceList = pleer.DeviceList.ToArray();
            this.setting.SnapshotFolder = Properties.Settings.Default.FileDir;

            if (this.pleer.IsRunning)
            {
                this.setting.ModesList = pleer.ListVideoModes.ToArray();

                this.setting.DeviceIndex = pleer.DeviceIndex;
                this.setting.ModeIndex = pleer.ModeIndex;
            }
            if (this.setting.ShowDialog() == DialogResult.OK)
            {
                // если выбран другой режим
                if (this.setting.ModeIndex != this.pleer.ModeIndex)
                {
                    this.pleer.Start(this.pleer.ListVideoModes[this.setting.DeviceIndex], this.pleer.ListVideoModes[this.setting.ModeIndex]);
                   

                }
                // сохраняем путь к снимкам 
                Properties.Settings.Default.FileDir = this.setting.SnapshotFolder;
                Properties.Settings.Default.SelectedDeviceName = pleer.DeviceList[this.setting.DeviceIndex];
                Properties.Settings.Default.SelectedFrameSize = pleer.ListVideoModes[this.pleer.ModeIndex];
            }
        }
    }
}
