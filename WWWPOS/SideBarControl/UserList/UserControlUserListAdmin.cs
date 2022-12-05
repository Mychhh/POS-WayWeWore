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
    public partial class UserControlUserListAdmin : UserControl
    {
        public UserControlUserListAdmin()
        {
            InitializeComponent();
        }

        private void UserControlUserListAdmin_Load(object sender, EventArgs e)
        {
            loadData LD = new loadData();

            LD.adminData(dataGrid_Admin);
        }
    }
}
