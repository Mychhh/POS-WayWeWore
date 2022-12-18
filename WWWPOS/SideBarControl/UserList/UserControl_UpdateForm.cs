using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WWWPOS.SideBarControl.UserList
{
    public partial class UserControl_UpdateForm : UserControl
    {
        public UserControl_UpdateForm()
        {
            InitializeComponent();
        }
        private void btn_UpdateUser_Click(object sender, EventArgs e)
        {
            DataBase DB = new DataBase();

            int phoneNumber = Int32.Parse(txt_Number.Text);
            int accountID = Int32.Parse(txt_AccountID.Text);

            DB.UpdateUser(accountID, txt_Name.Text, txt_Email.Text, txt_Password.Text, phoneNumber, txt_UserType.Text, txt_Address.Text);

            UserControUserList UC_UserList = new UserControUserList();
            UserControlUserListAllUser UC_AllUser = new UserControlUserListAllUser();

            //ArchivePanel
            Controls.Clear();
            Controls.Add(UC_AllUser);
            UC_AllUser.Dock = DockStyle.Fill;
        }
    }
}
