using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WWWPOS.ClientControl;

namespace WWWPOS
{
    public partial class Form_ClientLandingPage : Form
    {
        public Form_ClientLandingPage()
        {
            InitializeComponent();
        }
        private void ClientPage_Load(object sender, EventArgs e)
        {
            UserControl_ClientViewProduct UC_ClientViewProduct = new UserControl_ClientViewProduct();

            this.panel_MainClient.Controls.Clear();
            this.panel_MainClient.Controls.Add(UC_ClientViewProduct);
            UC_ClientViewProduct.Dock = DockStyle.Fill;
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
