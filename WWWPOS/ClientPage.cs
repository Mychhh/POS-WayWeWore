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

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            MenuControl.UserControl_Menu UC_Menu = new MenuControl.UserControl_Menu();

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
