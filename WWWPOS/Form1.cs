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

        private void btn_Login_Click(object sender, EventArgs e)
        {
            //Removes the Login Page

            //Show the Form2
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void btn_Client_Click(object sender, EventArgs e)
        {
            this.Hide();
            Client client = new Client();
            client.ShowDialog();
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm register = new RegisterForm();
            register.ShowDialog();
        }
    }
}
