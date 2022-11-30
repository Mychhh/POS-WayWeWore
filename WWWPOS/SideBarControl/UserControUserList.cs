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
    public partial class UserControUserList : UserControl
    {
        public UserControUserList()
        {
            InitializeComponent();
        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            UserList.UserControlUserListAdmin UC_Admin = new UserList.UserControlUserListAdmin();

            panel_UserList.Controls.Clear();
            panel_UserList.Controls.Add(UC_Admin);
            UC_Admin.Dock = DockStyle.Fill;
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            UserList.UserControlUserListCustomer UC_Customer = new UserList.UserControlUserListCustomer();

            panel_UserList.Controls.Clear();
            panel_UserList.Controls.Add(UC_Customer);
            UC_Customer.Dock = DockStyle.Fill;
        }

        private void btn_AddUser_Click_1(object sender, EventArgs e)
        {
            UserList.UserControlUserListAddUser UC_AddUser = new UserList.UserControlUserListAddUser();

            panel_UserList.Controls.Clear();
            panel_UserList.Controls.Add(UC_AddUser);
            UC_AddUser.Dock = DockStyle.Fill;
        }
    }
}
