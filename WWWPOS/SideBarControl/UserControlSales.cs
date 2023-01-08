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
            Class_LoadData loadtData = new Class_LoadData();

            if (cmb_Category.SelectedIndex == 0)
            {
                loadtData.GetDesiredChartData(this, "SELECT ProductID, Name, Category, Quantity, PlacedOrder FROM Orders WHERE OrderStatus = 'Success'", "AllProduct");
            }
            else if (cmb_Category.SelectedIndex == 1)
            {
                loadtData.GetDesiredChartData(this, "SELECT ProductID, Name, Quantity, PlacedOrder FROM Orders WHERE OrderStatus = 'Success' AND Category = 'T-Shirts'", "ParticularProduct");
            }
            else if (cmb_Category.SelectedIndex == 2)
            {
                loadtData.GetDesiredChartData(this, "SELECT ProductID, Name, Quantity, PlacedOrder FROM Orders WHERE OrderStatus = 'Success' AND Category = 'Shorts'", "ParticularProduct");
            }
        }
    }
}
