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

            xValues.Add("WWW White");
            yValues.Add(7);

            xValues.Add("WWW Green");
            yValues.Add(4);

            xValues.Add("WWW Black");
            yValues.Add(10);

            xValues.Add("WWW Blue");
            yValues.Add(3);
        }

        private void UserControlSales_Load(object sender, EventArgs e)
        {
            SalesReport.Series["Sales report"].Points.DataBindXY(xValues, yValues);
        }
    }
}
