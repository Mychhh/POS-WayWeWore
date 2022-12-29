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
        public UserControl_Delete(int productID, string productCategory, string productName, double productPrice, int productStock, string productColor, string productSize, string productDescription, Image productImage)
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
            Pic = productImage;

            cmb_ProductColor.SelectedIndex = 0;
            cmb_ProductSize.SelectedIndex = 0;
        }

        public int ID { get; set; }
        public string Category { get; set; }
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
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DataBase DB = new DataBase();

            DB.WarningMessage("Do you really want to delete this product?");

            if (DataBase.message == "continue")
            {
                DB.SetStatusProducts("Inactive", ID);
                DataBase.message = "";

                //This refresh the form
                Form_AdminHome form_AdminHome = new Form_AdminHome();
                form_AdminHome.Hide();
                form_AdminHome.ShowDialog();

                //UserControlInventory UC_Inventory = new UserControlInventory();
                //UserControlDelete UC_Delete = new UserControlDelete();

                //UC_Inventory.panel_Inventory.Controls.Clear();
                //UC_Inventory.panel_Inventory.Controls.Add(UC_Delete);
                //UC_Delete.Dock = DockStyle.Fill;

                //Class_LoadData LD = new Class_LoadData();
                //LD.selectProduct(UC_Delete.flowLayoutPanel, "panelDelete");
            }
        }

        private void cmb_ProductSize_DropDownClosed(object sender, EventArgs e)
        {
            //Calls the method with a string array return type and use it to change the value of item based on given value
            Class_LoadData C_LoadData = new Class_LoadData();
            string[] returnValue = C_LoadData.GetParticularProduct(Category, Productname, cmb_ProductColor.Text, cmb_ProductSize.Text);

            this.ID = Int32.Parse(returnValue[0]);
            this.Category = returnValue[2];
            this.Productname = returnValue[3];
            this.Color = returnValue[4];
            this.Price = Double.Parse(returnValue[5]);
            this.Stock = Int32.Parse(returnValue[6]);
            this.Pic = Image.FromFile(@"" + returnValue[7]);
            this.Productsize = returnValue[8];
            this.Descriptions = returnValue[9];
        }
    }
}
