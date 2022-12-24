using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WWWPOS.ErrorMessage;

namespace WWWPOS.ClientControl.ClientCart
{
    public partial class Form_ClientCart : Form
    {
        public Form_ClientCart()
        {
            InitializeComponent();
        }
                
        //Load cart total price
        public void LoadCartTotalPrice()
        {
        }
        //On load
        private void Form_ClientCart_Load(object sender, EventArgs e)
        {
            loadData Data = new loadData();
            Data.LoadCart(flPanel_ProductCart);
            LoadCartTotalPrice();
        }
        //Go to view all product
        private void btn_BrowseProduct_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form_ClientLandingPage clientForm = new Form_ClientLandingPage();
            clientForm.ShowDialog();
        }

        private void btn_Checkout_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form_ClientPay F_ClientPay = new Form_ClientPay();
            loadData data = new loadData();
            data.LoadTotalItems(F_ClientPay.flPanel_ProductTotal);

            F_ClientPay.lbl_TotalPrice.Text = "₱ " + data.LoadCartTotalPrice(F_ClientPay.lbl_TotalPrice.Text);

            F_ClientPay.ShowDialog();
        }
    }
}
