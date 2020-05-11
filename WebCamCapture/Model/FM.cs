using Accord.Video;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using WebCamCapture.Presenter;

namespace WebCamCapture.Model
{
    public class Snapshot
    {
        /// <summary>
        /// Имя файла-снимка
        /// </summary>
        //public string Name { get; set; }
        public string FullPath { get; set; }

        public string OrderNumber { get; set; }
        public string DateCreated { get; set; }
        public string Roller { get; set; }
        public string Process { get; set; }
        public string User { get; set; }
    }

    public class FM : Devices
    {
        /// <summary>
        /// Имя файла-снимка
        /// </summary>
        public string Name { get; set; }
       // public Image Image { get; set; }

        /// <summary>
        /// Новый кадр
        /// </summary>
        public event Action<Image> NewPhoto;

        List<Snapshot> snapshotsList;

        public FM()
        {
            snapshotsList = new List<Snapshot>();
        }

        #region API



        /// <summary>
        /// Создать снимок
        /// </summary>
        public void Create()
        {
            VideoSource.NewFrame += VideoSource_NewFrame;

        }

        public Snapshot GetSnapshot(int index)
        {
            if (snapshotsList.Count >= index)
            {
                return snapshotsList[index];
            }
            return null;
        }

        public List<Snapshot> GetList()
        {
            return snapshotsList;
        }

        Snapshot snapshot;
        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            snapshot = new Snapshot();
            snapshot.OrderNumber = Order.OrderNumber;
            snapshot.DateCreated = DateTime.Now.ToString();
            snapshot.Roller = Order.Roller;
            snapshot.Process = Order.Process;
            snapshot.User = Order.User;

            this.Save((Bitmap)eventArgs.Frame);
            VideoSource.NewFrame -= VideoSource_NewFrame;

            snapshotsList.Add(snapshot);
        }

        #endregion;




        /// <summary>
        /// Создает уникальное имя для данного снимка, с текущими параметрами заказа
        /// </summary>
        /// <returns>уникальная строка для снимка</returns>
        private string CreateFileName()
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
            
            // Текст поверх изображения
            string metadata = String.Format("{0} {1} {2} {3} {4}", Order.OrderNumber, snapshot.DateCreated, Order.Roller, Order.Process, Order.User);
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                // уведомляем о новом снимке
                this.NewPhoto(img);
                // разрешен ли водяной текст
                if (Config.WaterText)
                {
                    Config.WaterText = true;
                    Graphics g = Graphics.FromImage(img);
                    g.DrawString(metadata, Config.Font, new SolidBrush(Color.White), 15, img.Height - 50);
                    g.Dispose();
                }
                // сохраняем снимок 
                img.Save(fullPath, System.Drawing.Imaging.ImageFormat.Jpeg);

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }

            snapshot.FullPath = fullPath;

        }


    }
}
