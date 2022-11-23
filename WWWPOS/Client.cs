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
    public partial class Client : Form
    {
        ClientControl.UserControl_AllProducts allProducts = new ClientControl.UserControl_AllProducts();
        ClientControl.UserControl_Shorts shortProducts = new ClientControl.UserControl_Shorts();
        ClientControl.UserControl_TShirtProducts tShirtProducts = new ClientControl.UserControl_TShirtProducts();
       
        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            clientPanel.Controls.Add(allProducts);
            allProducts.Dock = DockStyle.Fill;

            
        }

        private void btn_Short_Click(object sender, EventArgs e)
        {
            clientPanel.Controls.Clear();
            clientPanel.Controls.Add(shortProducts);
            shortProducts.Dock = DockStyle.Fill;
        }

        private void btn_TShirt_Click(object sender, EventArgs e)
        {
            clientPanel.Controls.Clear();
            clientPanel.Controls.Add(tShirtProducts);
           tShirtProducts.Dock = DockStyle.Fill;
        }

        private void btn_ViewCart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Client_Order_Checkout client = new Client_Order_Checkout();
            client.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clientPanel.Controls.Clear();
            clientPanel.Controls.Add(allProducts);
            allProducts.Dock = DockStyle.Fill;

        }
      
        private void userSearch_Enter(object sender, EventArgs e)
        {
            userSearch.Text = "";
        }

        private void userSearch_Leave(object sender, EventArgs e)
        {
            userSearch.Text = "Search products";
        }
    }
}
