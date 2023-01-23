using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WWWPOS.ErrorMessage;

namespace WWWPOS
{
    public partial class Form_Account : Form
    {
        public Form_Account(string userType, string accountName, string email, string password, long accountNumber, string address)
        {
            InitializeComponent();
            UserType = userType;
            AccountName = accountName;
            Email = email;
            Password = password;
            AccountNumber = accountNumber;
            Address = address;

            lbl_UserType.Text = UserType;
            txt_Name.Text = AccountName;
            txt_Email.Text = Email;
            txt_Password.Text = Password;
            txt_Number.Text = AccountNumber.ToString();
            txt_Address.Text = Address;

        }

        public string UserType { get; set; }
        public string AccountName { get; set; }
        public string Email { get ; set; }
        public string Password { get; set; }
        public long AccountNumber { get; set; }
        public string Address { get; set; }

        private void lbl_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {

            string password = txt_Password.Text;
            string email = txt_Email.Text;

            if (txt_Email.Text.Length == 0 || txt_Password.Text.Length == 0 || txt_Name.Text.Length == 0 || txt_Number.Text.Length == 0 || txt_Address.Text.Length == 0)
            {
                ErrorMessageDialogue errMessageDialogue = new ErrorMessageDialogue("Fill out required fields");
                errMessageDialogue.ShowDialog();
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
            else if (!DataBase.validEmail.IsMatch(email))
            {
                ErrorMessageDialogue errorMessageDialogue = new ErrorMessageDialogue("Invalid Email");
                errorMessageDialogue.ShowDialog();
            }
            else
            {
                if(DataBase.userType == "Admin")
                {
                    DataBase DB = new DataBase();
                    DB.ActivityLog("MyAccountUpdated");
                }

                MessageFolder.SuccessMessageDialogue successMessageDialogue = new MessageFolder.SuccessMessageDialogue("Updated Succesfully");
                successMessageDialogue.ShowDialog();

                Form_AdminHome.ActiveForm.Hide();

                Class_LoadData C_LoadData = new Class_LoadData();
                C_LoadData.UpdateAccount(txt_Name.Text, txt_Password.Text, Convert.ToInt64(txt_Number.Text), txt_Address.Text);
                this.Hide();
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

        private void txt_Number_TextChanged(object sender, EventArgs e)
        {
            if (txt_Number.Text.Length > 11)
            {
                ErrorMessageDialogue errorMessageDialogue = new ErrorMessageDialogue("Numbers maximum length reached");
                errorMessageDialogue.ShowDialog();
                txt_Number.Text = txt_Number.Text.Remove(11);
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
    }
}
