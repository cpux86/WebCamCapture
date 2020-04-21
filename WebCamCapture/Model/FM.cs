using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

using WebCamCapture.Presenter;
using AForge.Video;
using System.Windows.Forms.VisualStyles;

namespace WebCamCapture.Model
{
    public interface ISnapshot
    {
        void CreateSnapshot();
        event Action<string> NewImage;
    }

    public class FM : Devices
    {
        public string Name { get; set; }
        public Image Image { get; set; }
        public event Action<string> NewImage;

        public FM()
        {
            if (!Directory.Exists(path)) {
                this.Monitor();
                this.WatcherPath("\\");
            }
            
        }

        // путь к отслеживаемому каталогу
        private string path = Config.SnapshotDir;

        /// <summary>
        /// Путь отслеживания изменеия содержимого
        /// </summary>
        /// <param name="newPath"></param>
        public void WatcherPath(string newPath)
        {
            watcher.Path = newPath;
        }

        FileSystemWatcher watcher;
        /// <summary>
        /// Отслеживает содержимого каталога
        /// </summary>
        public void Monitor()
        {
            watcher = new FileSystemWatcher();

            watcher.Path = path;
            watcher.Filter = "*.jpg";
            watcher.Created += Watcher_Created;
            //watcher.Deleted += Watcher_Created;
            watcher.EnableRaisingEvents = true;
            watcher.IncludeSubdirectories = true;
            
        }
        // Обработчик события изменения содержимого каталога
        public void Watcher_Created(object sender, FileSystemEventArgs e)
        {
            this.NewImage(e.FullPath);
        }

        /// <summary>
        /// Создает уникальное имя для данного снимка, с текущими параметрами заказа
        /// </summary>
        /// <returns>уникальная строка для снимка</returns>
        public string CreateFileName()
        {
            string fileName;
            string dateTime = DateTime.Now.ToString("dd.MM.yyyy_HH.mm.ss.ffff");

            // [номер заказа][дата, время+мсек][ролик][процесс][исполнитель]
            fileName = String.Format(
                "{0}_{1}_{2}_{3}_{4}.jpg",
                Order.OrderNumber,
                dateTime,
                Order.Roller,
                Order.Process,
                Order.User);
            return Validation(fileName);
        }
        /// <summary>
        /// Заменяет в переданной строке все не допустимые символы на "-"
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private string Validation(string s)
        {
            if (s == null) return s;
            // Массив не допустимых символов
            string[] symbols = new string[] { "/", ":", "+" };

            foreach (string symbol in symbols)
            {
                s = s.Replace(symbol, "-");
            }
            return s;
        }

        private void Save(Image img)
        {
            // генерируем имя для файла
            this.Name = this.CreateFileName();
            // имя каталога для файла
            string folder = this.Validation(Order.OrderNumber);
            // корневая дериктория для хранения снимков, берется из настроек [D:\\папка со снимками\]
            string rootDir = Config.SnapshotDir;
            // путь к каталогу файлов [D:\\папка со снимками\номер заказа\]
            string path = String.Format("{0}\\{1}", rootDir, folder);
            // полный куть к файлу [D:\\папка со снимками\номер заказа\имя файла.jpg]
            string fullPath = String.Format("{0}\\{1}\\{2}", rootDir, folder, this.Name);
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                img.Save(fullPath, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch (Exception)
            {

                throw;
            }

           
           
        }

        #region API

        

        /// <summary>
        /// Создать снимок
        /// </summary>
        public void CreateSnapshot()
        {
            VideoSource.NewFrame += VideoSource_NewFrame;
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            this.Save((Bitmap)eventArgs.Frame);
            VideoSource.NewFrame -= VideoSource_NewFrame;
        }

        #endregion
    }
}
