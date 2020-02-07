using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebCamCapture.View
{
    interface ISettingView
    {
        int DeviceIndex { get; set; }
        int ModeIndex { get; set; }
        string[] DeviceList { set; }
        string[] ModesList { set; }
        /// <summary>
        /// выбранно устройство в настройках
        /// </summary>
        event Action DeviceIdChange;
        /// <summary>
        /// Выбран режим в настройках
        /// </summary>
        event Action ModeIdChange;
        /// <summary>
        /// Клик по кнопке OK на форме настроек
        /// </summary>
        event Action BtnOkClick;
        // события "Масштаб"
        event Action ZoomChange;
        // событие "Фокус"
        event Action FocusChange;
        /// <summary>
        /// Путь к папке со снимкаи
        /// </summary>
        string SnapshotFolder { get; set; }
        string SnapshotFolderTextBox { set; }
        int ZoomValue { get; set; }
        int FocusValue { get; set; }
        DialogResult ShowDialog();
        void Close();
    }
}
