using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebCamCapture
{
    public partial class OrderForm : Form
    {
        string order; // заказ
        string rller; // ролик
        string action; // операция
        string user; // исполнитель
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(button1.DialogResult.ToString());

        }

    }
}
