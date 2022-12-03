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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataReader mdr ,mdru;
        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBox_Email.Text) || string.IsNullOrEmpty(txtBox_Password.Text))
            {
                MessageBox.Show("Please input Email and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                connection.Open();
                string selectQuery = "SELECT * FROM waywewore.account WHERE Email = '" + txtBox_Email.Text + "' AND Password = '" + txtBox_Password.Text + "';";
                command = new MySqlCommand(selectQuery, connection);
                mdr = command.ExecuteReader();

                if (mdr.Read())
                {
                    String userType = mdr.GetString("User_Type");
                    if(userType == "Client")
                    {
                        this.Hide();
                        Client clientView = new Client(); ;
                        clientView.Show();
                    }
                    else if(userType == "Admin")
                    {
                        this.Hide();
                        Form2 f2 = new Form2();
                        f2.ShowDialog();
                    }
                     
                }
                else
                {

                    MessageBox.Show("Incorrect Login Information! Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                connection.Close();
            }
           
        }

        private void btn_Client_Click(object sender, EventArgs e)
        {
            this.Hide();
            Client client = new Client();
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
    }
}
