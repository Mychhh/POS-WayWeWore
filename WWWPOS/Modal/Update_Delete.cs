using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WWWPOS.Modal
{
    public partial class Update_Delete : Form
    {
        public Update_Delete()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       SideBarControl.UserControUserList userControl = new SideBarControl.UserControUserList();
        private void btn_UpdateUser_Click(object sender, EventArgs e)
        {
           
            DataBase DB = new DataBase();

            int phoneNumber = Int32.Parse(txt_Number.Text);
            int accountID = Int32.Parse(txt_AccountID.Text);

            DB.updateUser(accountID, txt_Name.Text, txt_Email.Text, txt_Password.Text, phoneNumber, txt_UserType.Text, txt_Address.Text, userControl.panel_UserList);
        }
    }
}
