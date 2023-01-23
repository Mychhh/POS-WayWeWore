using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WWWPOS.ErrorMessage;

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
            string email = txt_Email.Text;
            string password = txt_Password.Text;
            
            if (!DataBase.validEmail.IsMatch(email))
            {
                ErrorMessageDialogue errorMessageDialogue = new ErrorMessageDialogue("Invalid Email");
                errorMessageDialogue.ShowDialog();
            }
            else if (txt_Password.Text.Length < 8)
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
            else if (txt_Email.Text.Length == 0 || txt_Password.Text.Length == 0 || txt_Name.Text.Length == 0 || txt_Number.Text.Length == 0 || txt_Address.Text.Length == 0)
            {
                ErrorMessageDialogue errMessageDialogue = new ErrorMessageDialogue("Fill out required fields");
                errMessageDialogue.ShowDialog();
            }
            else
            {
                DataBase DB = new DataBase();

                long phoneNumber = Int64.Parse(txt_Number.Text);
                int accountID = Int32.Parse(txt_AccountID.Text);

                DB.UpdateUser(accountID, txt_Name.Text, txt_Email.Text, txt_Password.Text, phoneNumber, txt_UserType.Text, txt_Address.Text);

                DB.ActivityLog("OtherAccountUpdated", txt_Name.Text);

                UserControUserList UC_UserList = new UserControUserList();
                UserControlUserListAllUser UC_AllUser = new UserControlUserListAllUser();

                //ArchivePanel
                Controls.Clear();
                Controls.Add(UC_AllUser);
                UC_AllUser.Dock = DockStyle.Fill;
            }

        }

        private void txt_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != Convert.ToChar(Keys.Back) && ch != Convert.ToChar(Keys.Delete))
            {
                e.Handled = true;
            }
        }

        private void txt_Address_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Number_TextChanged(object sender, EventArgs e)
        {
            if (txt_Number.Text.Length > 11)
            {
                ErrorMessageDialogue errorMessageDialogue = new ErrorMessageDialogue("Maximum number reached");
                errorMessageDialogue.ShowDialog();
                txt_Number.Text = txt_Number.Text.Remove(11);
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
