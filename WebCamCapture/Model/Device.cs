using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.Video.DirectShow;

using System.Drawing;

namespace WebCamCapture.Model
{
    class Devices
    {
        private FilterInfoCollection videoDevices;

        private Device _device;

        public Device SelectedDevice(int devId)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (_device == null) _device = new Device();
            
            if (videoDevices.Count != 0)
            {
                _device.videoSource  = new VideoCaptureDevice(videoDevices[devId].MonikerString);
            }
            return _device;
        }

        /// <summary>
        /// Взращает список имен подключенных устройств
        /// </summary>
        /// <returns></returns>
        public List<string> GetDevicesNameList()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            // заполняем список именами подклюен
            List<string> list = new List<string>();
            foreach (FilterInfo device in videoDevices)
            {
                list.Add(device.Name);
            }
            return list;
        }
    }


    class Device
    {
        public VideoCaptureDevice videoSource;
        /// <summary>
        /// Возращает список поддерживаемых размеров кадров
        /// </summary>
        /// <param name="dev">Идентификатор устройства</param>
        /// <returns></returns>
        public List<string> GetFrameSizeList()
        {
            List<string> fSize = new List<string>();
            // инициализируем свойства устройства
            //this.PropertyRange();
            // поддерживаемые режимы работы камеры (разрешение)
            foreach (var s in videoSource.VideoCapabilities)
            {

                // формируем строку типа 640 x 480
                fSize.Add(String.Format("{0} x {1}, {2} fps, {3} Bit", s.FrameSize.Width, s.FrameSize.Height, s.MaximumFrameRate, s.BitCount));

            }
            return fSize;
        }

        #region Настройки устройства

        #region Получаем диапазон значений и значение по умолчанию
        private Model.Property prop;

        /// <summary>
        /// Возвращает диапазон Масштабирования
        /// </summary>
        /// <returns></returns>
        public IPropertyRange GetZoomRange()
        {
            prop = new Model.Property();
            this.PropertyRange(CameraControlProperty.Zoom);
            return prop;
        }
        /// <summary>
        /// Возвращает диапазон Фокуса
        /// </summary>
        /// <returns></returns>
        public IPropertyRange GetFocusRange()
        {
            prop = new Model.Property();
            this.PropertyRange(CameraControlProperty.Focus);
            return prop;
        }
        /// <summary>
        /// Возвращает диапазон Экспозиции
        /// </summary>
        /// <returns></returns>
        public IPropertyRange GetExposureRange()
        {
            prop = new Model.Property();
            this.PropertyRange(CameraControlProperty.Exposure);
            return prop;
        }
        ///Возвращает диапазон по горизонтали
        public IPropertyRange GetHorizontalRange()
        {
            prop = new Model.Property();
            this.PropertyRange(CameraControlProperty.Roll);
            return prop;
        }
        ///Возвращает диапазон по вертикали
        public IPropertyRange GetVerticalRange()
        {
            prop = new Model.Property();
            this.PropertyRange(CameraControlProperty.Tilt);
            return prop;
        }

        #endregion

        #region Получают текущие настройки свойства камеры.
        /// <summary>
        /// Возвращает текущие настройки масштаба
        /// </summary>
        /// <returns></returns>
        public ICurrentProperty GetZoom()
        {
            videoSource.DisplayPropertyPage(IntPtr.Zero);
            //videoSource.DisplayCrossbarPropertyPage(IntPtr.Zero);
            return this.GetCurrentPropertys(CameraControlProperty.Zoom);

        }
        /// <summary>
        /// Возвращает текущие настройки фокуса
        /// </summary>
        /// <returns></returns>
        public ICurrentProperty GetFocus()
        {
            return this.GetCurrentPropertys(CameraControlProperty.Focus);
        }
        /// <summary>
        /// Возвращает текущие настройки экспозиции
        /// </summary>
        /// <returns></returns>
        public ICurrentProperty GetExposure()
        {
            return this.GetCurrentPropertys(CameraControlProperty.Exposure);
        }
        /// <summary>
        /// Текущая позиция по горизонтали
        /// </summary>
        /// <returns></returns>
        public ICurrentProperty GetHorizontalPosition()
        {
            return this.GetCurrentPropertys(CameraControlProperty.Roll);
        }
        /// <summary>
        /// Текущая позиция по вертикали
        /// </summary>
        /// <returns></returns>
        public ICurrentProperty GetVerticalPosition()
        {
            return this.GetCurrentPropertys(CameraControlProperty.Tilt);
        }

        // Текущие свойства, универсальный метод
        private Property GetCurrentPropertys(CameraControlProperty property)
        {
            int _value;
            CameraControlFlags _controlFlag;
            prop = new Model.Property();
            videoSource.GetCameraProperty(property, out _value, out _controlFlag);
            prop.Value = _value;
            prop.ControlFlag = _controlFlag;
            return prop;
        }
        #endregion



        /// <summary>
        /// Обвертка для SetCameraProperty, Устанавливаем свойства для устройства
        /// </summary>
        /// <param name="property"></param>
        /// <param name="value"></param>
        /// <param name="controlFlags"></param>
        public void SetProperty(CameraControlProperty property, int value, CameraControlFlags controlFlags)
        {
            videoSource.SetCameraProperty(property, value, controlFlags);
        }

        // Диапазон звойств, уневерсальный метод
        private void PropertyRange(CameraControlProperty property)
        {
            int _minValue;
            int _maxValue;
            int _stapSize;
            int _defValuse;
            CameraControlFlags _flags;
            try
            {
                videoSource.GetCameraPropertyRange(
                property,
                out _minValue,
                out _maxValue,
                out _stapSize,
                out _defValuse,
                out _flags);

                prop.MinValue = _minValue;
                prop.MaxValue = _maxValue;
                prop.StapSize = _stapSize;
                prop.DefaultValue = _defValuse;
                prop.ControlFlag = _flags;
            }
            catch (NotSupportedException noSupp)
            {
                System.Windows.Forms.MessageBox.Show(noSupp.Message);
            }
        }
        #endregion

    }

    public class Property : ICurrentProperty, IPropertyRange
    {
        public int MinValue { get; set; }
        public int MaxValue { get; set; }
        public int Value { get; set; }
        public int StapSize { get; set; }
        public int DefaultValue { get; set; }
        public CameraControlFlags ControlFlag { get; set; }
    }
    // Диапозон свойств
    public interface IPropertyRange
    {
        int MinValue { get; }
        int MaxValue { get; }
        /// <summary>
        /// Размер шага
        /// </summary>
        int StapSize { get; }
        /// <summary>
        /// Значение по умолчанию
        /// </summary>
        int DefaultValue { get; }
        CameraControlFlags ControlFlag { get; }
    }

    public interface ICurrentProperty
    {
        int Value { get; set; }
        /// <summary>
        /// Флаг Auto
        /// </summary>
        CameraControlFlags ControlFlag { get; set; }
    }
}
