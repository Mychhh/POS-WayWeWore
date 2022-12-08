﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using WWWPOS.Modal;
using System.Data;
using WWWPOS.SideBarControl.Products;

namespace WWWPOS
{

    internal class DataBase
    {
        public static string user_ID, message;

        readonly static string connectionString = "Data Source = DESKTOP-83HB1MK\\SQLEXPRESS; Initial Catalog=waywewore; Integrated Security=True";
        protected SqlConnection connection = new SqlConnection(connectionString);
        protected SqlCommand command;
        protected SqlDataReader mdr;

        //Signup / add user
        public void insertAccount(string email, string name, string address, string password, int phoneNumber, string user_Type)
        {
            //opens the DB connection
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

<<<<<<< HEAD
                string iquery = "INSERT INTO account(Full_Name, Email, Password,Phone,Address, User_Status, User_Type) VALUES ('" + name + "', '" + email + "', '" + password + "', '" + phoneNumber + "', '" + address + "','"  + "nDel" + "','" + user_Type + "')";

                SqlConnection databaseConnection = new SqlConnection("Data Source=MIKO\\SQLEXPRESS;Initial Catalog=waywewore;Integrated Security=True");
                SqlCommand commandDatabase = new SqlCommand(iquery, databaseConnection);
=======
                string iquery = "INSERT INTO account(Full_Name, Email, Password,Phone,Address,User_Type) VALUES ('" + name + "', '" + email + "', '" + password + "', '" + phoneNumber + "', '" + address + "','"+ user_Type + "')";
                SqlCommand commandDatabase = new SqlCommand(iquery, connection);
>>>>>>> 52cdd1b (modified)
                commandDatabase.CommandTimeout = 60;

                try
                {
                    connection.Open();
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
                string userType = mdr["User_Type"].ToString();

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
<<<<<<< HEAD
        //Update 
        public void updateUser(string account_ID, string user_Name, string email, string password, int phone, string user_Type, string address, Panel panel_UserList)
        {
            connection.Open();
            string selectQuery = "Update account Set Full_Name = '" + user_Name + "', Email = '" + email + "', Password = '" + password + "', Phone = '" + phone + "', User_Type = '" + user_Type + "', Address = '"+address +"' WHERE Account_Id ='" + account_ID+"';";
            command = new SqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();
            connection.Close();
    
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Update Successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            if (dialogResult == DialogResult.OK)
            {
                Update_Delete.ActiveForm.Hide();
            }
        }
        public void deleteUser(string account_ID)
        {
            string user_Status = "Del";    
            connection.Open();
            string selectQuery = "Update account Set User_Status = '" + user_Status + "' WHERE Account_Id ='" + account_ID + "';";
            command = new SqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();
            connection.Close();

            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Delete Successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); ;

        }
=======
>>>>>>> 52cdd1b (modified)

        //Add Products
        public void addProdducts(string product_Name, string product_Color, double product_Price, int product_Stock, string category ,string product_Size, string product_image, string Product_Description)
        {
            string id = DataBase.user_ID;
            int user_ID = Int32.Parse(id);

            connection.Open();
<<<<<<< HEAD
            string iquery = "INSERT INTO Products(Account_ID, Category, Product_Name, Color, Price ,Stocks, Product_images, Product_Size, Product_Description, Product_Status) VALUES ('" + user_ID + "' , '" + category + "', '" + product_Name + "', '" + product_Color + "', '" + product_Price + "', '" + product_Stock + "','"+ product_image + "','"+ product_Size + "','" + Product_Description + "','nDel')";
=======
            string iquery = "INSERT INTO Products(Account_ID, Category, Product_Name, Color, Price ,Stocks, Product_images, Product_Size, Product_Description) VALUES ('" + user_ID + "' , '" + category + "', '" + product_Name + "', '" + product_Color + "', '" + product_Price + "', '" + product_Stock + "','"+ product_image + "','"+ product_Size + "','" + Product_Description + "')";
            SqlCommand commandDatabase = new SqlCommand(iquery, connection);
>>>>>>> 52cdd1b (modified)

            commandDatabase.CommandTimeout = 60;

            try
            {
                connection.Open();
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
    }

    class loadData : DataBase
    {
<<<<<<< HEAD
        SqlConnection connection = new SqlConnection("Data Source=MIKO\\SQLEXPRESS;Initial Catalog=waywewore;Integrated Security=True");
        SqlCommand command;
        SqlDataReader mdr;
        public void userRecords(DataGridView dataCustomer, string user_Type, string user_Status)
=======
        public void adminData(DataGridView dataAdmin)
>>>>>>> 52cdd1b (modified)
        {
            int i = 0;
            connection.Open();
            command = new SqlCommand("select * from account WHERE User_Type = '"+user_Type+"' AND User_Status = '"+ user_Status+ "'", connection);
            mdr = command.ExecuteReader();

            while (mdr.Read())
            {
                dataCustomer.Rows.Add(mdr[0].ToString(), mdr[1].ToString(), mdr[2].ToString(), mdr[3].ToString(), mdr[4].ToString(), mdr[5].ToString(), mdr[6].ToString(), mdr[7].ToString());
            }

            connection.Close();
        }

        public void selectProduct(TableLayoutPanel tableLayoutPanel, string productPanel)
        {
            try
            {
                connection.Open();

                string selectQuery = "SELECT * FROM Products WHERE Product_Status = 'nDel';";
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