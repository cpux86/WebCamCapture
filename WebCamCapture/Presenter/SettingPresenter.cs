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
        private readonly ISettingView settingForm;
        private readonly IPlayer player;
        //Список подключенных устройств
        private List<string> _deviceNameList;
        private List<string> _modesList;
        // идентификатор выбранного устройства
        private int _deviceId = -1;
        // идентификатор выбранного режима
        private int _modeId = -1;
        private bool _isReady = false;

        public bool IsReady { get => _isReady; set => _isReady = value; }

        public SettingPresenter(ISettingView setting, IPlayer player)
        {
            this.settingForm = setting;
            this.player = player;
            this.settingForm.DeviceIdChange += SettingForm_DeviceIdChange;
            this.settingForm.ModeIdChange += SettingForm_ModeIdChange;
            this.settingForm.BtnOkClick += SettingForm_BtnOkClick;
            // имя устройства из сохраненак
            string _dev = this.player.DeviceName;
            // размер кадра из сохраненак
            string _mod = this.player.FrameSize;
            // инициализация списка подключенных устройств
            _deviceNameList = player.GetDeviceNameList();
            // подключены ли устройства
            if (_deviceNameList.Count > 0)
            {
                // получаем индекс устаройства _dev в списке подключенных устройств
                _deviceId = _deviceNameList.IndexOf(_dev);
                // если устройство из сохраненок подклчено
                if (_deviceId != -1) {
                    // инициализируем список поддерживаемых режимом устройстом _deviceId
                    _modesList = player.GetListVideoModes(_deviceId);
                    // поддерживает ли устройстово _deviceId режим (mod) из сохраненок, если нет то _modesList.IndexOf(_mod) вернет -1. 
                    _modeId = _modesList.IndexOf(_mod);
                }              

            }
            // если параметры для захвата установлены
            if (_deviceId != -1 || _modeId != -1)
            {
                this.settingForm.DeviceList = _deviceNameList.ToArray();
                this.settingForm.ModesList = _modesList.ToArray();
                this.settingForm.DeviceIndex = _deviceId;
                this.settingForm.ModeIndex = _modeId;
                //this.player.init(_deviceId,_modeId);
                this.player.DeviceIndex = _deviceId;
                this.player.ModeIndex = _modeId;
                // выставляем флаг в готовность
                this.IsReady = true;
                this.player.Start();
            }
            else
            {
                // не все готово, требуются настройки
                this.settingForm.ShowDialog();
            }


            //    }
            //    // сохраняем путь к снимкам 
            //    Properties.Settings.Default.FileDir = this.setting.SnapshotFolder;
            //    Properties.Settings.Default.SelectedDeviceName = player.DeviceList[this.setting.DeviceIndex];
            //    Properties.Settings.Default.SelectedFrameSize = player.ListVideoModes[this.player.ModeIndex];
            //}
            
        }

        /// <summary>
        /// получаем индекс выбранного элемента по его имени, если элемент не обнаружен то возращаем 0.
        /// </summary>
        /// <param name="list">список где искать</param>
        /// <param name="name">что искать в списке</param>
        /// <returns></returns>
        public int GetIndexByName(List<string> list, string name)
        {
            return list.IndexOf(name) != -1 ? list.IndexOf(name) : 0;
        }
        // Обработчик клика по кнопке OK в форме настройки
        private void SettingForm_BtnOkClick()
        {
            // выбранно ли устройство и режим в форме настроек
            if (_modeId != -1 && _deviceId != -1)
            {
                // устройство и режим выбранны, передаем параметры захвата в модель
                // устанавливаем флаг isReady (готово) в true
                IsReady = true;
                // все готово, можно начинать захват
                //MessageBox.Show(_deviceId+" "+_modeId);
                this.player.DeviceIndex = _deviceId;
                this.player.ModeIndex = _modeId;
                this.player.Start();
            }
            else {
                IsReady = false;
            }
            
        }

        // обработчик события выбора режима
        private void SettingForm_ModeIdChange()
        {
            _modeId = this.settingForm.ModeIndex;
        }
        // обработчик события выбора устройства
        private void SettingForm_DeviceIdChange()
        {
            _deviceId = this.settingForm.DeviceIndex;
            _modesList = player.GetListVideoModes(_deviceId);
            settingForm.ModesList = _modesList.ToArray();
        }



        /// <summary>
        /// Отобразить форму настройки
        /// </summary>
        internal void Show()
        {
            //settingForm.DeviceList = _deviceNameList.ToArray();
            //List<string> _newDevList = player.GetDeviceNameList();
            List<string> _newDevList;
            _newDevList = _deviceNameList;
            // изменилься ли список подключенных устройств
            if (!_deviceNameList.SequenceEqual<string>(_newDevList))
            {
                _deviceNameList = _newDevList;
                // обновляем список устройств представлении "настройки"
                this.settingForm.DeviceList = _deviceNameList.ToArray();
                // 
                this.settingForm.DeviceIndex = this._deviceId;
            }
                      
            if (_deviceNameList.Count > 0)
            {
                // если обнавленный список не пуст
                settingForm.DeviceList = _deviceNameList.ToArray();
                settingForm.DeviceIndex = _deviceId;
            }
            else
            {
                // если обновленный список пуст
                settingForm.DeviceList = _deviceNameList.ToArray();
                // сбрасывае идентификатор
                _deviceId = -1;
            }
  
            this.settingForm.ShowDialog();
        }
        
    }
}
