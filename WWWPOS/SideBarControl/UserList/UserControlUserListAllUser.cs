using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WWWPOS.SideBarControl.UserList
{
    public partial class UserControlUserListAllUser : UserControl
    {
        public UserControlUserListAllUser()
        {
            InitializeComponent();
        }

        private void UserControlUserListAllUser_Load(object sender, EventArgs e)
        {
            loadData LD = new loadData();
            LD.customerData(dataGridCustomer);
            LD.adminData(dataGridAdmin);
        }
    }
}
