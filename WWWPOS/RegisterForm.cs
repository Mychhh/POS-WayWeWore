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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataReader mdr;

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Email.Text) || string.IsNullOrEmpty(txt_FullName.Text) || string.IsNullOrEmpty(txt_Address.Text) || string.IsNullOrEmpty(txt_Password.Text) || string.IsNullOrEmpty(txt_Phone.Text))
            {
                MessageBox.Show("Please input all requiremenst", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                connection.Open();
                string selectQuery = "SELECT * FROM waywewore.account WHERE Email = '" + txt_Email.Text + "';";
                command = new MySqlCommand(selectQuery, connection);
                mdr = command.ExecuteReader();
                if (mdr.Read())
                {
                    MessageBox.Show("Email Already Register!", "Info", MessageBoxButtons.OK ,MessageBoxIcon.Error);

                }
                else
                {
                    int phoneNumber = (int)Convert.ToInt64(txt_Phone.Text);
                    string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=waywewore;";
                    string iquery = "INSERT INTO account(`Full_Name`, `Email`, `Password`,`Phone`,`Address`) VALUES ('" + txt_FullName.Text + "', '" + txt_Email.Text + "', '" + txt_Password.Text + "', '" + phoneNumber + "', '" + txt_Address.Text + "')";


                    MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                    MySqlCommand commandDatabase = new MySqlCommand(iquery, databaseConnection);
                    commandDatabase.CommandTimeout = 60;

                    try
                    {
                        databaseConnection.Open();
                        MySqlDataReader myReader = commandDatabase.ExecuteReader();
                        databaseConnection.Close();
                    }
                    catch (Exception ex)
                    {
                        // Show any error message.
                        MessageBox.Show(ex.Message);
                    }
                    DialogResult dialogResult;
                    dialogResult = MessageBox.Show("Account Successfully Created!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    if (dialogResult == DialogResult.OK)
                    {
                        this.Hide();
                        Form form = new Form();
                        form.ShowDialog();
                    }
                }
                connection.Close();
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
