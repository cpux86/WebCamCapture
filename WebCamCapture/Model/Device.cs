using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCamCapture.Model
{
    class Device
    {
        protected Device()
        {

        }
        private static Device instance;
        public static Device getInstance()
        {
            if (instance == null)
            {
                instance = new Device();
            }
            return instance;
        }
        static VideoCaptureDevice videoSource;
        public static string Moniker { get; set; }
        public static void Dev()
        {
            videoSource = new VideoCaptureDevice(Moniker);
        }
        /// <summary>
        /// Возращает список поддерживаемых размеров кадров
        /// </summary>
        /// <param name="dev">Идентификатор устройства</param>
        /// <returns></returns>
        public List<string> GetFrameSizeList()
        {
            //videoSource.Vi
            List<string> fSize = new List<string>();
            videoSource = new VideoCaptureDevice(Moniker);
            // инициализируем свойства устройства
            //this.PropertyRange();
            // поддерживаемые режимы работы камеры (разрешение)
            foreach (var s in videoSource.VideoCapabilities)
            {
                // формируем строку типа 640 x 480
                fSize.Add(String.Format("{0} x {1}", s.FrameSize.Width, s.FrameSize.Height));

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
        public ICurrentProperty CurrentZoom()
        {
            return this.GetCurrentPropertys(CameraControlProperty.Zoom);
            
        }
        /// <summary>
        /// Возвращает текущие настройки фокуса
        /// </summary>
        /// <returns></returns>
        public ICurrentProperty CurrentFocus()
        {
            return this.GetCurrentPropertys(CameraControlProperty.Focus);
        }
        /// <summary>
        /// Возвращает текущие настройки экспозиции
        /// </summary>
        /// <returns></returns>
        public ICurrentProperty CurrentExposure()
        {
            return this.GetCurrentPropertys(CameraControlProperty.Exposure);
        }
        /// <summary>
        /// Текущая позиция по горизонтали
        /// </summary>
        /// <returns></returns>
        public ICurrentProperty CurrentHorizontalPosition()
        {
            return this.GetCurrentPropertys(CameraControlProperty.Roll);
        }
        /// <summary>
        /// Текущая позиция по вертикали
        /// </summary>
        /// <returns></returns>
        public ICurrentProperty CurrentVerticalPosition()
        {
            return this.GetCurrentPropertys(CameraControlProperty.Tilt);
        }

        // Текущие свойства, универсальный метод
        private Property GetCurrentPropertys(CameraControlProperty _property)
        {
            int _value;
            CameraControlFlags _controlFlag;
            prop = new Model.Property();
            videoSource.GetCameraProperty(_property, out _value, out _controlFlag);
            prop.Value = _value;
            prop.ControlFlag = _controlFlag;
            return prop;
        }
        #endregion



        /// <summary>
        /// Обвертка для SetCameraProperty, Устанавливаем свойства для устройства
        /// </summary>
        /// <param name="_property"></param>
        /// <param name="_value"></param>
        /// <param name="_controlFlags"></param>
        public void SetProperty(CameraControlProperty _property, int _value, CameraControlFlags _controlFlags)
        {
            videoSource.SetCameraProperty(_property, _value,  _controlFlags);
        }

        // Диапазон звойств, уневерсальный метод
        private void PropertyRange(CameraControlProperty _property)
        {
            int _minValue;
            int _maxValue;
            int _stapSize;
            int _defValuse;
            CameraControlFlags _flags;
            try
            {
                videoSource.GetCameraPropertyRange(
                _property,
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
