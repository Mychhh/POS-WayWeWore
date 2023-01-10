using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }
        public string Category
        {
            get => cmb_ProductCategory.Text;
        }
        public string Productname
        {
            get => txtBox_ProductName.Text;
        }
        public string Color
        {
            get => txtBox_ProductColor.Text;
        }
        public string Price
        {
            get => txtBox_ProductPrice.Text;
        }
        public string Stock
        {
            get => txtBox_ProductStocks.Text;
        }
        public string Productsize
        {
            get => cmb_ProductSize.Text;
        }
        public string Descriptions
        {
            get => rtb_ProductDescription.Text;
        }


        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_UpdateProduct_Click(object sender, EventArgs e)
        {

            //DataBase DB = new DataBase();
            //DB.UpdateProducts(Int32.Parse(ID), Category, Productname, Color, Double.Parse(Price), Int32.Parse(Stock), Productsize, Descriptions);

            //Form_AdminHome form_AdminHome = new Form_AdminHome();
            //form_AdminHome.Hide();
            //form_AdminHome.ShowDialog();
            
            //this.Close();

            DataBase DB = new DataBase();

            DB.WarningMessage("Continue updating the product?");

            if (DataBase.message == "continue")
            {
                DB.UpdateProducts(Int32.Parse(ID), Category, Productname, Color, Double.Parse(Price), Int32.Parse(Stock), Productsize, Descriptions);
                DataBase.message = "";

                //This refresh the form
                Form_AdminHome form_AdminHome = new Form_AdminHome();
                form_AdminHome.Hide();
                DataBase.fromWhat = "InventoryUpdate";
                form_AdminHome.ShowDialog();
            }
        }
    }
}
