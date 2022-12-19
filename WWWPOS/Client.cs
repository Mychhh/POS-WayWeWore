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
        ClientControl.UserControl_TShirtProducts tShirtProducts = new ClientControl.UserControl_TShirtProducts();

        MenuControl.UserControl_Menu UC_Menu = new MenuControl.UserControl_Menu();
        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            loadData ld = new loadData();
            ld.LoadAllAvailableProducts(flowLayoutPanel);

        }

        private void btn_Short_Click(object sender, EventArgs e)
        {
        }

        private void btn_TShirt_Click(object sender, EventArgs e)
        {
           tShirtProducts.Dock = DockStyle.Fill;
        }

        private void btn_ViewCart_Click(object sender, EventArgs e)
        {
            
        }
              
        private void userSearch_Enter(object sender, EventArgs e)
        {
            txtBox_userSearch.Text = "";
        }

        private void userSearch_Leave(object sender, EventArgs e)
        {
            txtBox_userSearch.Text = "Search products";
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            panel_Menu.Controls.Clear();
            panel_Menu.Controls.Add(UC_Menu);
            UC_Menu.Dock = DockStyle.Fill;

            if (!UC_Menu.Visible)
            {
                UC_Menu.Show();
                panel_Menu.Size = new Size(214, 140);
                panel_Menu.Location = new Point(813, 41);
            }
            else if (UC_Menu.Visible)
            {
                UC_Menu.Hide();
                panel_Menu.Size = new Size(0, 0);
                panel_Menu.Location = new Point(859, 41);
            }
        }

    }
}
