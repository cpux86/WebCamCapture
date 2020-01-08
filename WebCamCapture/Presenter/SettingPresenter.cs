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
            
        }


        private void Setting_SettingOk()
        {
            System.Windows.Forms.MessageBox.Show("OK");
        }
    }
}
