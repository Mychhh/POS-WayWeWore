using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WWWPOS.SideBarControl.Inventory;

namespace WWWPOS.SideBarControl.Products
{
    public partial class UserControl_Delete : UserControl
    {
        public UserControl_Delete(int productID, string productCategory, string productName, double productPrice, int productStock, string productColor, string productSize, string productDescription, Image productImage)
        {
            InitializeComponent();

            cmb_ProductColor.Items.Add(productColor);
            cmb_ProductSize.Items.Add(productSize);

            ID = productID;
            Price = productPrice;
            Stock = lbl_ProductStock;
            Color = productColor;
            productsSize = productSize;
            Descriptions = productDescription;
            Pic = image;
        }
        public int ID {
            get => int.Parse(product_ID.Text);
            set => product_ID.Text = value + "";
        }
        public string Descriptions
        {
            get => lbl_ProductDescription.Text;
            set => lbl_ProductDescription.Text = value;
        }
        public double Price
        {
            get => Double.Parse(lbl_ProductPrice.Text);
            set => lbl_ProductPrice.Text = value + "";
        }
        public int Stock
        {
            get => int.Parse(lbl_ProductStock.Text);
            set => lbl_ProductStock.Text = value + "";
        }
        public string Color
        {
            get => cmb_ProductColor.Text;
            set => cmb_ProductColor.Text = value;
        }
        public string productsSize
        {
            get => cmb_ProductSize.Text;
            set => cmb_ProductSize.Text = value + "";
        }
        public Image Pic
        {
            get => picbox_ProductImage.Image;
            set => picbox_ProductImage.Image = value;
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DataBase DB = new DataBase();

            DB.WarningMessage("Do you really want to delete this product?");

            if (DataBase.message == "continue")
            {
                DB.SetStatusProducts("Inactive", Int32.Parse(product_ID.Text));
                DataBase.message = "";
                this.Dispose(true);
            }
        }
    }
}
