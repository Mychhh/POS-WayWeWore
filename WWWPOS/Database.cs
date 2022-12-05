using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using WWWPOS.SideBarControl.Inventory;
using System.Data;
using WWWPOS.SideBarControl.Products;

namespace WWWPOS
{

    internal class DataBase
    {
        public static string user_ID, message;
        SqlConnection connection = new SqlConnection("Data Source=MIKO\\SQLEXPRESS;Initial Catalog=waywewore;Integrated Security=True");
        SqlCommand command;
        SqlDataReader mdr;

        //Signup / add user
        public void insertAccount(string email, string name, string address, string password, int phoneNumber, string user_Type)
        {
            connection.Open();
            string selectQuery = "SELECT Email FROM account WHERE Email = '" + email + "';";
            command = new SqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();

            if (mdr.Read())
            {
                MessageBox.Show("Email Already Register!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                string iquery = "INSERT INTO account(Full_Name, Email, Password,Phone,Address,User_Type) VALUES ('" + name + "', '" + email + "', '" + password + "', '" + phoneNumber + "', '" + address + "','"+ user_Type + "')";

                SqlConnection databaseConnection = new SqlConnection("Data Source=MIKO\\SQLEXPRESS;Initial Catalog=waywewore;Integrated Security=True");
                SqlCommand commandDatabase = new SqlCommand(iquery, databaseConnection);
                commandDatabase.CommandTimeout = 60;

                try
                {
                    databaseConnection.Open();
                    SqlDataReader myReader = commandDatabase.ExecuteReader();
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
                    message = "Success";
                   
                }
            }
            connection.Close();
        }
        //login user
        public void Login(string email, string password)
        {
            connection.Open();
            string selectQuery = "SELECT * FROM account WHERE Email = '" + email + "' AND Password = '" + password + "';";
            command = new SqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();
           

            if (mdr.Read())
            {
                user_ID = mdr["Account_Id"].ToString();
                String userType = mdr["User_Type"].ToString();

                if (userType == "Client")
                {
                    WWWPOS.LoginPage.ActiveForm.Hide();
                    Client clientView = new Client(); ;
                    clientView.Show();
                }
                else if (userType == "Admin")
                {
                    WWWPOS.LoginPage.ActiveForm.Hide();
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
        //Add Products
        public void addProdducts(string product_Name, string product_Color, double product_Price, int product_Stock, string category ,string product_Size, string product_image, string Product_Description)
        {
            
            string id = DataBase.user_ID;
            int user_ID = Int32.Parse(id);

            connection.Open();
            string iquery = "INSERT INTO Products(Account_ID, Category, Product_Name, Color, Price ,Stocks, Product_images, Product_Size, Product_Description) VALUES ('" + user_ID + "' , '" + category + "', '" + product_Name + "', '" + product_Color + "', '" + product_Price + "', '" + product_Stock + "','"+ product_image + "','"+ product_Size + "','" + Product_Description + "')";

            SqlConnection databaseConnection = new SqlConnection("Data Source=MIKO\\SQLEXPRESS;Initial Catalog=waywewore;Integrated Security=True");
            SqlCommand commandDatabase = new SqlCommand(iquery, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                SqlDataReader myReader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Product add Successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            if (dialogResult == DialogResult.OK)
            {
                message = "Success";
            }
        }
    }

    class loadData: DataBase
    {
        SqlConnection connection = new SqlConnection("Data Source=MIKO\\SQLEXPRESS;Initial Catalog=waywewore;Integrated Security=True");
        SqlCommand command;
        SqlDataReader mdr;
        public void adminData(DataGridView dataAdmin)
        {
            connection.Open();

            SqlCommand sqlc = new SqlCommand("select * from account WHERE User_Type = 'Admin'", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlc);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataAdmin.DataSource = dt;

            connection.Close();
        }
        public void customerData(DataGridView dataCustomer)
        {
            connection.Open();

            SqlCommand sqlc = new SqlCommand("select * from account WHERE User_Type = 'Client'", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlc);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataCustomer.DataSource = dt;

            connection.Close();
        }

        public void selectProduct(TableLayoutPanel tableLayoutPanel, string productPanel)
        {
            try
            {
                connection.Open();

                string selectQuery = "SELECT * FROM Products;";
                command = new SqlCommand(selectQuery, connection);
                mdr = command.ExecuteReader();

                int x = 0, y = 0;

                while (mdr.Read())
                {
                    int id = int.Parse(mdr[0] + "");
                    string description = "" + mdr[9];
                    double price = Double.Parse(mdr[5] + "");
                    int stock = int.Parse(mdr[6] + "");
                    string color = "" + mdr[4];
                    string size = "" + mdr[8];

                    Image image = Image.FromFile(@"" + mdr[7]);

                    if(productPanel == "panelView")
                    {
                        UserControl_AdminViewProducts obj = new UserControl_AdminViewProducts(id, price, stock, color, size, description, image);
                        tableLayoutPanel.Controls.Add(obj, y, x);
                    }
                    else if(productPanel == "panelEdit")
                    {
                        UserControl_Update obj = new UserControl_Update(id, price, stock, color, size, description, image);
                        tableLayoutPanel.Controls.Add(obj, y, x);
                    }
                    else
                    {

                        UserControl_Delete obj = new UserControl_Delete(id, price, stock, color, size, description, image);
                        tableLayoutPanel.Controls.Add(obj, y, x);
                    }
                    
                    y++;
                    if (y >= 4)
                    {
                        y = 0;
                        x++;
                    }


                }
                mdr.Close();
                command.Clone();
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}