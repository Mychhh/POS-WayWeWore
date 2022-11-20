using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WWWPOS
{
    public partial class Form2 : Form
    {
        //Initialized User Control
        SideBarControl.UserControlDashboard UCD_Dashboard = new SideBarControl.UserControlDashboard();
        SideBarControl.UserControlSales UCD_Sales = new SideBarControl.UserControlSales();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //panel_Main.Controls.Clear();
            panel_Main.Controls.Add(UCD_Dashboard);
            UCD_Dashboard.Dock = DockStyle.Fill;
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(UCD_Dashboard);
            UCD_Dashboard.Dock = DockStyle.Fill;
        }

        private void btn_Sales_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(UCD_Sales);
            UCD_Sales.Dock = DockStyle.Fill;
        }
    }
}
