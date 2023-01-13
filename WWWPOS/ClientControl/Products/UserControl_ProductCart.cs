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
using WWWPOS.MessageFolder;

namespace WWWPOS.ClientControl.Products
{
    public partial class UserControl_ProductCart : UserControl
    {
        //Static Fields for buy item
        public static int  CARTID = 0;

        public static int PRODUCTID;
        public static string PRODUCTImagePath;
        public static string PRODUCTName;
        public static double PRODUCTPrice;
        public static string PRODUCTCategory;
        public static int PRODUCTQuantity;
        public static string PRODUCTSize;
        public static string PRODUCTColor;
        public static string PRODUCTDescription;

        //For Cart
        public UserControl_ProductCart(int cartID, int userid, int productID, Image productImage, double productPrice, int productQuantity, int productTotal, int productStock, string productDescriptions, string productSize, string productColor, string productCategory)
        {
            InitializeComponent();
            CARTID = cartID;

            cmb_Color.Items.Add(productColor);
            cmb_ProductSize.Items.Add(productSize);

            UserID = userid;
            CartID = cartID;
            ProductID = productID;
            ProductImage = productImage;
            ProductPrice  = productPrice;
            ProductPriceWithoutSign = productPrice;
            ProductQuantity = productQuantity;
            ProductTotal = productTotal;
            ProductStocks = productStock;
            ProductDescriptions = productDescriptions;
            ProductSize = productSize;
            ProductColor = productColor;
            ProductCategory = productCategory;

            cmb_Color.Enabled = false;
            cmb_ProductSize.Enabled = false;

            cmb_Color.Visible = false;
        }
        //For BuyItem
        public UserControl_ProductCart(int userID, int productID, string productImg, string productName, double productPrice, string productCategory, int productQuantity, string productSize, string productColor, string productDescription)
        { 
            InitializeComponent();

            cmb_Color.Items.Add(productColor);
            cmb_ProductSize.Items.Add(productSize);

            UserID = userID;
            BuyProductID = productID;
            ProductImage = Image.FromFile(productImg);
            ProductImagePath = productImg;
            ProductNameCart = productName;
            ProductPrice = productPrice;
            ProductCategory = productCategory;
            Category = productCategory;
            ProductQuantity = productQuantity;
            ProductTotal = Convert.ToInt32(productPrice) * productQuantity;
            Quantity = productQuantity;
            ProductSize = productSize;
            PSize = productSize;
            ProductColor = productColor;
            PColor = productColor;
            ProductDescriptions = productDescription;
            Description = productDescription;

            PRODUCTID = productID;
            PRODUCTImagePath = productImg;
            PRODUCTName = productName;
            PRODUCTPrice = productPrice;
            PRODUCTCategory = productCategory;
            PRODUCTQuantity = productQuantity;
            PRODUCTSize = productSize;
            PRODUCTColor = productColor;
            PRODUCTDescription = productDescription;

            //
            cmb_Color.Visible = false;
        }

        public int CartID { get; set; }
        public int UserID { get; set; }
        public int ProductID { get; set; }
        public int ProductStocks { get; set; }
        public int ProductTotal {
            get => Int32.Parse(lbl_ItemTotal.Text);
            set => lbl_ItemTotal.Text = value + "";
        }
        public string ProductNameCart { get; set;  }
        public Image ProductImage
        {
            get => picBox_ProductPicture.Image;
            set => picBox_ProductPicture.Image = value;
        }
        public string ProductImagePath { get; set; }
        public double ProductPrice
        {
            get => Double.Parse(lbl_ProductPrice.Text);
            set => lbl_ProductPrice.Text = "₱ " + value ;
        }
        public double ProductPriceWithoutSign { get; set; }
        public int ProductQuantity
        {
            get => Int32.Parse(lbl_ProductQty.Text);
            set => lbl_ProductQty.Text = value + "";
        }
        public int Quantity { get; set; }
        public string ProductDescriptions
        {
            get => lbl_ProductDescription.Text;
            set => lbl_ProductDescription.Text = value;
        }
        public string Description { get; set; }
        public string ProductSize
        {
            get => cmb_ProductSize.Text;
            set => cmb_ProductSize.Text = value;
        }
        public string PSize { get; set; }
        public string ProductColor
        {
            get => lbl_Color.Text;
            set => lbl_Color.Text = value;
        }
        public string PColor { get; set; }
        public string ProductCategory
        {
            get => lbl_Category.Text;
            set => lbl_Category.Text = value;
        }
        public string Category { get; set; }

        public int BuyProductID { get; set; }

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
                
                ProductTotal = Convert.ToInt32(ProductPriceWithoutSign) * ProductQuantity;
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
                ProductTotal = Convert.ToInt32(ProductPriceWithoutSign) * ProductQuantity;
            }
        }
        private void btn_DeleteProduct_Click(object sender, EventArgs e)
        {
            DataBase DB = new DataBase();
            DB.DeleteCartProduct(CartID);

            this.Dispose();
            SuccessMessageDialogue message = new SuccessMessageDialogue("Product Removed");
            message.ShowDialog();
        }
    }
}
