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
using WWWPOS.MessageFolder;

namespace WWWPOS.ClientControl.Products
{
    public partial class UserControl_Product : UserControl
    {
        public UserControl_Product(int productID, string productImage, string productName, double productPrice, int productStock, string productDescription, string productSize, string productColor, string productCategory)
        {
            InitializeComponent();
            //Adding hashtag to the end of string
            productColor += "#";
            productSize += "#";

            bool hasSameColor = false;
            bool hasSameSize = false;

            //Checks if the string in not empty
            while (!string.IsNullOrEmpty(productColor))
            {
                //Color Validation
                if (cmb_ProductColor.Items.Count > 0)
                {
                    foreach (string colorList in cmb_ProductColor.Items)
                    {
                        if (productColor.Substring(0, productColor.IndexOf("#")) == colorList)
                        {
                            productColor = productColor.Remove(0, productColor.IndexOf("#") + 1);
                            hasSameColor = true;
                            break;
                        }
                    }
                }

                //Adds color if it is unique
                if (hasSameColor == false)
                {
                    cmb_ProductColor.Items.Insert(0, productColor.Substring(0, productColor.IndexOf("#")));
                    productColor = productColor.Remove(0, productColor.IndexOf("#") + 1);
                }
                else if (hasSameColor == true)
                {
                    hasSameColor = false;
                }

                //-----------------------------------------------------------//

                //Size Validation
                if (cmb_ProductSize.Items.Count > 0)
                {
                    foreach (string sizeList in cmb_ProductSize.Items)
                    {
                        if (productSize.Substring(0, productSize.IndexOf("#")) == sizeList)
                        {
                            productSize = productSize.Remove(0, productSize.IndexOf("#") + 1);
                            hasSameSize = true;
                            break;
                        }
                    }
                }

                //Adds size if it is unique
                if (hasSameSize == false)
                {
                    cmb_ProductSize.Items.Insert(0, productSize.Substring(0, productSize.IndexOf("#")));
                    productSize = productSize.Remove(0, productSize.IndexOf("#") + 1);
                }
                else if (hasSameSize == true)
                {
                    hasSameSize = false;
                }
            }

            ID = productID;
            Category = productCategory;
            Productname = productName;
            Price = productPrice;
            Stock = productStock;
            Descriptions = productDescription;
            Pic = Image.FromFile(@"" + productImage);
            ImagePath = productImage;

            cmb_ProductColor.SelectedIndex = 0;
            cmb_ProductSize.SelectedIndex = 0;
        }

        public int ID { get; set; }
        public string Category {
            get => lbl_Category.Text;
            set => lbl_Category.Text = value;
        }
        public string Productname { get; set; }
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
        public string Productsize
        {
            get => cmb_ProductSize.Text;
            set => cmb_ProductSize.Text = value;
        }
        public Image Pic
        {
            get => picbox_ProductImage.Image;
            set => picbox_ProductImage.Image = value;
        }
        public string ImagePath { get; set; }

        private void btn_Plus_Click(object sender, EventArgs e)
        {
            
            if(Int32.Parse(lbl_ProductQty.Text) < Int32.Parse(lbl_ProductStock.Text))
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
            DB.AddToCart(ID, Category, Productname, Color, Price, Int32.Parse(lbl_ProductQty.Text), ImagePath, Productsize, Descriptions);
        }
        private void btn_Buy_Click(object sender, EventArgs e)
        {
            Class_LoadData data = new Class_LoadData();
            data.LoadBuyItem(ID, ImagePath, Productname, Price, Category, Int32.Parse(lbl_ProductQty.Text), Productsize, Color, Descriptions);
        }
        private void cmb_ProductSize_DropDownClosed(object sender, EventArgs e)
        {
            //Calls the method with a string array return type and use it to change the value of item based on given value
            Class_LoadData C_LoadData = new Class_LoadData();
            string[] returnValue = C_LoadData.GetParticularProduct(Category, Productname, cmb_ProductColor.Text, cmb_ProductSize.Text);

            ID = Int32.Parse(returnValue[0]);
            Price = Double.Parse(returnValue[5]);
            Stock = Int32.Parse(returnValue[6]);
            Descriptions = returnValue[9];
            Pic = Image.FromFile(@"" + returnValue[7]);
        }

    }
}
