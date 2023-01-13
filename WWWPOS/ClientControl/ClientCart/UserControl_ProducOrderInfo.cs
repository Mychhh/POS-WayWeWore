using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WWWPOS.ClientControl.ClientCart
{
    public partial class UserControl_ProducOrderInfo : UserControl
    {
        public UserControl_ProducOrderInfo(string OrderID, string OrderDate)
        {
            InitializeComponent();
            lbl_OrderID.Text = OrderID;
            lbl_OrderDate.Text = OrderDate;
        }
    }
}
