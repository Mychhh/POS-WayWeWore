using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WWWPOS.MessageFolder;
using WWWPOS.SideBarControl.Products;

namespace WWWPOS.SideBarControl.Inventory
{
    public partial class UserControlUpdateForm : Form
    {
        public UserControlUpdateForm()
        {
            InitializeComponent();
        }

        public string ID
        {
            get => txtBox_ProductID.Text;
            set => txtBox_ProductID.Text = value;
        }
        public string Category
        {
            get => cmb_ProductCategory.Text;
            set => cmb_ProductCategory.Text = value;
        }
        public string Productname
        {
            get => txtBox_ProductName.Text;
            set => txtBox_ProductName.Text = value;
        }
        public string Color
        {
            get => txtBox_ProductColor.Text;
            set => txtBox_ProductColor.Text = value;
        }
        public string Price
        {
            get => txtBox_ProductPrice.Text;
            set => txtBox_ProductPrice.Text = value;
        }
        public string Stock
        {
            get => txtBox_ProductStocks.Text;
            set => txtBox_ProductStocks.Text = value;
        }
        public string Productsize
        {
            get => cmb_ProductSize.Text;
            set => cmb_ProductSize.Text = value;
        }
        public string Descriptions
        {
            get => rtb_ProductDescription.Text;
            set => rtb_ProductDescription.Text = value;
        }


        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_UpdateProduct_Click(object sender, EventArgs e)
        {

            DataBase DB = new DataBase();
            DB.UpdateProducts(Int32.Parse(ID), Category, Productname, Color, Double.Parse(Price), Int32.Parse(Stock), Productsize, Descriptions);
            this.Dispose();
            DataBase.message = "";

            //Form_AdminHome.ActiveForm.Dispose();//error

            //This adds new the form
            Form_AdminHome form_AdminHome = new Form_AdminHome();
            DataBase.fromWhat = "InventoryUpdate";
            form_AdminHome.ShowDialog();
        }
    }
}
