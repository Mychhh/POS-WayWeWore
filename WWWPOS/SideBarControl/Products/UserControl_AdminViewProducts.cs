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

            cmb_Color.Items.Add(productColor);
            cmb_ProductSize.Items.Add(productSize);

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
            get => cmb_Color.Text;
            set => cmb_Color.Text = value;
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

    }
}
