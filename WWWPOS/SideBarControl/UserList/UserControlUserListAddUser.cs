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
            DataBase DB = new DataBase();

            int phoneNumber = Int32.Parse(txt_Number.Text);

            DB.InsertAccount(txt_Email.Text, txt_Name.Text, txt_Address.Text, txt_Password.Text, phoneNumber, cmb_UserType.Text );

            if (DataBase.message == "Success")
            {
                UserList.UserControlUserListAllUser UC_AllUser = new UserControlUserListAllUser();

                //Main Panel
                Controls.Clear();
                Controls.Add(UC_AllUser);
                UC_AllUser.Dock = DockStyle.Fill;
                DataBase.message = "";
            }
        }
    }
}
