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
        public UserControl_ParticularPendingOrder(string productname, string category, string color, string size, double price, int quantity, int total)
        {
            InitializeComponent();

            ProductID = productname;
            Category = category;
            PColor = color;
            PSize = size;
            Price = price;
            Quantity = quantity;
            Total = total;
        }
        public string ProductID
        {
            get => lbl_ProductID.Text;
            set => lbl_ProductID.Text = value + "";
        }
        public string Category
        {
            get => lbl_Category.Text;
            set => lbl_Category.Text = value + "";
        }
        public string PColor
        {
            get => lbl_Color.Text;
            set => lbl_Color.Text = value + "";
        }
        public string PSize
        {
            get => lbl_Size.Text;
            set => lbl_Size.Text = value + "";
        }
        public double Price
        {
            get => Convert.ToDouble(lbl_Size.Text);
            set => lbl_Prize.Text = value + "";
        }
        public int Quantity
        {
            get => Int32.Parse(lbl_Quantity.Text);
            set => lbl_Quantity.Text = value + "";
        }
        public int Total
        {
            get => Int32.Parse(lbl_ItemTotal.Text);
            set => lbl_ItemTotal.Text = value + "";
        }
    }
}
