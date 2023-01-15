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
            Form_AdminHome.ActiveForm.Hide();

            Class_LoadData C_LoadData = new Class_LoadData();
            C_LoadData.UpdateAccount(txt_Name.Text, txt_Password.Text, Convert.ToInt32(txt_Number.Text), txt_Address.Text);
            this.Hide();
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
