using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using WWWPOS.ErrorMessage;

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

            string password = txt_Password.Text;
            string email = txt_Email.Text;

            if(txt_Email.Text.Length == 0 || txt_Password.Text.Length == 0 || txt_Name.Text.Length == 0 || txt_Number.Text.Length == 0 || txt_Address.Text.Length == 0)
            {
                ErrorMessageDialogue errMessageDialogue = new ErrorMessageDialogue("Fill out required fields");
                errMessageDialogue.ShowDialog();
            }
            else if (txt_Password.Text.Length != 8)
            {
                ErrorMessageDialogue errMessageDialogue = new ErrorMessageDialogue("Password must be 8 characters");
                errMessageDialogue.ShowDialog();
            }
            else if (!DataBase.hasNumber.IsMatch(password))
            {
                ErrorMessageDialogue errMessageDialogue = new ErrorMessageDialogue("Password must have at least 1 number");
                errMessageDialogue.ShowDialog();
            }
            else if (!DataBase.hasUpper.IsMatch(password))
            {
                ErrorMessageDialogue errMessageDialogue = new ErrorMessageDialogue("Password must have at least 1 uppercase letter");
                errMessageDialogue.ShowDialog();
            }
            else if (!DataBase.hasLower.IsMatch(password))
            {
                ErrorMessageDialogue errMessageDialogue = new ErrorMessageDialogue("Password must have at least 1 lowercase letter");
                errMessageDialogue.ShowDialog();
            }
            else if (!DataBase.hasSymbol.IsMatch(password))
            {
                ErrorMessageDialogue errMessageDialogue = new ErrorMessageDialogue("Password must have at least 1 non-alphanumeric character");
                errMessageDialogue.ShowDialog();
            }
            else if (!DataBase.validEmail.IsMatch(email))
            {
                ErrorMessageDialogue errorMessageDialogue = new ErrorMessageDialogue("Invalid Email");
                errorMessageDialogue.ShowDialog();
            }
            else
            {
                int phoneNumber = Int32.Parse(txt_Number.Text);
                DB.InsertAccount(txt_Email.Text, txt_Name.Text, txt_Address.Text, txt_Password.Text, phoneNumber, cmb_UserType.Text);
            }

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

        private void btn_show_hide_pass_Click(object sender, EventArgs e)
        {
            if (txt_Password.UseSystemPasswordChar)
            {
                txt_Password.UseSystemPasswordChar = false;
                btn_show_hide_pass.Image = WWWPOS.Properties.Resources.hidePass;
            }
            else if (!txt_Password.UseSystemPasswordChar)
            {
                txt_Password.UseSystemPasswordChar = true;
                btn_show_hide_pass.Image = WWWPOS.Properties.Resources.showPass;

            }
        }
    }
}
