using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WWWPOS.SideBarControl
{
    public partial class UserControlDashboard : UserControl
    {
        public UserControlDashboard()
        {
            InitializeComponent();
        }

        private void UserControlDashboard_Load(object sender, EventArgs e)
        {
            loadData ld = new loadData();
            
            string totalStocks = "";
            string totalUsers = "";

            lbl_Stocks.Text = ld.AllStocks(totalStocks);
            lbl_Users.Text = ld.AllUser(totalUsers);
        }
    }
}
