using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebCamCapture.Model;
using WebCamCapture.View;
using AForge.Video;
using AForge.Video.DirectShow;

namespace WebCamCapture.Presenter
{
    class Propertys
    {
        #region "Источник"
        /// <summary>
        /// список имен подключенных устройств
        /// </summary>
        protected List<string> DeviceNamesList { get; set; }
        /// <summary>
        /// Список имен режимов (размеров кадра 640x480)
        /// </summary>
        protected List<string> ModeNamesList { get; set; }
        /// <summary>
        /// Имя устройства из настроек
        /// </summary>
        protected string DeviceName { get; set; }
        /// <summary>
        /// Имя режима из настроек (размер кадра)
        /// </summary>
        protected string ModeName { get; set; }
        protected string SnapshotDir { get; set; }
        /// <summary>
        /// Идентификатор выбранного устройства. 
        /// </summary>
        protected int DeviceId { get; set; }
        protected int ModeId { get; set; }
        #endregion

        #region "Управление"
        protected ICurrentProperty ZoomRange { get; set; }
        protected ICurrentProperty FocusRange { get; set; }
        protected ICurrentProperty ExposureRange { get; set; }
        protected ICurrentProperty HorizontalRange { get; set; }
        protected ICurrentProperty VerticalRange { get; set; }


        protected ICurrentProperty Zoom { get; set; }
        protected ICurrentProperty Focus { get; set; }
        protected ICurrentProperty Exposure { get; set; }
        protected ICurrentProperty HorizontalPosition { get; set; }
        protected ICurrentProperty VerticalPosition { get; set; }
        #endregion
        
    }

    class SettingPresenter : Propertys
    {
        private readonly ISettingView settingForm;
        private readonly IPlayerModel player;
        //Список подключенных устройств
        private List<string> _deviceNameList;
        private List<string> _modesList;
        // идентификатор выбранного устройства
        private int _deviceId = -1;
        // идентификатор выбранного режима
        private int _modeId = -1;
        private bool _isReady = false;

        public bool IsReady { get => _isReady; set => _isReady = value; }
        
        public SettingPresenter(ISettingView setting, IPlayerModel player)
        {
            this.settingForm = setting;
            this.player = player;
            this.settingForm.DeviceIdChange += SettingForm_DeviceIdChange;
            this.settingForm.ModeIdChange += SettingForm_ModeIdChange;
            this.settingForm.ZoomChange += SettingForm_ZoomChange;
            this.settingForm.FocusChange += SettingForm_FocusChange;
            // имя устройства из сохраненак
            DeviceName = this.player.DeviceName;
            // размер кадра из сохраненак
            ModeName = this.player.FrameSize;
            this.settingForm.SnapshotFolder = Properties.Settings.Default.FileDir;

            this.Init();

            
                 
        }

        private bool Init()
        {   
            // инициализация списка подключенных устройств
            DeviceNamesList = player.GetDeviceNameList();

            // подключены ли устройства
            if (DeviceNamesList.Count > 0)
            {
                // получаем индекс устаройства _dev в списке подключенных устройств
                DeviceId = DeviceNamesList.IndexOf(DeviceName);
                // если устройство из сохраненок подклчено
                if (DeviceId == -1) return false;
                // инициализируем список поддерживаемых режимом устройстом _deviceId
                ModeNamesList = player.GetListVideoModes(DeviceId);
                // если устройство не поддерживает режимы, то выходим
                if (ModeNamesList.Count == 0) return false;
                // поддерживает ли устройстово _deviceId режим (mod) из сохраненок, если нет то _modesList.IndexOf(_mod) вернет -1. 
                ModeId = ModeNamesList.IndexOf(ModeName);

                // устройство из настроек подключено
                this.settingForm.ModesList = ModeNamesList.ToArray();

            }
            //return false;
            // если параметры для захвата установлены
            if (DeviceId != -1 && ModeId != -1)
            {
                this.settingForm.DeviceList = DeviceNamesList.ToArray();
                this.settingForm.ModesList = ModeNamesList.ToArray();
                this.settingForm.DeviceIndex = DeviceId;
                this.settingForm.ModeIndex = ModeId;
                //this.player.init(_deviceId,_modeId);
                this.player.DeviceIndex = _deviceId;
                this.player.ModeIndex = ModeId;
                // выставляем флаг в готовность
                this.IsReady = true;
                this.player.Start();
                //Run();
            }
            else
            {
                // не все готово, требуются настройки
                //this.settingForm.ShowDialog();
            }

            return false;
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


        #region ОТОБРАЗИТЬ ФОРМУ НАСТРОЙКИ

        /// <summary>
        /// Отобразить форму настройки
        /// </summary>
        internal void Show()
        {


            // Обновляем сведения об подключенных устройствах
            _deviceNameList = player.GetDeviceNameList();
            settingForm.DeviceList = _deviceNameList.ToArray();

            if (this.settingForm.ShowDialog() == DialogResult.OK)
            {
                DeviceId = _deviceId;
                ModeId = _modeId;
                // тест
                Run();
            }
            else
            {
                CencelRun();
            }

        }
        #endregion

        // обработчик события выбора устройства
        private void SettingForm_DeviceIdChange()
        {
            _deviceId = this.settingForm.DeviceIndex;
            _modesList = player.GetListVideoModes(_deviceId);
            settingForm.ModesList = _modesList.ToArray();
        }
        // обработчик события выбора режима
        private void SettingForm_ModeIdChange()
        {
            _modeId = this.settingForm.ModeIndex;
            this.Run();
        }


        #region ФОРМА ЗАКРЫВАЕТСЯ

        private void CencelRun()
        {
            this.Run();
        }
        private void Run()
        {
            // выбранно ли устройство и режим в форме настроек
            if (_modeId > -1 && _deviceId > -1)
            {
                // устройство и режим выбранны, передаем параметры захвата в модель
                // устанавливаем флаг isReady (готово) в true
                IsReady = true;
                // все готово, можно начинать захват
                //MessageBox.Show(_deviceId+" "+_modeId);
                this.player.DeviceIndex = _deviceId;
                this.player.ModeIndex = _modeId;
                this.player.Start();


                // Имя устройства и режим
                this.player.DeviceName = DeviceNamesList[_deviceId];
                this.player.FrameSize = ModeNamesList[_modeId];
            }
            else
            {
                IsReady = false;
            }
        }

        #endregion





        /// <summary>
        /// Текущие настройки устройств передаются в представление 
        /// </summary>
        private void SetCurrentSettingDevice()
        {
            #region Настройки камеры


            CameraControlFlags _flags;
            #region Настройки Масштаба

            int _zoom;
            this.player.GetZoom(out _zoom, out _flags);
            this.settingForm.ZoomValue = _zoom;
            #endregion

            #region Настройки фокуса
            int _focus;
            this.player.GetFocus(out _focus, out _flags);
            this.settingForm.FocusValue = _focus;
            #endregion


            #endregion
        }

        // обрботчик изменения Масштаб
        private void SettingForm_ZoomChange()
        {
            if (this.player.IsRunning) { this.player.SetZoom(this.settingForm.ZoomValue); }
        }
        // обрботчик изменения "Фокус"
        private void SettingForm_FocusChange()
        {
            if (this.player.IsRunning) { this.player.SetFocus(this.settingForm.FocusValue); }
            
        }

    }
}
