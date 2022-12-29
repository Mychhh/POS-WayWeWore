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
using WWWPOS.ClientControl.ClientCart;
using WWWPOS.ClientControl.Products;

namespace WWWPOS
{
    public partial class Form_ClientLandingPage : Form
    {
        public Form_ClientLandingPage()
        {
            InitializeComponent();
        }
        //method to load particular product
        private void ViewAllAvailableProductMethod(string productView)
        {
            this.flPanel_ViewProduct.Controls.Clear();
            Class_LoadData loadData = new Class_LoadData();
            loadData.LoadAllAvailableProducts(this.flPanel_ViewProduct, productView );
        }

        //On load
        private void ClientPage_Load(object sender, EventArgs e)
        {
            ViewAllAvailableProductMethod("AllProduct");
        }
        //Logout thingy
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
        //All Product
        private void btn_AllProducts_Click(object sender, EventArgs e)
        {
            ViewAllAvailableProductMethod("AllProduct");
        }
        //Tshirt Product
        private void btn_TShirt_Click(object sender, EventArgs e)
        {
            ViewAllAvailableProductMethod("TshirtProduct");

        }
        //Short Product
        private void btn_Short_Click(object sender, EventArgs e)
        {
            ViewAllAvailableProductMethod("ShortProduct");
        }
        //View Cart
        private void btn_ViewCart_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form_ClientCart F_ClientCart = new Form_ClientCart();
                        
            F_ClientCart.ShowDialog();
        }

    }
}
