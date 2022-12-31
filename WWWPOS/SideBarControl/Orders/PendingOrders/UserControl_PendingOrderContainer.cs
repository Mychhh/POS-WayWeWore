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
    }
}
