using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using WWWPOS.SideBarControl.Products;
using WWWPOS.SideBarControl.Inventory;
using WWWPOS.SideBarControl;
using WWWPOS.SideBarControl.UserList;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using WWWPOS.ClientControl.Products;

namespace WWWPOS
{

    internal class DataBase
    {
        public static string user_ID, message;
        public const string SQLServerLink = "Data Source=DESKTOP-83HB1MK\\SQLEXPRESS; Initial Catalog=waywewore; Integrated Security=True";
        protected  SqlConnection connection = new SqlConnection(SQLServerLink);
        protected SqlCommand command;
        protected SqlDataReader mdr;

        //About User

        //Signup and Add user
        public void InsertAccount(string email, string name, string address, string password, int phoneNumber, string user_Type)
        {
            connection.Open();
            string selectQuery = "SELECT Email FROM account WHERE Email = '" + email + "';";
            command = new SqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();

            if (mdr.Read())
            {
                MessageBox.Show("Email Already Register!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
            else
            {
                connection.Close(); //closes the first connection used by checking if the email is already registered

                connection.Open();
                string insertQuery = "INSERT INTO account(Full_Name, Email, Password,Phone,Address, User_Status, User_Type) VALUES ('" + name + "', '" + email + "', '" + password + "', '" + phoneNumber + "', '" + address + "','"  + "Active" + "','" + user_Type + "')";
                SqlCommand commandDatabase = new SqlCommand(insertQuery, connection);
                commandDatabase.CommandTimeout = 60;

                try
                {
                    SqlDataReader myReader = commandDatabase.ExecuteReader();
                    connection.Close();
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
        }
        
        //Login User
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

        //Update account
        public void UpdateUser(int account_ID, string user_Name, string email, string password, int phone, string user_Type, string address)
        {
            connection.Open();
            string selectQuery = "UPDATE account SET Full_Name = '" + user_Name + "', Email = '" + email + "', Password = '" + password + "', Phone = '" + phone + "', User_Type = '" + user_Type + "', Address = '"+address +"' WHERE Account_Id ='" + account_ID+"';";
            command = new SqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();
            connection.Close();
    
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Updated Successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            if (dialogResult == DialogResult.OK)
            {
                message = "Success";
            }

        }
        
        //Delete and restore account
        public void SetStatusUser(string user_Status, int account_ID)
        {
            connection.Open();
            string selectQuery = "UPDATE account SET User_Status = '" + user_Status + "' WHERE Account_Id ='" + account_ID + "';";
            command = new SqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();
            connection.Close();

            DialogResult dialogResult;
            if(user_Status == "Inactive")
            {
                dialogResult = MessageBox.Show("Deleted Successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); ;

            }
           else
            {
                dialogResult = MessageBox.Show("Restored Successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); ;

            }
        }

        //About Products

        //Add Products
        public void AddProdducts(string product_Name, string product_Color, double product_Price, int product_Stock, string category ,string product_Size, string product_image, string Product_Description)
        {
            
            string id = DataBase.user_ID;
            int user_ID = Int32.Parse(id);

            connection.Open();
            string iquery = "INSERT INTO Products(Account_ID, Category, Product_Name, Color, Price ,Stocks, Product_images, Product_Size, Product_Description, Product_Status) VALUES ('" + user_ID + "' , '" + category + "', '" + product_Name + "', '" + product_Color + "', '" + product_Price + "', '" + product_Stock + "','"+ product_image + "','"+ product_Size + "','" + Product_Description + "','Active')";
            SqlCommand commandDatabase = new SqlCommand(iquery, connection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                SqlDataReader myReader = commandDatabase.ExecuteReader();
                connection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Product added Successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            if (dialogResult == DialogResult.OK)
            {
                message = "Success";
            }
        }

        //Update Products
        public void UpdateProducts(int productID, string category, string name, string color, double price, int stock, string size, string description)
        {
            connection.Open();
            string selectQuery = "UPDATE Products SET Category='" + category + "',Product_Name='" + name + "',Color='" + color + "',Price='" + price + "',Stocks='" + stock + "',Product_Size='" + size + "',Product_Description='" + description + "' WHERE Product_ID ='" + productID + "';";
            command = new SqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();
            connection.Close();

            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Updated Successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            if (dialogResult == DialogResult.OK)
            {
                //dito lagay code pag sucess updated un products pabalik sa edit products view
            }
        }

        //Delete and restore products
        public void SetStatusProducts(string product_Status, int product_ID)
        {

            connection.Open();
            string selectQuery = "UPDATE Products SET Product_Status = '" + product_Status + "' WHERE Product_ID ='" + product_ID + "';";
            command = new SqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();
            connection.Close();

            DialogResult dialogResult;

            if (product_Status == "Inactive")
            {
                dialogResult = MessageBox.Show("Deleted Successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); ;

            }
            else
            {
                dialogResult = MessageBox.Show("Restored Successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); ;

            }

        }

    }

    class loadData : DataBase
    {
        //-----Admin Side-----//    
        //User not Delete
        public void userRecords(DataGridView dataCustomer, string user_Type, string user_Status)
        {
          
            connection.Open();
            command = new SqlCommand("SELECT * FROM account WHERE User_Type = '"+user_Type+"' AND User_Status = '"+ user_Status+ "'", connection);
            mdr = command.ExecuteReader();

            while (mdr.Read())
            {
                dataCustomer.Rows.Add(mdr[0].ToString(), mdr[1].ToString(), mdr[2].ToString(), mdr[3].ToString(), mdr[4].ToString(), mdr[5].ToString(), mdr[7].ToString(), mdr[6].ToString(), mdr[8].ToString());
            }

            connection.Close();
        }
        
        // User Deleted
        public void userArchive(DataGridView dataCustomer, string user_Status)
        {
           
            connection.Open();
            command = new SqlCommand("SELECT * FROM account WHERE User_Status = '" + user_Status + "'", connection);
            mdr = command.ExecuteReader();

            while (mdr.Read())
            {
                dataCustomer.Rows.Add(mdr[0].ToString(), mdr[1].ToString(), mdr[2].ToString(), mdr[3].ToString(), mdr[4].ToString(), mdr[5].ToString(), mdr[7].ToString(), mdr[6].ToString(), mdr[8].ToString());
            }

            connection.Close();
        }

        // Product Deleted
        public void ProductArchive(DataGridView dataProduct, string product_Status)
        {

            connection.Open();
            command = new SqlCommand("SELECT * FROM Products WHERE Product_Status = '" + product_Status + "'", connection);
            mdr = command.ExecuteReader();

            while (mdr.Read())
            {
                dataProduct.Rows.Add(mdr[0].ToString(), mdr[2].ToString(), mdr[3].ToString(), mdr[4].ToString(), mdr[5].ToString(), mdr[6].ToString(), mdr[8].ToString(), mdr[9].ToString(), mdr[10].ToString(), mdr[11].ToString());
            }
        }

        //Updating the product
        public void selectProduct(FlowLayoutPanel flowLayoutPanel, string productPanel)
        {
            try
            {
                connection.Open();

                string selectQuery = "SELECT * FROM Products WHERE Product_Status = 'Active';";
                command = new SqlCommand(selectQuery, connection);
                mdr = command.ExecuteReader();

                while (mdr.Read())
                {
                    int id = int.Parse(mdr[0] + "");
                    string description = "" + mdr[9];
                    string name = "" + mdr[3];
                    string type = "" + mdr[2];
                    double price = Double.Parse(mdr[5] + "");
                    int stock = int.Parse(mdr[6] + "");
                    string color = "" + mdr[4];
                    string size = "" + mdr[8];

                    Image image = Image.FromFile(@"" + mdr[7]);

                    if (productPanel == "panelView")
                    {
                        UserControl_AdminViewProducts obj = new UserControl_AdminViewProducts(id, price, stock, color, size, description, image);
                        flowLayoutPanel.Controls.Add(obj);
                    }
                    else if (productPanel == "panelEdit")
                    {
                        UserControl_Update obj = new UserControl_Update(id, name, type, price, stock, color, size, description, image);
                        flowLayoutPanel.Controls.Add(obj);
                    }
                    else
                    {
                        UserControl_Delete obj = new UserControl_Delete(id, price, stock, color, size, description, image);
                        flowLayoutPanel.Controls.Add(obj);
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

        //Fetching All Stocks
        public string AllStocks(string products)
        {
            try
            {
                connection.Open();

                string selectQuery = "SELECT Stocks FROM Products WHERE Product_Status = 'Active';";
                command = new SqlCommand(selectQuery, connection);
                mdr = command.ExecuteReader();

                int stocks = 0;

                while (mdr.Read())
                {
                    stocks += int.Parse(mdr[0] + "");
                }

                products = stocks.ToString();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return products;
        }

        //Fetching All User
        public string AllUser(string users)
        {
            try
            {
                connection.Open();
                string selectQuery = "SELECT COUNT(*) FROM account WHERE User_Status = 'Active';";
                command = new SqlCommand(selectQuery, connection);
                mdr = command.ExecuteReader();

                int numberOfUsers = 0;

                while (mdr.Read())
                {
                    numberOfUsers = int.Parse(mdr[0] + "");
                }

                users = numberOfUsers.ToString();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return users;
        }

        //-----Client Side-----//
        
        //Load All available product
        public void LoadAllAvailableProducts(FlowLayoutPanel flowLayoutPanel)
        {
            try
            {
                connection.Open();

                string selectQuery = "SELECT * FROM Products WHERE Product_Status = 'Active';";
                command = new SqlCommand(selectQuery, connection);
                mdr = command.ExecuteReader();

                while (mdr.Read())
                {
                    Image image = Image.FromFile(@"" + mdr[7]);
                    double price = Double.Parse(mdr[5] + "");
                    int stocks = int.Parse(mdr[6] + "");
                    string description = "" + mdr[9];
                    string size = "" + mdr[8];
                    string color = "" + mdr[4];
                    string category = "" + mdr[2];

                    ClientControl.Products.Product productAvailable = new ClientControl.Products.Product(image, price, stocks, description, size, color, category);
                    flowLayoutPanel.Controls.Add(productAvailable);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Load All available Tshirt
        public void LoadAllTshirtProducts(FlowLayoutPanel flowLayoutPanel)
        {
            try
            {
                connection.Open();
                string selectQuery = "SELECT * FROM Products WHERE Product_Status = 'Active' AND Category = 'T-Shirts';";
                command = new SqlCommand(selectQuery, connection);
                mdr = command.ExecuteReader();

                while (mdr.Read())
                {
                    Image image = Image.FromFile(@"" + mdr[7]);
                    double price = Double.Parse(mdr[5] + "");
                    int stocks = int.Parse(mdr[6] + "");
                    string description = "" + mdr[9];
                    string size = "" + mdr[8];
                    string color = "" + mdr[4];
                    string category = "" + mdr[2];

                    ClientControl.Products.Product productAvailable = new ClientControl.Products.Product(image, price, stocks, description, size, color, category);
                    flowLayoutPanel.Controls.Add(productAvailable);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Load All available Short
        public void LoadAllShortProducts(FlowLayoutPanel flowLayoutPanel)
        {
            try
            {
                connection.Open();
                string selectQuery = "SELECT * FROM Products WHERE Product_Status = 'Active' AND Category = 'Shorts';";
                command = new SqlCommand(selectQuery, connection);
                mdr = command.ExecuteReader();

                while (mdr.Read())
                {
                    Image image = Image.FromFile(@"" + mdr[7]);
                    double price = Double.Parse(mdr[5] + "");
                    int stocks = int.Parse(mdr[6] + "");
                    string description = "" + mdr[9];
                    string size = "" + mdr[8];
                    string color = "" + mdr[4];
                    string category = "" + mdr[2];

                    ClientControl.Products.Product productAvailable = new ClientControl.Products.Product(image, price, stocks, description, size, color, category);
                    flowLayoutPanel.Controls.Add(productAvailable);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}