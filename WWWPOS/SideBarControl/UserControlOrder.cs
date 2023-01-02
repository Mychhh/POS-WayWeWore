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
            OrderView(UC_OrderPending);
        }

        private void btn_Success_Click(object sender, EventArgs e)
        {
            UserControlOrderSuccess UC_OrderSuccess = new UserControlOrderSuccess();
            OrderView(UC_OrderSuccess);
        }

        private void btn_Failed_Click(object sender, EventArgs e)
        {
            UserControlOrderFailed UC_OrderFailed = new UserControlOrderFailed();
            OrderView(UC_OrderFailed);
        }
    }
}
