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
using WWWPOS.MessageFolder;

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
            panel_Menu.Visible = !panel_Menu.Visible;
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

            Class_LoadData Data = new Class_LoadData();
            Data.LoadCart(F_ClientCart.flPanel_ProductCart);

            if (F_ClientCart.flPanel_ProductCart.Controls.Count == 0)
            {
                UserControl_NoItemsCart UC_NoItemsCart = new UserControl_NoItemsCart();

                F_ClientCart.flPanel_ProductCart.Controls.Clear();
                F_ClientCart.flPanel_ProductCart.Controls.Add(UC_NoItemsCart);

                F_ClientCart.btn_Checkout.Enabled = false;
                F_ClientCart.btn_Checkout.BackColor = Color.White;
            }

            F_ClientCart.ShowDialog();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DataBase.isLogin = false;
            WWWPOS.Form_AdminHome.ActiveForm.Hide();
            DataBase.login.Show();
        }
    }
}
