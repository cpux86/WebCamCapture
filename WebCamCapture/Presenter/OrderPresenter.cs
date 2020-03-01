using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCamCapture.View;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace WebCamCapture.Presenter
{
    [Serializable]
    class OrderAttributes
    {
        // Состояние
        public string[] RollerList { get; set; }
        public string[] OperationsList { get; set; }
        public string[] UsersList { get; set; }

    }

    class OrderPresenter
    {
        private string SelectedRoller => throw new NotImplementedException();
        private string SelectedOperation => throw new NotImplementedException();
        private string SelectedUser => throw new NotImplementedException();

        private string fileBin = "MyFile.bin";

        readonly private IOrderMainForm mainForm;
        OrderAttributes order;
        public OrderPresenter(IOrderMainForm mainForm)
        {
            this.mainForm = mainForm;
            this.mainForm.ShowOrderForm += ShowOrderForm;
            //order = new OrderAttributes()
            try
            {
                this.LoadAttributes();
            }
            catch (Exception)
            {

                order = new OrderAttributes();
            }
            mainForm.FormClosing += MainForm_FormClosing;
            
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.SaveAttributes();
        }

        #region Упрвление атрибутами Order
        // 
        private void LoadAttributes()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileBin, FileMode.Open, FileAccess.Read, FileShare.Read);
            order = (OrderAttributes)formatter.Deserialize(stream);
            stream.Close();
        }
        //
        private void SaveAttributes()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileBin, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, order);
            stream.Close();
        }
        #endregion

        private void ShowOrderForm()
        {
            IOrderForm orderForm = new OrderForm();
            #region Установить данные для формы
            //order.UsersList = new string[] { "Владимир","Мария"};
            orderForm.UsersList = order.UsersList;
            #endregion

            this.mainForm.User = "Каськов В.В";
            if (orderForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                #region Получить данные из формы

                #endregion
            }
        }
    }
}
