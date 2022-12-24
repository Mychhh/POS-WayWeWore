using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using WWWPOS.ClientControl.ClientCart;
using WWWPOS.ErrorMessage;

namespace WWWPOS.ClientControl.Products
{
    public partial class UserControl_Product : UserControl
    {
        public UserControl_Product(int id, Image image, string imgPath, string name, double price, int stocks, string description, string size, string color, string category)
        {
            InitializeComponent();

            cmb_ProductSize.Items.Add(size);
            cmb_Color.Items.Add(color);

            productID = id;
            ProductImage = image;
            ProductImgPath = imgPath;
            Productname = name;
            ProductPrice = price;
            ProductStocks = stocks;
            ProductDescriptions = description;
            ProductSize = size;
            ProductColor = color;
            ProductCategory = category;
        }
        public int productID { get; set; }
        public string ProductImgPath{ get; set; }
        public Image ProductImage
        {
            get => picBox_ProductPicture.Image;
            set => picBox_ProductPicture.Image = value;
        }
        public string Productname { get; set; }
        public double ProductPrice
        {
            get => Double.Parse(lbl_ProductPrice.Text);
            set => lbl_ProductPrice.Text = value + "";
        }
        public int ProductStocks
        {
            get => int.Parse(lbl_ProductStocks.Text);
            set => lbl_ProductStocks.Text = value + "";
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
            
            if(Int32.Parse(lbl_ProductQty.Text) < Int32.Parse(lbl_ProductStocks.Text))
            {
                lbl_ProductQty.Text = Convert.ToString(Int32.Parse(lbl_ProductQty.Text) + 1);
            }
            else
            {
                ErrorMessage.ErrorMessageDialogue maxQty = new ErrorMessage.ErrorMessageDialogue("You reached the maximum Quantity");
                maxQty.ShowDialog();
            }
        }
        private void btn_Minus_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(lbl_ProductQty.Text) > 1)
            {
                lbl_ProductQty.Text = Convert.ToString(Int32.Parse(lbl_ProductQty.Text) - 1);
            }
            else
            {
                ErrorMessage.ErrorMessageDialogue maxQty = new ErrorMessage.ErrorMessageDialogue("Quantity is equals to One");
                maxQty.ShowDialog();
            }
        }
        private void btn_AddToCart_Click(object sender, EventArgs e)
        {
            DataBase DB = new DataBase();
            DB.AddToCart(productID, ProductCategory, ProductName, ProductColor, ProductPrice, Int32.Parse(lbl_ProductQty.Text), ProductImgPath, ProductSize, ProductDescriptions);
        }
        private void btn_Buy_Click(object sender, EventArgs e)
        {
            this.Hide();
            loadData data = new loadData();
            data.LoadBuyItem(productID, ProductImgPath, Productname, ProductPrice, ProductCategory, Int32.Parse(lbl_ProductQty.Text), ProductSize, ProductColor, ProductDescriptions);
            
        }
    }
}
