using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                MessageBox.Show("Please input Email and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DB.Login(txtBox_Email.Text, txtBox_Password.Text);
            }
           
        }

        private void btn_Client_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientForm client = new ClientForm();
            client.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm register = new RegisterForm();
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
    }
}
