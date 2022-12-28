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
    public partial class Form_Client_Order_Checkout : Form
    {
        //ClientControl.UserControl_ViewCart viewCart = new ClientControl.UserControl_ViewCart();

        MenuControl.UserControl_Menu UC_Menu = new MenuControl.UserControl_Menu();
        public Form_Client_Order_Checkout()
        {
            InitializeComponent();
        }

        private void Client_Order_Checkout_Load(object sender, EventArgs e)
        {
            //PanelControl.Controls.Clear();
            //PanelControl.Controls.Add(viewCart);
            //viewCart.Dock = DockStyle.Fill;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Close();
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
