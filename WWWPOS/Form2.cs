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
        SideBarControl.UserControlDashboard UC_Dashboard = new SideBarControl.UserControlDashboard();
        SideBarControl.UserControlSales UC_Sales = new SideBarControl.UserControlSales();
        SideBarControl.UserControlPurchase UC_Purchase = new SideBarControl.UserControlPurchase();
        SideBarControl.UserControUserList UC_UserList = new SideBarControl.UserControUserList();
        SideBarControl.UserControlArchive UC_Archive = new SideBarControl.UserControlArchive();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //panel_Main.Controls.Clear();
            panel_Main.Controls.Add(UC_Dashboard);
            UC_Dashboard.Dock = DockStyle.Fill;
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(UC_Dashboard);
            UC_Dashboard.Dock = DockStyle.Fill;
        }

        private void btn_Sales_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(UC_Sales);
            UC_Sales.Dock = DockStyle.Fill;
        }

        private void btn_Purchase_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(UC_Purchase);
            UC_Purchase.Dock = DockStyle.Fill;
        }

        private void btn_UserList_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(UC_UserList);
            UC_UserList.Dock = DockStyle.Fill;
        }

        private void btn_Archive_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(UC_Archive);
            UC_Archive.Dock = DockStyle.Fill;
        }
    }
}
