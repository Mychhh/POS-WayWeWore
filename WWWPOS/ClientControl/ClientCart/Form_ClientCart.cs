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
using WWWPOS.ErrorMessage;
using WWWPOS.MessageFolder;

namespace WWWPOS.ClientControl.ClientCart
{
    public partial class Form_ClientCart : Form
    {
        public Form_ClientCart()
        {
            InitializeComponent();
        }
                
        //On load
        private void Form_ClientCart_Load(object sender, EventArgs e)
        {
        }
        private void btn_BrowseProduct_Click(object sender, EventArgs e)
        {
            Form_ClientCart.ActiveForm.Dispose();

            Form_ClientLandingPage clientForm = new Form_ClientLandingPage();
            clientForm.ShowDialog();
        }

        private void btn_Checkout_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form_ClientPay F_ClientPay = new Form_ClientPay();
            Class_LoadData data = new Class_LoadData();
            data.LoadTotalItems(F_ClientPay.flPanel_ProductTotal);

            F_ClientPay.lbl_TotalPrice.Text = "₱ " + data.LoadCartTotalPrice(F_ClientPay.lbl_TotalPrice.Text);

            F_ClientPay.ShowDialog();
        }
    }
}
