using Accord.Video;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using WebCamCapture.Presenter;

namespace WebCamCapture.Model
{
    public class Snapshot : ISnapshot
    {
        /// <summary>
        /// Текущий снимок
        /// </summary>
        public Image Image { get; set; }
        /// <summary>
        /// Путь к файлу-снимку
        /// </summary>
        public string FullPath { get; set; }
        /// <summary>
        /// Номер заказа
        /// </summary>
        public string OrderNumber { get; set; }
        /// <summary>
        /// Дата создания снимка
        /// </summary>
        public string DateCreated { get; set; }
        /// <summary>
        /// Номер ролика
        /// </summary>
        public string Roller { get; set; }
        /// <summary>
        /// Текущий процесс
        /// </summary>
        public string Process { get; set; }
        /// <summary>
        /// Ф.И.О исполнителя
        /// </summary>
        public string User { get; set; }
    }

    public class FM : Devices
    {
        /// <summary>
        /// Имя файла-снимка
        /// </summary>
        private string _name;

        /// <summary>
        /// Новый снимок
        /// </summary>
        public event Action<ISnapshot> NewPhoto;


        #region API



        /// <summary>
        /// Создать снимок
        /// </summary>
        public void Create()
        {
            VideoSource.NewFrame += VideoSource_NewFrame;

        }

        Snapshot snapshot;
        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            snapshot = new Snapshot()
            {
                OrderNumber = Order.OrderNumber,
                DateCreated = DateTime.Now.ToString(),
                Roller = Order.Roller,
                Process = Order.Process,
                User = Order.User
            };
            //snapshot.OrderNumber = Order.OrderNumber;
            //snapshot.DateCreated = DateTime.Now.ToString();
            //snapshot.Roller = Order.Roller;
            //snapshot.Process = Order.Process;
            //snapshot.User = Order.User;

            this.Save((Bitmap)eventArgs.Frame);
            VideoSource.NewFrame -= VideoSource_NewFrame;
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
            snapshot.Image = img;
            // генерируем имя для файла
            _name = this.CreateFileName();
            // имя каталога для файла
            string folder = this.Validation(Order.OrderNumber);
            // корневая дериктория для хранения снимков, берется из настроек [D:\\папка со снимками\]
            string rootDir = Config.SnapshotDir;
            // путь к каталогу файлов [D:\\папка со снимками\номер заказа\]
            string path = String.Format("{0}\\{1}", rootDir, folder);
            // полный куть к файлу [D:\\папка со снимками\номер заказа\имя файла.jpg]
            string fullPath = String.Format("{0}\\{1}\\{2}", rootDir, folder, _name);
            
            // Текст поверх изображения
            string metadata = String.Format("{0} {1} {2} {3} {4}", Order.OrderNumber, snapshot.DateCreated, Order.Roller, Order.Process, Order.User);
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

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
                snapshot.FullPath = fullPath;
                // уведомляем о новом снимке               
                this.NewPhoto(snapshot);

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }

            

        }


    }
}
