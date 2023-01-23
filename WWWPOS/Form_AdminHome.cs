using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using WWWPOS.SideBarControl;
using WWWPOS.SideBarControl.Inventory;
using WWWPOS.SideBarControl.Orders;
using WWWPOS.SideBarControl.Products;
using WWWPOS.SideBarControl.UserList;

namespace WWWPOS
{
    public partial class Form_AdminHome : Form
    {
        
        MenuControl.UserControl_Menu UC_Menu = new MenuControl.UserControl_Menu();

        public Form_AdminHome()
        {
            InitializeComponent();
            
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            lbl_AdminName.Text = DataBase.user_Name;

            //Checks if the user is Already Login
            switch (DataBase.isLogin)
            {
                case true:

                    if(DataBase.fromWhat == "OrdersDelete")
                    {
                        UserControlOrder UC_Order = new UserControlOrder();

                        DataBase.fromWhat = "";

                        //Main Panel
                        panel_Main.Controls.Clear();
                        panel_Main.Controls.Add(UC_Order);
                        UC_Order.Dock = DockStyle.Fill;

                        UserControlOrderPending UC_OrderPending = new UserControlOrderPending();
                        //OrderPending FlowLayout Panel
                        UC_Order.panel_Order.Controls.Clear();
                        UC_Order.panel_Order.Controls.Add(UC_OrderPending);
                        UC_OrderPending.Dock = DockStyle.Fill;

                        Class_LoadData loadData = new Class_LoadData();
                        loadData.GetOrderID(UC_OrderPending.flPanel_PendingOrders);

                    }
                    else if (DataBase.fromWhat == "InventoryDelete")
                    {
                        DataBase.fromWhat = "";

                        UserControlInventory UC_Inventory = new UserControlInventory();
                        //UserControlRead UC_Read = new UserControlRead();

                        //Main Panel
                        panel_Main.Controls.Clear();
                        panel_Main.Controls.Add(UC_Inventory);
                        UC_Inventory.Dock = DockStyle.Fill;

                        UserControlViewUpdate UC_ViewUpdate = new UserControlViewUpdate();
                        //Inventory Panel
                        UC_Inventory.panel_Inventory.Controls.Clear();
                        UC_Inventory.panel_Inventory.Controls.Add(UC_ViewUpdate);
                        UC_ViewUpdate.Dock = DockStyle.Fill;

                        //Loads product item
                        Class_LoadData LD = new Class_LoadData();
                        LD.selectProduct(UC_ViewUpdate.flowLayoutPanel, "panelDelete");
                    }
                    else if (DataBase.fromWhat == "InventoryUpdate")
                    {
                        DataBase.fromWhat = "";

                        UserControlInventory UC_Inventory = new UserControlInventory();
                        //UserControlRead UC_Read = new UserControlRead();

                        //Main Panel
                        panel_Main.Controls.Clear();
                        panel_Main.Controls.Add(UC_Inventory);
                        UC_Inventory.Dock = DockStyle.Fill;

                        UserControlViewUpdate UC_ViewUpdate = new UserControlViewUpdate();
                        //Inventory Panel
                        UC_Inventory.panel_Inventory.Controls.Clear();
                        UC_Inventory.panel_Inventory.Controls.Add(UC_ViewUpdate);
                        UC_ViewUpdate.Dock = DockStyle.Fill;

                        //Loads product item
                        Class_LoadData LD = new Class_LoadData();
                        LD.selectProduct(UC_ViewUpdate.flowLayoutPanel, "panelEdit");
                    }
                    else if (DataBase.fromWhat == "InventoryUpdateUserControl")
                    {
                        DataBase.fromWhat = "";

                        UserControlInventory UC_Inventory = new UserControlInventory();
                        //UserControlRead UC_Read = new UserControlRead();

                        //Main Panel
                        panel_Main.Controls.Clear();
                        panel_Main.Controls.Add(UC_Inventory);
                        UC_Inventory.Dock = DockStyle.Fill;

                        UserControlViewUpdate UC_ViewUpdate = new UserControlViewUpdate();
                        //Inventory Panel
                        UC_Inventory.panel_Inventory.Controls.Clear();
                        UC_Inventory.panel_Inventory.Controls.Add(UC_ViewUpdate);
                        UC_ViewUpdate.Dock = DockStyle.Fill;

                        //loads update user control
                        //UserControlUpdate userControlUpdate = new UserControlUpdate();
                        try
                        {
                            UC_ViewUpdate.flowLayoutPanel.Controls.Add(UserControl_Update.UC_Update);
                        }
                        catch
                        {
                            UserControlUpdate UC_Update = new UserControlUpdate();
                            UC_ViewUpdate.flowLayoutPanel.Controls.Add(UC_Update);
                        }
                    }


                    break;

                case false:
                    Class_LoadData class_LoadData = new Class_LoadData();

                    UserControlDashboard UC_Dashboard = new UserControlDashboard();

                    class_LoadData.LoadChartSales(UC_Dashboard);

                    //panel_Main.Controls.Clear();
                    panel_Main.Controls.Add(UC_Dashboard);
                    UC_Dashboard.Dock = DockStyle.Fill;
                    DataBase.isLogin = true;
                    break;
            }
        }
        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            Class_LoadData class_LoadData = new Class_LoadData();

            SideBarControl.UserControlDashboard UC_Dashboard = new SideBarControl.UserControlDashboard();

            class_LoadData.LoadChartSales(UC_Dashboard);

            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(UC_Dashboard);
            UC_Dashboard.Dock = DockStyle.Fill;
        }
        private void btn_Sales_Click(object sender, EventArgs e)
        {
            Class_LoadData class_LoadData = new Class_LoadData();

            SideBarControl.UserControlSales UC_Sales = new SideBarControl.UserControlSales();

            class_LoadData.GetDesiredChartData(UC_Sales, "SELECT ProductID, Name, Category, Quantity  FROM Orders WHERE OrderStatus = 'Success'", "AllProduct");

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
        private void btn_Inventory_Click(object sender, EventArgs e)
        {
            UserControlInventory UC_Inventory = new UserControlInventory();
            UserControlRead UC_Read = new UserControlRead();

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
            panel_Menu.Visible = !panel_Menu.Visible;
        }
        private void btn_Orders_Click(object sender, EventArgs e)
        {
            UserControlOrder UC_Order = new UserControlOrder();
            UserControlOrderPending UC_OrderPending = new UserControlOrderPending();

            //Main Panel
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(UC_Order);
            UC_Order.Dock = DockStyle.Fill;

            //InventoryPanel
            UC_Order.panel_Order.Controls.Clear();
            UC_Order.panel_Order.Controls.Add(UC_OrderPending);
            UC_OrderPending.Dock = DockStyle.Fill;

            //UserControlOrderPending UC_OrderPending = new UserControlOrderPending();

            Class_LoadData loadData = new Class_LoadData();
            loadData.GetOrderID(UC_OrderPending.flPanel_PendingOrders);

            if (UC_OrderPending.flPanel_PendingOrders.Controls.Count == 0)
            {
                UserControl_NoOrder UC_NoOrder = new UserControl_NoOrder();
                UC_OrderPending.flPanel_PendingOrders.Controls.Add(UC_NoOrder);
            }
        }
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DataBase.isLogin = false;
            WWWPOS.Form_AdminHome.ActiveForm.Hide();
            DataBase.login.Show();
            DataBase.login.txtBox_Email.Clear();
            DataBase.login.txtBox_Password.Clear();
        }
        private void btn_Account_Click(object sender, EventArgs e)
        {
            Class_LoadData C_LoadData = new Class_LoadData();
            C_LoadData.GetAccount();
        }
        private void btn_ActivityLog_Click(object sender, EventArgs e)
        {
            //Main Panel
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(Class_LoadData.UC_ActivityLog);
            Class_LoadData.UC_ActivityLog.Dock = DockStyle.Fill;
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

        //Hover Effects
        private void btn_Dashboard_MouseHover(object sender, EventArgs e)
        {
            btn_Dashboard.Width = 255;
            btn_Dashboard.Height = 48;
        }

        private void btn_Dashboard_MouseLeave(object sender, EventArgs e)
        {
            btn_Dashboard.Width = 252;
            btn_Dashboard.Height = 45;
        }
        private void btn_Sales_MouseHover(object sender, EventArgs e)
        {
            btn_Sales.BackColor = Color.FromArgb(234, 223, 91);
            btn_Sales.Width = 255;
            btn_Sales.Height = 48;
        }

        private void btn_Sales_MouseLeave(object sender, EventArgs e)
        {
            btn_Sales.BackColor = Color.FromArgb(231, 198, 116);
            btn_Sales.Width = 252;
            btn_Sales.Height = 45;
        }

        private void btn_Purchase_MouseHover(object sender, EventArgs e)
        {
            btn_Purchase.BackColor = Color.FromArgb(234, 223, 91);
            btn_Purchase.Width = 255;
            btn_Purchase.Height = 48;
        }

        private void btn_Purchase_MouseLeave(object sender, EventArgs e)
        {
            btn_Purchase.BackColor = Color.FromArgb(231, 198, 116);
            btn_Purchase.Width = 252;
            btn_Purchase.Height = 45;
        }

        private void btn_Inventory_MouseHover(object sender, EventArgs e)
        {
            btn_Inventory.BackColor = Color.FromArgb(234, 223, 91);
            btn_Inventory.Width = 255;
            btn_Inventory.Height = 48;
        }

        private void btn_Inventory_MouseLeave(object sender, EventArgs e)
        {
            btn_Inventory.BackColor = Color.FromArgb(231, 198, 116);
            btn_Inventory.Width = 252;
            btn_Inventory.Height = 45;
        }

        private void btn_Orders_MouseHover(object sender, EventArgs e)
        {
            btn_Orders.BackColor = Color.FromArgb(234, 223, 91);
            btn_Orders.Width = 255;
            btn_Orders.Height = 48;
        }

        private void btn_Orders_MouseLeave(object sender, EventArgs e)
        {
            btn_Orders.BackColor = Color.FromArgb(231, 198, 116);
            btn_Orders.Width = 252;
            btn_Orders.Height = 45;
        }

        private void btn_UserList_MouseHover(object sender, EventArgs e)
        {
            btn_UserList.BackColor = Color.FromArgb(234, 223, 91);
            btn_UserList.Width = 255;
            btn_UserList.Height = 48;
        }

        private void btn_UserList_MouseLeave(object sender, EventArgs e)
        {
            btn_UserList.BackColor = Color.FromArgb(231, 198, 116);
            btn_UserList.Width = 252;
            btn_UserList.Height = 45;
        }

        private void btn_ActivityLog_MouseHover(object sender, EventArgs e)
        {
            btn_ActivityLog.BackColor = Color.FromArgb(234, 223, 91);
            btn_ActivityLog.Width = 255;
            btn_ActivityLog.Height = 48;
        }

        private void btn_ActivityLog_MouseLeave(object sender, EventArgs e)
        {
            btn_ActivityLog.BackColor = Color.FromArgb(231, 198, 116);
            btn_ActivityLog.Width = 252;
            btn_ActivityLog.Height = 45;
        }

        private void btn_Archive_MouseHover(object sender, EventArgs e)
        {
            btn_Archive.BackColor = Color.FromArgb(234, 223, 91);
            btn_Archive.Width = 255;
            btn_Archive.Height = 48;
        }

        private void btn_Archive_MouseLeave(object sender, EventArgs e)
        {
            btn_Archive.BackColor = Color.FromArgb(231, 198, 116);
            btn_Archive.Width = 252;
            btn_Archive.Height = 45;
        }

    }
}
