using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCamCapture.Model;
using WebCamCapture.View;

namespace WebCamCapture.Presenter
{
    class SettingPresenter
    {
        private SettingForm setting;
        private Pleer pleer;
       
        public SettingPresenter(SettingForm setting, Pleer pleer)
        {
            this.setting = setting;
            this.pleer = pleer;
            this.setting.SettingOk += Setting_SettingOk;

            this.setting.DeviceList = pleer.DeviceList.ToArray();
            
            
            if (this.pleer.IsRunning)
            {
                this.setting.ModesList = pleer.ListVideoModes.ToArray();

                this.setting.DeviceIndex = pleer.DeviceIndex;
                this.setting.ModeIndex = pleer.ModeIndex;
            }

        }


        private void Setting_SettingOk()
        {
            if (this.setting.ModeIndex != this.pleer.ModeIndex) System.Windows.Forms.MessageBox.Show("Test");
            this.setting.Close();
            
            
        }
    }
}
