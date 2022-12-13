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

namespace WWWPOS
{
    public partial class Form2 : Form
    {

        MenuControl.UserControl_Menu UC_Menu = new MenuControl.UserControl_Menu();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SideBarControl.UserControlDashboard UC_Dashboard = new SideBarControl.UserControlDashboard();

            //panel_Main.Controls.Clear();
            panel_Main.Controls.Add(UC_Dashboard);
            UC_Dashboard.Dock = DockStyle.Fill;
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            SideBarControl.UserControlDashboard UC_Dashboard = new SideBarControl.UserControlDashboard();

            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(UC_Dashboard);
            UC_Dashboard.Dock = DockStyle.Fill;
        }

        private void btn_Sales_Click(object sender, EventArgs e)
        {
            SideBarControl.UserControlSales UC_Sales = new SideBarControl.UserControlSales();

            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(UC_Sales);
            UC_Sales.Dock = DockStyle.Fill; 
        }

        private void btn_Purchase_Click(object sender, EventArgs e)
        {
            SideBarControl.UserControlPurchase UC_Purchase = new SideBarControl.UserControlPurchase();
            SideBarControl.Purchase.UserControlAllProduct UC_AllPurchase = new SideBarControl.Purchase.UserControlAllProduct();

            //Main Panel
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(UC_Purchase);
            UC_Purchase.Dock = DockStyle.Fill;

            //ArchivePanel
            UC_Purchase.panel_Purchase.Controls.Clear();
            UC_Purchase.panel_Purchase.Controls.Add(UC_AllPurchase);
            UC_AllPurchase.Dock = DockStyle.Fill;
        }

        private void btn_UserList_Click(object sender, EventArgs e)
        {
            SideBarControl.UserControUserList UC_UserList = new SideBarControl.UserControUserList();
            SideBarControl.UserList.UserControlUserListAllUser UC_AllUser = new SideBarControl.UserList.UserControlUserListAllUser();

            //Main Panel
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(UC_UserList);
            UC_UserList.Dock = DockStyle.Fill;

            //ArchivePanel
            UC_UserList.panel_UserList.Controls.Clear();
            UC_UserList.panel_UserList.Controls.Add(UC_AllUser);
            UC_AllUser.Dock = DockStyle.Fill;
        }

        private void btn_Archive_Click(object sender, EventArgs e)
        {
            SideBarControl.UserControlArchive UC_Archive = new SideBarControl.UserControlArchive();
            SideBarControl.Archive.UserControlArchiveAll UC_AllArchive = new SideBarControl.Archive.UserControlArchiveAll();

            //Main Panel
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(UC_Archive);
            UC_Archive.Dock = DockStyle.Fill;

            //ArchivePanel
            UC_Archive.panel_Archive.Controls.Clear();
            UC_Archive.panel_Archive.Controls.Add(UC_AllArchive);
            UC_AllArchive.Dock = DockStyle.Fill;
        }

        private void btn_Inventory_Click(object sender, EventArgs e)
        {
            SideBarControl.UserControlInventory UC_Inventory = new SideBarControl.UserControlInventory();
            UserControlRead UC_Read = new SideBarControl.Inventory.UserControlRead();

            //Main Panel
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(UC_Inventory);
            UC_Inventory.Dock = DockStyle.Fill;

            //InventoryPanel
            UC_Inventory.Refresh();
            UC_Inventory.panel_Inventory.Controls.Clear();
            UC_Inventory.panel_Inventory.Controls.Add(UC_Read);
            UC_Read.Dock = DockStyle.Fill;
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            panel_Menu.Controls.Clear();
            panel_Menu.Controls.Add(UC_Menu);
            UC_Menu.Dock = DockStyle.Fill;

            if (!UC_Menu.Visible)
            {
                UC_Menu.Show();
                panel_Menu.Size = new Size(214, 140);
                panel_Menu.Location = new Point(813, 41);
            }
            else if (UC_Menu.Visible)
            {
                UC_Menu.Hide();
                panel_Menu.Size = new Size(0, 0);
                panel_Menu.Location = new Point(859, 41);
            }

        }
    }
}
