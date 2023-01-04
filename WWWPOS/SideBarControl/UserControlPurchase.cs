using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WWWPOS.SideBarControl
{
    public partial class UserControlPurchase : UserControl
    {
        public UserControlPurchase()
        {
            InitializeComponent();
        }

        private void btn_Tshirt_Click(object sender, EventArgs e)
        {
            Purchase.UserControlPurchaseTshirt UC_PurchaseTshirt = new Purchase.UserControlPurchaseTshirt();

            panel_Purchase.Controls.Clear();
            panel_Purchase.Controls.Add(UC_PurchaseTshirt);
            UC_PurchaseTshirt.Dock = DockStyle.Fill;

            Class_LoadData loadData = new Class_LoadData();
            loadData.GetPurchaseOrder(UC_PurchaseTshirt.dataGridSuccessOrders, "TShirt");
        }

        private void btn_Short_Click(object sender, EventArgs e)
        {
            Purchase.UserControlPurchaseShort UC_PurchaseShort = new Purchase.UserControlPurchaseShort();

            panel_Purchase.Controls.Clear();
            panel_Purchase.Controls.Add(UC_PurchaseShort);
            UC_PurchaseShort.Dock = DockStyle.Fill;

            Class_LoadData loadData = new Class_LoadData();
            loadData.GetPurchaseOrder(UC_PurchaseShort.dataGridSuccessOrders, "Short");

        }
    }
}
