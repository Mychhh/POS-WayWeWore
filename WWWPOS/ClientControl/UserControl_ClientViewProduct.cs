using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WWWPOS.ClientControl
{
    public partial class UserControl_ClientViewProduct : UserControl
    {
        public UserControl_ClientViewProduct()
        {
            InitializeComponent();
        }
        //On load view all product
        private void UserControl_ClientViewProduct_Load(object sender, EventArgs e)
        {
            this.flowLayoutPanel.Controls.Clear();

            loadData ld = new loadData();
            ld.LoadAllAvailableProducts(this.flowLayoutPanel);

        }
        //OnClick view all product
        private void btn_AllProducts_Click_1(object sender, EventArgs e)
        {
            this.flowLayoutPanel.Controls.Clear();
            loadData ld = new loadData();
            ld.LoadAllAvailableProducts(this.flowLayoutPanel);
        }
        //OnClick view all Tshirt 
        private void btn_TShirt_Click_1(object sender, EventArgs e)
        {
            this.flowLayoutPanel.Controls.Clear();
            loadData ld = new loadData();
            ld.LoadAllTshirtProducts(this.flowLayoutPanel);
        }
        //OnClick view all Short
        private void btn_Short_Click_1(object sender, EventArgs e)
        {
            this.flowLayoutPanel.Controls.Clear();
            loadData ld = new loadData();
            ld.LoadAllShortProducts(this.flowLayoutPanel);
        }
        //OnClick View Cart
        private void btn_ViewCart_Click_1(object sender, EventArgs e)
        {
            Form_ClientLandingPage clientForm = new Form_ClientLandingPage();
            UserControl_ClientCart UC_ClientCart = new UserControl_ClientCart();

            clientForm.panel_MainClient.Controls.Clear();
            clientForm.panel_MainClient.Controls.Add(UC_ClientCart);
            UC_ClientCart.Dock = DockStyle.Fill;
        }

    }
}
