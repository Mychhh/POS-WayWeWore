using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WWWPOS.ErrorMessage;
using WWWPOS.MessageFolder;

namespace WWWPOS
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        DataBase DB = new DataBase();

        private void btn_Login_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtBox_Email.Text) || string.IsNullOrEmpty(txtBox_Password.Text))
            {
                ErrorMessageDialogue errorMessageDialogue = new ErrorMessageDialogue("No Email or Password");
                errorMessageDialogue.ShowDialog();
            }
            else
            {
                DB.Login(txtBox_Email.Text, txtBox_Password.Text);
            }

        }

        private void btn_Client_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_ClientLandingPage client = new Form_ClientLandingPage();
            client.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_RegisterPage register = new Form_RegisterPage();
            register.ShowDialog();
        }

        private void btn_show_hide_pass_Click(object sender, EventArgs e)
        {
            if (txtBox_Password.UseSystemPasswordChar)
            {
                txtBox_Password.UseSystemPasswordChar = false;
                btn_show_hide_pass.Image = WWWPOS.Properties.Resources.hidePass;
            }
            else if (!txtBox_Password.UseSystemPasswordChar)
            {
                txtBox_Password.UseSystemPasswordChar = true;
                btn_show_hide_pass.Image = WWWPOS.Properties.Resources.showPass;

            }

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
        }
    }
}
