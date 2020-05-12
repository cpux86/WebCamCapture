using System.Drawing;

namespace WebCamCapture.Model
{
    public interface ISnapshot
    {
        /// <summary>
        /// Текущий снимок
        /// </summary>
        Image Image { get; set; }
        /// <summary>
        /// Путь к файлу-снимку
        /// </summary>
        string FullPath { get; set; }
        /// <summary>
        /// Номер заказа
        /// </summary>
        string OrderNumber { get; set; }
        /// <summary>
        /// Дата создания снимка
        /// </summary>
        string DateCreated { get; set; }
        /// <summary>
        /// Номер ролика
        /// </summary>
        string Roller { get; set; }
        /// <summary>
        /// Текущий процесс
        /// </summary>
        string Process { get; set; }      
        /// <summary>
        /// Ф.И.О исполнителя
        /// </summary>
        string User { get; set; }
    }
}