using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WWWPOS.SideBarControl.Orders.PendingOrders
{
    public partial class UserControl_PendingOrderContainer : UserControl
    {
        public UserControl_PendingOrderContainer(int ordernumber)
        {
            InitializeComponent();

            OrderNumber = ordernumber;
        }

        public int OrderNumber
        {
            get => Int32.Parse(lbl_OrderNumber.Text);
            set => lbl_OrderNumber.Text = "Order Number : " + value + "";
        }

        private void UserControl_PendingOrderContainer_Load(object sender, EventArgs e)
        {
            //UserControl_ParticularPendingOrder UC_ParticularPendingOrder;

            //for (int i = 0; i <= 3; i++)
            //{
            //    switch (i)
            //    {
            //        case 1:
            //            UC_ParticularPendingOrder = new UserControl_ParticularPendingOrder(1);
            //            this.flPanel_ParticularItem.Controls.Add(UC_ParticularPendingOrder);
            //            break;
            //        case 2:
            //            UC_ParticularPendingOrder = new UserControl_ParticularPendingOrder(2);
            //            this.flPanel_ParticularItem.Controls.Add(UC_ParticularPendingOrder);
            //            break;
            //        case 3:
            //            UC_ParticularPendingOrder = new UserControl_ParticularPendingOrder(3);
            //            this.flPanel_ParticularItem.Controls.Add(UC_ParticularPendingOrder);
            //            break;
            //    }

            //}
                        
        }
    }
}
