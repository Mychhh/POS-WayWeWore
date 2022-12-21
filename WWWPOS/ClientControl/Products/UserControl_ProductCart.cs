﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;
using WWWPOS.ErrorMessage;

namespace WWWPOS.ClientControl.Products
{
    public partial class UserControl_ProductCart : UserControl
    {
        public UserControl_ProductCart(int userid, int productID, Image productImage, double productPrice, int productQuantity, int productStock, string productDescriptions, string productSize, string productColor, string productCategory)
        {
            InitializeComponent();
            UserID = userid;
            ProductID = productID;
            ProductImage = productImage;
            ProductPrice  = productPrice;
            ProductQuantity = productQuantity;
            ProductStocks = productStock;
            ProductDescriptions = productDescriptions;
            ProductSize = productSize;
            ProductColor = productColor;
            ProductCategory = productCategory;
        }
        public int UserID { get; set; }
        public int ProductID { get; set; }
        public int ProductStocks { get; set; }
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

        private void btn_Minus_Click(object sender, EventArgs e)
        {
            if(ProductQuantity <= 1)
            {
                MessageDialogue messageDialogue = new MessageDialogue("Product Quantity is equals to 1");
                messageDialogue.ShowDialog();
            }
            else
            {
                ProductQuantity--;
            }
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
                ProductQuantity++;
            }
        }
    }
}
