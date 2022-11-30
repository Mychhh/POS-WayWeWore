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
    public partial class UserControlUserListAddUser : UserControl
    {


        public UserControlUserListAddUser()
        {
            InitializeComponent();
        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            UserList.UserControlUserListAllUser UC_ALlUser = new UserControlUserListAllUser();

            //Main Panel
            Controls.Clear();
            Controls.Add(UC_ALlUser);
            UC_ALlUser.Dock = DockStyle.Fill;

        }
    }
}
