using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WWWPOS.MessageFolder;

namespace WWWPOS.SideBarControl
{
    public partial class UserControlSales : UserControl
    {

        public List<string> xValues = new List<string>();
        public List<int> yValues = new List<int>();

        Class_LoadData class_LoadData = new Class_LoadData();

        public UserControlSales()
        {
            InitializeComponent();

            cmb_Category.Text = cmb_Category.Items[0].ToString();
            cmbDateRange.Text = cmbDateRange.Items[0].ToString();
        }

        public string dateRangeQuery { get; set; }
        public string TodaysDate { get; set; }

        private void UserControlSales_Load(object sender, EventArgs e)
        {
            SalesReport.Series["Sales Report"].Points.DataBindXY(xValues, yValues);
        }

        private void cmb_Category_DropDownClosed(object sender, EventArgs e)
        {
            string range = getsDateRange();
            string category = getsCategory();

            if (cmb_Category.Text == "All Items") 
            {
                class_LoadData.GetDesiredChartData(this, category + range, "AllProduct");
                SalesReport.Series["Sales Report"].Points.DataBindXY(xValues, yValues);
            }
            else if (cmb_Category.Text == "T-Shirt")
            {
                class_LoadData.GetDesiredChartData(this, category + range, "ParticularProduct");
                SalesReport.Series["Sales Report"].Points.DataBindXY(xValues, yValues);
            }
            else if (cmb_Category.Text == "Short")
            {
                class_LoadData.GetDesiredChartData(this, category + range, "ParticularProduct");
                SalesReport.Series["Sales Report"].Points.DataBindXY(xValues, yValues);
            }

            Console.WriteLine(category + range);
        }

        private void cmbDateRange_DropDownClosed(object sender, EventArgs e)
        {
            
            string range = getsDateRange();
            string category = getsCategory();

            if (cmb_Category.SelectedIndex == 0)
            {
                class_LoadData.GetDesiredChartData(this, category + range, "AllProduct");
                SalesReport.Series["Sales Report"].Points.DataBindXY(xValues, yValues);
            }
            else if (!(cmb_Category.SelectedIndex == 0))
            {
                class_LoadData.GetDesiredChartData(this, category + range, "ParticularProduct");
                SalesReport.Series["Sales Report"].Points.DataBindXY(xValues, yValues);
            }
        }

        private string getsDateRange()
        {
            switch (cmbDateRange.SelectedIndex)
            {
                case 0:

                    dateRangeQuery = "";
                    break;

                case 1:
                    dateRangeQuery = "AND PlacedOrder BETWEEN GETDATE() -7  AND GETDATE() ";
                    break;

                case 2:
                    dateRangeQuery = "AND PlacedOrder BETWEEN GETDATE() -31 AND GETDATE() ";
                    break;

                case 3:
                    dateRangeQuery = "AND PlacedOrder BETWEEN GETDATE() -124 AND GETDATE() ";
                    break;

                case 4:
                    dateRangeQuery = "AND PlacedOrder BETWEEN GETDATE() -367 AND GETDATE() ";
                    break;
            }
            return dateRangeQuery;
        }

        private string getsCategory()
        {
            string category = "";

            if (cmb_Category.SelectedIndex == 0)
            {
                category = "SELECT ProductID, Name, Category, Quantity  FROM Orders WHERE OrderStatus = 'Success' ";
            }
            else if (cmb_Category.SelectedIndex == 1)
            {
                category = "SELECT ProductID, Name, Quantity, PlacedOrder FROM Orders WHERE OrderStatus = 'Success' AND Category = 'T-Shirts'  ";
            }
            else if (cmb_Category.SelectedIndex == 2)
            {
                category = "SELECT ProductID, Name, Quantity, PlacedOrder FROM Orders WHERE OrderStatus = 'Success' AND Category = 'Shorts'  ";
            }

            return category;
        }
    }
}
