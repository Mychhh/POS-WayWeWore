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
        public Form_Account(string userType, string accountName, string email, string password, int accountNumber, string address)
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
        public int AccountNumber { get; set; }
        public string Address { get; set; }

        private void lbl_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
