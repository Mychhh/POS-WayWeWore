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
    public partial class UserControl_ProductItem : UserControl
    {
        public UserControl_ProductItem(string name, int qty, int total)
        {
            InitializeComponent();
            lbl_ProductName.Text = name;
            lbl_Qty.Text = "X"+qty.ToString();
            lbl_Subtotal.Text = total.ToString();
        }
    }
}
