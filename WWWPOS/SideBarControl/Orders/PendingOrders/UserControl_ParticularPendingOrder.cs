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
    public partial class UserControl_ParticularPendingOrder : UserControl
    {
        public UserControl_ParticularPendingOrder(int productid)
        {
            InitializeComponent();
        }
        public int productid
        {
            get => Int32.Parse(lbl_ProductID.Text);
            set => lbl_ProductID.Text = value + "";
        }

    }
}
