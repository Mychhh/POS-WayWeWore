using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Markup;
using System.Windows.Media;
using WWWPOS.ErrorMessage;

namespace WWWPOS.ClientControl.Products
{
    public partial class UserControl_ProductCart : UserControl
    {
        public UserControl_ProductCart(int cartID, int userid, int productID, Image productImage, double productPrice, int productQuantity, int productTotal, int productStock, string productDescriptions, string productSize, string productColor, string productCategory)
        {
            InitializeComponent();
            UserID = userid;
            CartID = cartID;
            ProductID = productID;
            ProductImage = productImage;
            ProductPrice  = productPrice;
            ProductQuantity = productQuantity;
            ProductTotal = productTotal;
            ProductStocks = productStock;
            ProductDescriptions = productDescriptions;
            ProductSize = productSize;
            ProductColor = productColor;
            ProductCategory = productCategory;
        }
        public int CartID { get; set; }
        public int UserID { get; set; }
        public int ProductID { get; set; }
        public int ProductStocks { get; set; }
        public int ProductTotal { get; set; }
        public Image ProductImage
        {
            get => picBox_ProductPicture.Image;
            set => picBox_ProductPicture.Image = value;
        }
        public double ProductPrice
        {
            get => Double.Parse(lbl_ProductPrice.Text);
            set => lbl_ProductPrice.Text = "₱ " + value ;
        }
        public int ProductQuantity
        {
            get => Int32.Parse(lbl_ProductQty.Text);
            set => lbl_ProductQty.Text = value + "";
        }
        public string ProductDescriptions
        {
            get => lbl_ProductDescription.Text;
            set => lbl_ProductDescription.Text = value;
        }
        public string ProductSize
        {
            get => cmb_ProductSize.Text;
            set => cmb_ProductSize.Text = value;
        }
        public string ProductColor
        {
            get => cmb_Color.Text;
            set => cmb_Color.Text = value;
        }
        public string ProductCategory
        {
            get => lbl_Category.Text;
            set => lbl_Category.Text = value;
        }

        private void btn_Plus_Click(object sender, EventArgs e)
        {
            if (ProductQuantity == ProductStocks)
            {
                MessageDialogue messageDialogue = new MessageDialogue("You reached the maximum stock");
                messageDialogue.ShowDialog();
            }
            else
            {
                DataBase DB = new DataBase();
                DB.UpdateAddCartProduct(ProductID);
                ProductQuantity++;
            }
        }
        private void btn_Minus_Click(object sender, EventArgs e)
        {
            if (ProductQuantity == 1)
            {
                MessageDialogue messageDialogue = new MessageDialogue("Product Quantity is equals to 1");
                messageDialogue.ShowDialog();
            }
            else
            {
                DataBase DB = new DataBase();
                DB.UpdateDeductCartProduct(ProductID);
                ProductQuantity--;

            }
        }
        private void btn_DeleteProduct_Click(object sender, EventArgs e)
        {
            DataBase DB = new DataBase();
            DB.DeleteCartProduct(CartID);

            this.Dispose();
            MessageDialogue message = new MessageDialogue("Product Removed");
            message.ShowDialog();
        }

    }
}
