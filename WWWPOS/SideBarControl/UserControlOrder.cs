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
using WWWPOS.SideBarControl.Orders;

namespace WWWPOS.SideBarControl.UserList
{
    public partial class UserControlOrder : UserControl
    {
        public UserControlOrder()
        {
            InitializeComponent();
        }

        //method to view different usercontrol in Orders Module
        public void OrderView(UserControl UC1)
        {
            //InventoryPanel
            panel_Order.Controls.Clear();
            panel_Order.Controls.Add(UC1);
            UC1.Dock = DockStyle.Fill;
        }

        private void btn_Pending_Click(object sender, EventArgs e)
        {
            UserControlOrderPending UC_OrderPending = new UserControlOrderPending();

            //InventoryPanel
            this.panel_Order.Controls.Clear();
            this.panel_Order.Controls.Add(UC_OrderPending);
            UC_OrderPending.Dock = DockStyle.Fill;

            Class_LoadData loadData = new Class_LoadData();
            loadData.GetOrderID(UC_OrderPending.flPanel_PendingOrders);

            if (UC_OrderPending.flPanel_PendingOrders.Controls.Count == 0)
            {
                UserControl_NoOrder UC_NoOrder = new UserControl_NoOrder();
                UC_OrderPending.flPanel_PendingOrders.Controls.Add(UC_NoOrder);
            }
        }

        private void btn_Success_Click(object sender, EventArgs e)
        {
            UserControlOrderSuccess UC_OrderSuccess = new UserControlOrderSuccess();
            OrderView(UC_OrderSuccess);
        }

    }
}
