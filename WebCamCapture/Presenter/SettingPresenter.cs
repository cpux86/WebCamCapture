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
        private SettingForm setting;
        private Pleer pleer;
        
        public SettingPresenter()
        {
            
        }

        public void Show(SettingForm setting, Pleer pleer)
        {
            this.setting = setting;
            this.pleer = pleer;

            this.setting.DeviceList = pleer.DeviceList.ToArray();
            setting.SettingOk += Setting_SettingOk;

            if (this.pleer.IsRunning)
            {
                this.setting.ModesList = pleer.ListVideoModes.ToArray();

                this.setting.DeviceIndex = pleer.DeviceIndex;
                this.setting.ModeIndex = pleer.ModeIndex;
            }

            this.setting.ShowDialog();

        }


        private void Setting_SettingOk()
        {
            // если выбран другой режим
            if (this.setting.ModeIndex != this.pleer.ModeIndex) {
                //System.Windows.Forms.MessageBox.Show("Test");
                this.pleer.Start(this.pleer.ListVideoModes[this.setting.DeviceIndex],this.pleer.ListVideoModes[this.setting.ModeIndex]);
                
            }
            this.setting.Close();


        }

        /// <summary>
        ///
        /// </summary>

    }
}
