using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WWWPOS.SideBarControl.Inventory
{
    public partial class UserControlUpdateForm : Form
    {
        public UserControlUpdateForm()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_UpdateProduct_Click(object sender, EventArgs e)
        {
            DataBase DB = new DataBase();

            int productID = Int32.Parse(txtBox_ProductID.Text);
            double productPrice = Double.Parse(txtBox_ProductPrice.Text);
            int productStock = Int32.Parse(txtBox_ProductStocks.Text);

            DB.UpdateProducts(productID, cmb_ProductCategory.Text, txtBox_ProductName.Text, txtBox_ProductColor.Text, productPrice, productStock, cmb_ProductSize.Text, rtb_ProductDescription.Text);
            this.Close();
        }
    }
}
