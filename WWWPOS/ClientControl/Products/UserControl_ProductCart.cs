using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Markup;
using System.Windows.Media;
using WWWPOS.ClientControl.ClientCart;
using WWWPOS.ErrorMessage;

namespace WWWPOS.ClientControl.Products
{
    public partial class UserControl_ProductCart : UserControl
    {
        //For Cart
        public UserControl_ProductCart(int cartID, int userid, int productID, Image productImage, double productPrice, int productQuantity, int productTotal, int productStock, string productDescriptions, string productSize, string productColor, string productCategory)
        {
            InitializeComponent();

            cmb_Color.Items.Add(productColor);
            cmb_ProductSize.Items.Add(productSize);

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

            cmb_Color.Enabled = false;
            cmb_ProductSize.Enabled = false;
        }
        //For BuyItem
        public UserControl_ProductCart(int userID, int productID, string productImg, string productName, double productPrice, string productCategory, int productQuantity, string productSize, string productColor, string productDescription)
        {
            InitializeComponent();

            cmb_Color.Items.Add(productColor);
            cmb_ProductSize.Items.Add(productSize);

            UserID = userID;
            ProductID = productID;
            ProductImage = Image.FromFile(productImg); ;
            ProductNameCart = productName;
            ProductPrice = productPrice;
            ProductCategory = productCategory;
            ProductQuantity = productQuantity;
            ProductSize = productSize;
            ProductColor = productColor;
            ProductDescriptions = productDescription;
        }

        public int CartID { get; set; }
        public int UserID { get; set; }
        public int ProductID { get; set; }
        public int ProductStocks { get; set; }
        public int ProductTotal { get; set; }
        public string ProductNameCart { get; set;  }
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
            if (ProductQuantity >= ProductStocks)
            {
                ErrorMessageDialogue messageDialogue = new ErrorMessageDialogue("You reached the maximum stock");
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
            if (ProductQuantity <= 1)
            {
                ErrorMessageDialogue messageDialogue = new ErrorMessageDialogue("Product Quantity is equals to 1");
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
            ErrorMessageDialogue message = new ErrorMessageDialogue("Product Removed");
            message.ShowDialog();
        }
    }
}
