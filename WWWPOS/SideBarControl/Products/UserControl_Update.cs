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
        public UserControl_Update(int productID, string productCategory, string productName, double productPrice, int productStock, string productColor, string productSize, string productDescription, Image productImage)
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

        private void btn_Edit_Click(object sender, EventArgs e)
        {

            UserControlUpdate UC_Update = new UserControlUpdate();

            //UserControlViewUpdate UC_ViewUpdate = new UserControlViewUpdate();
            //UserControlInventory UC_Inventory = new UserControlInventory();

            UC_Update.product_Image.Image = picbox_ProductImage.Image;
            UC_Update.rtb_Description.Text  = lbl_ProductDescription.Text;
            UC_Update.txtBox_productID.Text = product_ID.Text;
            UC_Update.txtBox_ProductName.Text = product_Name.Text;
            UC_Update.comboBox_ProductType.Text = product_Type.Text;
            UC_Update.comboBox_Size.Text = cmb_ProductSize.Text;
            UC_Update.txtBox_Color.Text = cmb_ProductColor.Text;
            UC_Update.txtBox_Price.Text = lbl_ProductPrice.Text;
            UC_Update.txtBox_Stocks.Text = lbl_ProductStock.Text;

            //----User Control----//

            //Controls.Clear();
            //Controls.Add(UC_Update);
            //UC_Update.Dock = DockStyle.Fill;

            //UC_ViewUpdate.Controls.Clear();
            //UC_ViewUpdate.Controls.Add(UC_Update);
            //UC_Update.Dock = DockStyle.Fill;

            //UC_Inventory.panel_Inventory.Controls.Clear();
            //UC_Inventory.panel_Inventory.Controls.Add(UC_Update);
            //UC_Update.Dock = DockStyle.Fill;

            //----User Control Forms----//

            UserControlUpdateForm UC_UpdateForm = new UserControlUpdateForm();

            UC_UpdateForm.product_Image.Image = picbox_ProductImage.Image;
            UC_UpdateForm.rtb_Description.Text = lbl_ProductDescription.Text;
            UC_UpdateForm.txtBox_productID.Text = product_ID.Text;
            UC_UpdateForm.txtBox_ProductName.Text = product_Name.Text;
            UC_UpdateForm.comboBox_ProductType.Text = product_Type.Text;
            UC_UpdateForm.comboBox_Size.Text = cmb_ProductSize.Text;
            UC_UpdateForm.txtBox_Color.Text = cmb_ProductColor.Text;
            UC_UpdateForm.txtBox_Price.Text = lbl_ProductPrice.Text;
            UC_UpdateForm.txtBox_Stocks.Text = lbl_ProductStock.Text;

            UC_UpdateForm.ShowDialog();
        }
        private void cmb_ProductSize_DropDownClosed_1(object sender, EventArgs e)
        {
            //Calls the method with a string array return type and use it to change the value of item based on given value
            Class_LoadData C_LoadData = new Class_LoadData();
            string[] returnValue = C_LoadData.GetParticularProduct(Category, Productname, cmb_ProductColor.Text, cmb_ProductSize.Text);

            Price = Double.Parse(returnValue[5]);
            Stock = Int32.Parse(returnValue[6]);
            Descriptions = returnValue[9];
            Pic = Image.FromFile(@"" + returnValue[7]);
        }
    }
}
