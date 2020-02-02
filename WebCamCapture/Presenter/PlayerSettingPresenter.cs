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
        private readonly ISettingView settingForm;
        private readonly IPlayer player;
        //Список подключенных устройств
        private List<string> _deviceNameList;
        private List<string> _modesList;
        // идентификатор выбранного устройства
        private int _deviceId = -1;
        // идентификатор выбранного режима
        private int _modeId = -1;

        public PlayerSettingPresenter(ISettingView setting, IPlayer player)
        {
            this.settingForm = setting;
            this.player = player;
            this.settingForm.DeviceIdChange += SettingForm_DeviceIdChange;
            this.settingForm.ModeIdChange += SettingForm_ModeIdChange;

            Reload();



            //this.setting.DeviceList = player.DeviceList.ToArray();
            //this.setting.SnapshotFolder = Properties.Settings.Default.FileDir;

            //if (!this.player.IsRunning)
            //{
            //    this.setting.ModesList = player.ListVideoModes.ToArray();

            //    this.setting.DeviceIndex = player.DeviceIndex;
            //    this.setting.ModeIndex = player.ModeIndex;
            //}
            //if (this.setting.ShowDialog() == DialogResult.OK)
            //{
            //    // если выбран другой режим
            //    if (this.setting.ModeIndex != this.player.ModeIndex)
            //    {
            //        this.player.Start(this.player.ListVideoModes[this.setting.DeviceIndex], this.player.ListVideoModes[this.setting.ModeIndex]);


            //    }
            //    // сохраняем путь к снимкам 
            //    Properties.Settings.Default.FileDir = this.setting.SnapshotFolder;
            //    Properties.Settings.Default.SelectedDeviceName = player.DeviceList[this.setting.DeviceIndex];
            //    Properties.Settings.Default.SelectedFrameSize = player.ListVideoModes[this.player.ModeIndex];
            //}
        }

        private void SettingForm_ModeIdChange()
        {
            _modeId = this.settingForm.ModeIndex;
        }

        private void SettingForm_DeviceIdChange()
        {
            _deviceId = this.settingForm.DeviceIndex;
            _modesList = player.GetListVideoModes(_deviceId);
            settingForm.ModesList = _modesList.ToArray();
        }



        /// <summary>
        /// Перезагрузка данных из модели при каждом паказе формы настройки
        /// </summary>
        internal void Reload()
        {
            _deviceNameList = player.GetDeviceNameList();
            settingForm.DeviceList = _deviceNameList.ToArray();
            settingForm.DeviceIndex = _deviceId;
        }
    }
}
