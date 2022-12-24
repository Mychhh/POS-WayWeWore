﻿using System;
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

            cmb_Color.Items.Add(productColor);
            cmb_ProductSize.Items.Add(productSize);

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

        private void btn_Edit_Click(object sender, EventArgs e)
        {

            UserControlUpdate UC_Update = new UserControlUpdate();

            //UserControlViewUpdate UC_ViewUpdate = new UserControlViewUpdate();
            //UserControlInventory UC_Inventory = new UserControlInventory();

            UC_Update.product_Image.Image = product_Image.Image;
            UC_Update.rtb_Description.Text  = product_Description.Text;
            UC_Update.txtBox_productID.Text = product_ID.Text;
            UC_Update.txtBox_ProductName.Text = product_Name.Text;
            UC_Update.comboBox_ProductType.Text = product_Type.Text;
            UC_Update.comboBox_Size.Text = cmb_ProductSize.Text;
            UC_Update.txtBox_Color.Text = cmb_Color.Text;
            UC_Update.txtBox_Price.Text = product_Price.Text;
            UC_Update.txtBox_Stocks.Text = product_Stock.Text;

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

            UC_UpdateForm.product_Image.Image = product_Image.Image;
            UC_UpdateForm.rtb_Description.Text = product_Description.Text;
            UC_UpdateForm.txtBox_productID.Text = product_ID.Text;
            UC_UpdateForm.txtBox_ProductName.Text = product_Name.Text;
            UC_UpdateForm.comboBox_ProductType.Text = product_Type.Text;
            UC_UpdateForm.comboBox_Size.Text = cmb_ProductSize.Text;
            UC_UpdateForm.txtBox_Color.Text = cmb_Color.Text;
            UC_UpdateForm.txtBox_Price.Text = product_Price.Text;
            UC_UpdateForm.txtBox_Stocks.Text = product_Stock.Text;

            UC_UpdateForm.ShowDialog();
        }
    }
}
