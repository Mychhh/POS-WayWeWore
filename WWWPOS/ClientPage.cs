using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WWWPOS
{
    public partial class ClientPage : Form
    {
        public ClientPage()
        {
            InitializeComponent();
        }

        private void ClientPage_Load(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            loadData ld = new loadData();
            ld.LoadAllAvailableProducts(flowLayoutPanel);
        }

        private void btn_AllProducts_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            loadData ld = new loadData();
            ld.LoadAllAvailableProducts(flowLayoutPanel);
        }
        private void btn_TShirt_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            loadData ld = new loadData();
            ld.LoadAllTshirtProducts(flowLayoutPanel);
        }
        private void btn_Short_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            loadData ld = new loadData();
            ld.LoadAllShortProducts(flowLayoutPanel);
        }

        private void btn_ViewCart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Client_Order_Checkout client = new Client_Order_Checkout();
            client.ShowDialog();
        }
    }
}
