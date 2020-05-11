using WebCamCapture.View;

namespace WebCamCapture.Presenter
{
    public class Order
    {
        /// <summary>
        /// Текущий номер заказа
        /// </summary>
        public static string OrderNumber { get; set; }
        /// <summary>
        /// Текущий номер ролика
        /// </summary>
        public static string Roller { get; set; }
        /// <summary>
        /// Текущий процесс
        /// </summary>
        public static string Process { get; set; }
        /// <summary>
        /// Текущий пользователь
        /// </summary>
        public static string User { get; set; }

        public string MyProperty { get; set; }

        /// <summary>
        /// Отобразить текущий заказ в главной форме 
        /// </summary>
        /// <param name="order"></param>
        public static void Show(IOrderMainForm order)
        {
            order.OrderNumber = OrderNumber;
            order.Roller = Roller;
            order.Process = Process;
            order.User = User;
        }
    }
}
