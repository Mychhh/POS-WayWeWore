﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WWWPOS.ClientControl.Products;

namespace WWWPOS.ClientControl
{
    public partial class UserControl_ClientCart : UserControl
    {
        public UserControl_ClientCart()
        {
            InitializeComponent();
        }
        private void UserControl_ClientCart_Load(object sender, EventArgs e)
        {
            loadData Data = new loadData();
            Data.LoadCart(flowLayoutPanel_ProductCart);
            LoadCartTotalPrice();
        }

        public void LoadCartTotalPrice()
        {
            loadData Data = new loadData();
            TotalCart = Data.LoadCartTotalPrice(TotalCart);
        }

        public string TotalCart
        {
            get => lbl_TotalCart.Text;
            set => lbl_TotalCart.Text = "₱ " + value;
        }

        private void btn_BrowseProduct_Click(object sender, EventArgs e)
        {
            Form_ClientLandingPage clientForm = new Form_ClientLandingPage();
            UserControl_ClientViewProduct UC_ClientViewProduct = new UserControl_ClientViewProduct();

            Controls.Clear();
            Controls.Add(UC_ClientViewProduct);
            UC_ClientViewProduct.Dock = DockStyle.Fill;
        }

        private void lbl_ProductPrice_Click(object sender, EventArgs e)
        {
            LoadCartTotalPrice();
        }
    }
}
