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
    public partial class UserControl_Update : UserControl
    {
        public UserControl_Update(int productID, string productName,string productType, double productPrice, int product_Stock, string productColor, string productSize, string productDescription, Image image)
        {
            InitializeComponent();
            ID = productID;
            products_Name = productName;
            products_Type = productType;
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
        public string products_Name
        {
            get => product_Name.Text;
            set => product_Name.Text = value;
        }
        public string products_Type
        {
            get => product_Type.Text;
            set => product_Type.Text = value;
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
      
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            UserControlUpdate update_Form = new UserControlUpdate();
            UserControlInventory uci = new UserControlInventory();

            update_Form.product_Image.Image = product_Image.Image;
            update_Form.rtb_Description.Text  = product_Description.Text;
            update_Form.txtBox_productID.Text = product_ID.Text;
            update_Form.txtBox_ProductName.Text = product_Name.Text;
            update_Form.comboBox_ProductType.Text = product_Type.Text;
            update_Form.comboBox_Size.Text = product_Size.Text;
            update_Form.txtBox_Color.Text = product_Color.Text;
            update_Form.txtBox_Price.Text = product_Price.Text;
            update_Form.txtBox_Stocks.Text = product_Stock.Text;

            Controls.Clear();
            Controls.Add(update_Form);
            update_Form.Dock = DockStyle.Fill;


        }
    }
}
