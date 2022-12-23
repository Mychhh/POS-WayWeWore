using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WWWPOS.ClientControl.ClientCart
{
    public partial class Form_ClientCart : Form
    {
        public Form_ClientCart()
        {
            InitializeComponent();
        }

        public string TotalCart
        {
            get => lbl_TotalCart.Text;
            set => lbl_TotalCart.Text = "₱ " + value;
        }
        
        //Load cart total price
        public void LoadCartTotalPrice()
        {
            loadData Data = new loadData();
            TotalCart = Data.LoadCartTotalPrice(TotalCart);
        }
        //On load
        private void Form_ClientCart_Load(object sender, EventArgs e)
        {
            loadData Data = new loadData();
            Data.LoadCart(flPanel_ProductCart);
            LoadCartTotalPrice();
        }

        private void btn_BrowseProduct_Click(object sender, EventArgs e)
        {
            this.Close();

            Form_ClientLandingPage clientForm = new Form_ClientLandingPage();
            clientForm.ShowDialog();
        }

    }
}
