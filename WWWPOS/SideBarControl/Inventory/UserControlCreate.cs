﻿using System;
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
    public partial class UserControlCreate : UserControl
    {
        public UserControlCreate()
        {
            InitializeComponent();
        }

        DataBase DB = new DataBase();
     
        private void rtb_Description_Enter(object sender, EventArgs e)
        {
            if (rtb_Description.Text == "Description")
            {
                rtb_Description.Text = "";
            }
            
        }
        private void rtb_Description_Leave(object sender, EventArgs e)
        {
            if (rtb_Description.Text == "")
            {
                rtb_Description.Text = "Description";
            }
        }
        public static string imageURL = null;
        private void btn_Browse_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog())
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    imageURL = ofd.FileName;
                    product_Image.Image = Image.FromFile(ofd.FileName);
                }
            }
        }
        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            double product_Price = Double.Parse(txtBox_Price.Text);
            int product_Stock = Int32.Parse(txtBox_Stocks.Text);


            DB.addProdducts(txtBox_ProductName.Text, txtBox_Color.Text, product_Price, product_Stock, comboBox_ProductType.Text, comboBox_Size.Text, imageURL, rtb_Description.Text);

            string message = DataBase.message;

            if (message == "Success")
            {
                UserControlRead UC_Read = new UserControlRead();

                Controls.Clear();
                Controls.Add(UC_Read);
                UC_Read.Dock = DockStyle.Fill;
            }

        }
    }
}
