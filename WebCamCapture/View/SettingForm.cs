using System;
using System.Windows.Forms;

namespace WebCamCapture.View
{
    internal interface ISettingView
    {
        event Action DeviceIdChange;
        event Action ModeIdChange;
        /// <summary>
        /// Выбор каталога сохраниния снимков
        /// </summary>
        event Action<string> SnapshotDirChange;
        DialogResult ShowDialog();
        string[] DeviceList { set; }
        string[] ModesList { set; }
        int DeviceIndex { get; set; }
        int ModeIndex { get; set; }
        /// <summary>
        /// Каталог для сохранения снимков
        /// </summary>
        string SnapshotFolder { get; set; }
    }

    public partial class SettingForm : Form, ISettingView
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        public int DeviceIndex { get => deviceList.SelectedIndex; set => deviceList.SelectedIndex = value; }
        public int ModeIndex { get => modesList.SelectedIndex; set => modesList.SelectedIndex = value; }

        /// <summary>
        ///  выбранно устройство в настройках
        /// </summary>
        public event Action DeviceIdChange;
        /// <summary>
        ///  выбран режим в настройках
        /// </summary>
        public event Action ModeIdChange;
        public event Action<string> SnapshotDirChange;

        public string[] DeviceList
        {
            set
            {
                deviceList.Items.Clear();
                deviceList.Items.AddRange(value);
            }
        }
        public string[] ModesList
        {
            set
            {
                modesList.Items.Clear();
                modesList.Items.AddRange(value);
            }
        }
        /// <summary>
        /// Каталог для сохранения снимков
        /// </summary>
        public string SnapshotFolder
        {
            get => folderBrowserDialog1.SelectedPath;
            set
            {
                folderBrowserDialog1.SelectedPath = value;
                FileDirView.Text = value;
            }
        }
        public string SnapshotFolderTextBox { set => FileDirView.Text = value; }

        /// <summary>
        /// Обработчик щелчка по кнопке обзора для выбора каталога для хранения снимков
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DirOkBtn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                FileDirView.Text = folderBrowserDialog1.SelectedPath;
                this.SnapshotDirChange(folderBrowserDialog1.SelectedPath);
            }
        }
        // Выбор устройства
        private void deviceList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DeviceIdChange();
        }
        // Выбор режима захвата
        private void modesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModeIdChange();
        }

    }

}
