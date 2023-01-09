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

namespace WWWPOS.ClientControl.Products
{
    public partial class UserControl_ProductCartInactive : UserControl
    {
        public UserControl_ProductCartInactive(int cartID, int userid, int productID, Image productImage, double productPrice, int productQuantity, string productDescriptions, string productSize, string productColor, string productCategory)
        {
            InitializeComponent();

            cmb_Color.Items.Add(productColor);
            cmb_ProductSize.Items.Add(productSize);

            CartID = cartID;
            UserID = userid;
            ProductID = productID;
            ProductImage = productImage;
            ProductPrice = productPrice;
            ProductQuantity = productQuantity;
            ProductDescriptions = productDescriptions;
            ProductSize = productSize;
            ProductColor = productColor;
            ProductCategory = productCategory;

            cmb_Color.Visible = false;
        }

        public int CartID { get; set; }
        public int UserID { get; set; }
        public int ProductID { get; set; }
        public Image ProductImage
        {
            get => picBox_ProductPicture.Image;
            set => picBox_ProductPicture.Image = value;
        }
        public double ProductPrice
        {
            get => Double.Parse(lbl_ProductPrice.Text);
            set => lbl_ProductPrice.Text = "₱ " + value;
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
            get => lbl_Color.Text;
            set => lbl_Color.Text = value;
        }
        public string ProductCategory
        {
            get => lbl_Category.Text;
            set => lbl_Category.Text = value;
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
