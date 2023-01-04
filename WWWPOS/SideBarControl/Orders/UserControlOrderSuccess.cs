using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WWWPOS.SideBarControl.Orders
{
    public partial class UserControlOrderSuccess : UserControl
    {
        public UserControlOrderSuccess()
        {
            InitializeComponent();
        }

        private void UserControlOrderSuccess_Load(object sender, EventArgs e)
        {
            Class_LoadData loadData = new Class_LoadData();
            loadData.GetSuccessOrders(this.dataGridSuccessOrders);
        }
    }
}
