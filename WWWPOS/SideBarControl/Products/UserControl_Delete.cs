using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WWWPOS.SideBarControl.Inventory;

namespace WWWPOS.SideBarControl.Products
{
    public partial class UserControl_Delete : UserControl
    {
        public UserControl_Delete(int productID, double productPrice, int product_Stock, string productColor, string productSize, string productDescription, Image image)
        {
            InitializeComponent();
            ID = productID;
            Price = productPrice;
            Stock = product_Stock;
            Color = productColor;
            productsSize = productSize;
            Descriptions = productDescription;
            Pic = image;
        }
        public int ID {
            get => int.Parse(product_ID.Text);
            set => product_ID.Text = value + "";
        }
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
            get => product_Color.Text;
            set => product_Color.Text = value;
        }
        public string productsSize
        {
            get => product_Size.Text;
            set => product_Size.Text = value + "";
        }
        public Image Pic
        {
            get => product_Image.Image;
            set => product_Image.Image = value;
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DataBase DB = new DataBase();

            DB.WarningMessage("Do you really want to delete this product?");

            if (DataBase.message == "continue")
            {
                DB.SetStatusProducts("Inactive", Int32.Parse(product_ID.Text));
                DataBase.message = "";
                this.Dispose(true);
            }
        }
    }
}
