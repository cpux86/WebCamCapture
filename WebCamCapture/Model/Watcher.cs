using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebCamCapture.Model
{
    interface IWatcher
    {
        event Action<string> FileCreation;

        void Run();
    }

    public class Watcher : IWatcher
    {
        // Событие возникает когда в наблюдаемом каталоге создан файл
        public event Action<string> FileCreation;
        // Путь отслеживания
        public string WatchPath { get => watcher.Path; set => watcher.Path = value; }

        readonly FileSystemWatcher watcher;
        public Watcher()
        {
            this.watcher = new FileSystemWatcher();
            // Устанавливаем в качествае отслеживаемого каталого по умолчанию корневой каталог программы
            this.watcher.Path = Application.StartupPath;

        }

        // Включаем отслеживание каталога
        public void Run()
        {
            watcher.Filter = "*.jpg";
            watcher.Created += Watcher_Created;
            //watcher.Deleted += Watcher_Created;
            watcher.EnableRaisingEvents = true;
            watcher.IncludeSubdirectories = true;
        }

        private void Watcher_Created(object sender, FileSystemEventArgs e)
        {
            FileCreation(e.FullPath);
        }
    }
}
