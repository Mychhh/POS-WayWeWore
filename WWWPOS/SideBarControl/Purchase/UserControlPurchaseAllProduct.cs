using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WWWPOS.SideBarControl.Purchase
{
    public partial class UserControlAllProduct : UserControl
    {
        public UserControlAllProduct()
        {
            InitializeComponent();
        }

        private void UserControlAllProduct_Load(object sender, EventArgs e)
        {
            Class_LoadData loadData = new Class_LoadData();
            loadData.GetPurchaseOrder(this.dataGridShort, "TShirt");

            loadData.GetPurchaseOrder(this.dataGridTShirt, "Short");
        }
    }
}
