﻿using Google.Protobuf.WellKnownTypes;
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

namespace WWWPOS.SideBarControl
{
    public partial class UserControlSales : UserControl
    {

        public List<string> xValues = new List<string>();
        public List<int> yValues = new List<int>();

        public UserControlSales()
        {
            InitializeComponent();

            cmb_Category.Text = cmb_Category.Items[0].ToString();
        }

        public string query { get; set; }

        private void UserControlSales_Load(object sender, EventArgs e)
        {
            SalesReport.Series["Sales report"].Points.DataBindXY(xValues, yValues);
        }

        private void cmb_Category_DropDownClosed(object sender, EventArgs e)
        {
            Class_LoadData class_LoadData = new Class_LoadData();

            if (cmb_Category.SelectedIndex == 0)
            {
                class_LoadData.GetDesiredChartData(this, "SELECT ProductID, Name, Category, Quantity  FROM Orders WHERE OrderStatus = 'Success'", "AllProduct");
                SalesReport.Series["Sales report"].Points.DataBindXY(xValues, yValues);
            }
            else if (cmb_Category.SelectedIndex == 1)
            {
                class_LoadData.GetDesiredChartData(this, "SELECT ProductID, Name, Quantity, PlacedOrder FROM Orders WHERE OrderStatus = 'Success' AND Category = 'T-Shirts'", "ParticularProduct");
                SalesReport.Series["Sales report"].Points.DataBindXY(xValues, yValues);
            }
            else if (cmb_Category.SelectedIndex == 2)
            {
                class_LoadData.GetDesiredChartData(this, "SELECT ProductID, Name, Quantity, PlacedOrder FROM Orders WHERE OrderStatus = 'Success' AND Category = 'Shorts'", "ParticularProduct");
                SalesReport.Series["Sales report"].Points.DataBindXY(xValues, yValues);
            }
        }
    }
}
