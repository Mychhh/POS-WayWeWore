using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WWWPOS.ClientControl.Products;

namespace WWWPOS.ClientControl.ClientCart
{
    public partial class Form_ClientPay : Form
    {
        public Form_ClientPay()
        {
            InitializeComponent();
        }

        private void btn_BrowseProduct_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form_ClientCart F_ClientCart = new Form_ClientCart();

            Class_LoadData Data = new Class_LoadData();
            Data.LoadCart(F_ClientCart.flPanel_ProductCart);

            F_ClientCart.ShowDialog();
        }
        private void btn_GoToProducts_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form_ClientLandingPage F_ClientLandingPage = new Form_ClientLandingPage();
            F_ClientLandingPage.ShowDialog();
        }
        private void Form_ClientPay_Load(object sender, EventArgs e)
        {
        }
        private void lbl_TotalPrice_Click(object sender, EventArgs e)
        {

        }
        private void btn_Pay_Click(object sender, EventArgs e)
        {
            DataBase DB = new DataBase();
            DB.PlaceOrder();
            DB.OrdersTableInsertData();
            DB.DeletesTheCartPending();

            this.Hide();
            Form_ClientLandingPage F_ClientLandingPage = new Form_ClientLandingPage();
            F_ClientLandingPage.ShowDialog();

        }
    }
}
