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
using WWWPOS.MessageFolder;

namespace WWWPOS.SideBarControl.Products
{
    public partial class UserControl_AdminViewProducts : UserControl
    {
        public UserControl_AdminViewProducts(int productID, string productCategory, string productName, double productPrice, int product_Stock, string productColor, string productSize, string productDescription, Image image)
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
            }

            ID = productID;
            Category = productCategory;
            Productname = productName;
            Price = productPrice;
            Stock = product_Stock;
            Descriptions = productDescription;
            Pic = image;

            cmb_ProductColor.SelectedIndex = 0;
            cmb_ProductSize.SelectedIndex = 0;
            Console.WriteLine("Product Description" + Descriptions);
        }

        public int ID { get; set; }
        public string Category { get; set; }
        public string Productname { get; set; }
        public string Descriptions
        {
            get => product_Description.Text;
            set => product_Description.Text = value;
        }
        public double Price
        {
            get => Double.Parse(lbl_Product_Price.Text);
            set => lbl_Product_Price.Text = value + "";
        }
        public int Stock
        {
            get => int.Parse(product_Stock.Text);
            set => product_Stock.Text = value + "";
        }
        public string Color {
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
            get => product_Image.Image;
            set => product_Image.Image = value;
        }

        //Change the Item Information after choosing product size and color
        private void cmb_ProductSize_DropDownClosed(object sender, EventArgs e)
        {
            Class_LoadData C_LoadData = new Class_LoadData();
            //C_LoadData.GetParticularProduct(Category, Productname, cmb_ProductColor.Text, cmb_ProductSize.Text);

            string[] returnValue = C_LoadData.GetParticularProduct(Category, Productname, cmb_ProductColor.Text, cmb_ProductSize.Text);

            Price = Double.Parse(returnValue[5]);
            Stock = Int32.Parse(returnValue[6]);
            Descriptions = returnValue[9];
            Pic = Image.FromFile(@"" + returnValue[7]);
        }

    }
}
