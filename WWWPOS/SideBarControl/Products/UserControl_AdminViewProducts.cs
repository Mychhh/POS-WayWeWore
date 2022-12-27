using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace WWWPOS.SideBarControl.Products
{
    public partial class UserControl_AdminViewProducts : UserControl
    {
        public UserControl_AdminViewProducts(int productID, double productPrice, int product_Stock, string productColor, string productSize, string productDescription, Image image)
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
                if(hasSameColor == false)
                {
                    cmb_ProductColor.Items.Add(productColor.Substring(0, productColor.IndexOf("#")));
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

                //Adds color if it is unique
                if (hasSameSize == false)
                {
                    cmb_ProductSize.Items.Add(productSize.Substring(0, productSize.IndexOf("#")));
                    productSize = productSize.Remove(0, productSize.IndexOf("#") + 1);
                }
                else if (hasSameSize == true)
                {
                    hasSameSize = false;
                }

                ////Adding Items to combo box
                //cmb_ProductColor.Items.Add(productColor.Substring(0, productColor.IndexOf("#")));
                //cmb_ProductSize.Items.Add(productSize.Substring(0, productSize.IndexOf("#")));

                ////Remove the added string items
                //productColor = productColor.Remove(0, productColor.IndexOf("#") + 1);
                //productSize = productSize.Remove(0, productSize.IndexOf("#") + 1);
            }


            ID = productID;
            Price = productPrice;
            Stock = product_Stock;
            Color = productColor;
            productsSize = productSize;
            Descriptions = productDescription;
            Pic = image;

        }

        public int ID { get; set; }
        public string Descriptions
        {
            get => product_Description.Text;
            set => product_Description.Text = value;
        }
        public double Price
        {
            get => Double.Parse(product_Price.Text);
            set => product_Price.Text = value + "";
        }
        public int Stock
        {
            get => int.Parse(product_Stock.Text);
            set => product_Stock.Text = value + "";
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
            get => product_Image.Image;
            set => product_Image.Image = value;
        }

        public string dummyColor { get; set; }
        public string dummySize { get; set; }

    }
}
