using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WWWPOS.ErrorMessage;

namespace WWWPOS
{
    public partial class Form_RegisterPage : Form
    {
        public Form_RegisterPage()
        {
            InitializeComponent();
        }
  
        DataBase data = new DataBase();
        private void btn_Login_Click(object sender, EventArgs e)
        {
            DataBase DB = new DataBase();

            string password = txt_Password.Text;
            string email = txt_Email.Text;

            if (txt_Email.Text.Length == 0 || txt_Password.Text.Length == 0 || txt_FullName.Text.Length == 0 || txt_Phone.Text.Length == 0 || txt_Address.Text.Length == 0)
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
                long phoneNumber = Int64.Parse(txt_Phone.Text);
                string user_Type = "Client";
                data.InsertAccount(txt_Email.Text, txt_FullName.Text, txt_Address.Text, txt_Password.Text, phoneNumber, user_Type);

                if(DataBase.message == "Success")
                {
                   this.Hide();
                   LoginPage loginPage = new LoginPage();
                   loginPage.ShowDialog();
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage loginPage = new LoginPage();
            loginPage.ShowDialog();
        }

        private void txt_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != Convert.ToChar(Keys.Back) && ch != Convert.ToChar(Keys.Delete))
            {
                e.Handled = true;
            }
        }

        private void txt_Phone_TextChanged(object sender, EventArgs e)
        {
            if (txt_Phone.Text.Length > 11)
            {
                ErrorMessageDialogue errorMessageDialogue = new ErrorMessageDialogue("Numbers maximum length reached");
                errorMessageDialogue.ShowDialog();
                txt_Phone.Text = txt_Phone.Text.Remove(11);
            }
        }
    }
}
