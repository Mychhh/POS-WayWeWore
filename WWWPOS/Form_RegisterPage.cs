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
            if (string.IsNullOrEmpty(txt_Email.Text) || string.IsNullOrEmpty(txt_FullName.Text) || string.IsNullOrEmpty(txt_Address.Text) || string.IsNullOrEmpty(txt_Password.Text) || string.IsNullOrEmpty(txt_Phone.Text))
            {
                MessageBox.Show("Please input all requiremenst", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                int phoneNumber = Int32.Parse(txt_Phone.Text);
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
    }
}
