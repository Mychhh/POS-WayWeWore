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
            F_ClientCart.ShowDialog();
        }

        private void Form_ClientPay_Load(object sender, EventArgs e)
        {
            loadData data = new loadData();
            data.LoadTotalItems(this.flPanel_ProductTotal);

            lbl_TotalPrice.Text = "₱ " + data.LoadCartTotalPrice(lbl_TotalPrice.Text);
        }

        private void lbl_TotalPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
