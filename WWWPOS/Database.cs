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
using WWWPOS.ErrorMessage;
using System.Security.Cryptography;
using System.Reflection;
using Org.BouncyCastle.Utilities.Collections;
using WWWPOS.ClientControl.ClientCart;
using System.Windows;
using WWWPOS.MessageFolder;

namespace WWWPOS
{

    internal class DataBase
    {
        public static string user_ID, message;
        public const string SQLServerLink = "Data Source=DESKTOP-83HB1MK\\SQLEXPRESS; Initial Catalog=waywewore; Integrated Security=True";
        protected  SqlConnection connection = new SqlConnection(SQLServerLink);
        protected SqlCommand command;
        protected SqlDataReader mdr;

        //Dialogue Box
        ErrorMessageDialogue errorMessageDialogue;
        SuccessMessageDialogue successMessageDialogue;
        WarningMessageDialogue warningMessageDialogue;

        //Methods for Error Message
        public void ErrorMessage(string errorName)
        {
            errorMessageDialogue = new ErrorMessageDialogue(errorName);
            errorMessageDialogue.ShowDialog();
        }
        public void WarningMessage(string warningName)
        {
            warningMessageDialogue = new WarningMessageDialogue(warningName);
            warningMessageDialogue.ShowDialog();
        }
        public void SuccessMessage(string successName)
        {
            successMessageDialogue = new SuccessMessageDialogue(successName);
            successMessageDialogue.ShowDialog();
        }

        //About User

        //Signup and Add user
        public void InsertAccount(string email, string name, string address, string password, int phoneNumber, string user_Type)
        {
            connection.Open();
            string selectQuery = "SELECT Email FROM Account WHERE Email = '" + email + "';";
            command = new SqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();

            if (mdr.Read())
            {
                ErrorMessage("Email Already Registered!");
                connection.Close();
            }
            else
            {
                connection.Close(); //closes the first connection used by checking if the email is already registered

                connection.Open();
                string insertQuery = "INSERT INTO Account(Full_Name, Email, Password,Phone,Address, User_Status, User_Type) VALUES ('" + name + "', '" + email + "', '" + password + "', '" + phoneNumber + "', '" + address + "','"  + "Active" + "','" + user_Type + "')";
                SqlCommand commandDatabase = new SqlCommand(insertQuery, connection);
                commandDatabase.CommandTimeout = 60;

                try
                {
                    SqlDataReader myReader = commandDatabase.ExecuteReader();
                    SuccessMessage("Account Created Successfully!");
                    connection.Close();
                }
                catch (Exception ex)
                {
                    ErrorMessage(ex.Message);
                }
            }
        }
        
        //Login User
        public void Login(string email, string password)
        {
            connection.Open();
            string selectQuery = "SELECT * FROM Account WHERE Email = '" + email + "' AND Password = '" + password + "';";
            command = new SqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();
           

            if (mdr.Read())
            {
                user_ID = mdr["Account_Id"].ToString();
                String userType = mdr["User_Type"].ToString();

                if (userType == "Client")
                {
                    WWWPOS.LoginPage.ActiveForm.Hide();
                    Form_ClientLandingPage clientView = new Form_ClientLandingPage(); ;
                    clientView.Show();
                }
                else if (userType == "Admin")
                {
                    WWWPOS.LoginPage.ActiveForm.Hide();
                    Form_AdminHome f2 = new Form_AdminHome();
                    f2.ShowDialog();
                }

            }
            else
            {
                ErrorMessage("Incorrect Login Information! \nTry again.");
            }

            connection.Close();
        }

        //Update account
        public void UpdateUser(int account_ID, string user_Name, string email, string password, int phone, string user_Type, string address)
        {
            connection.Open();
            string selectQuery = "UPDATE Account SET Full_Name = '" + user_Name + "', Email = '" + email + "', Password = '" + password + "', Phone = '" + phone + "', User_Type = '" + user_Type + "', Address = '"+address +"' WHERE Account_Id ='" + account_ID+"';";
            command = new SqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();
            connection.Close();

            SuccessMessage("Updated Succesfully!");

        }
        
        //Delete and restore account
        public void SetStatusUser(string user_Status, int account_ID)
        {
            connection.Open();
            string selectQuery = "UPDATE Account SET User_Status = '" + user_Status + "' WHERE Account_Id ='" + account_ID + "';";
            command = new SqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();
            connection.Close();

            if(user_Status == "Inactive")
            {
                SuccessMessage("User Deleted");

            }
            else
            {
                SuccessMessage("User Restored");

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
                SuccessMessage("Product Added Succesfully!");
                message = "Success";
            }
            catch (Exception ex)
            {
                // Show any error message.
                ErrorMessage(ex.Message);
            }

            connection.Close();
        }

        //Update Products
        public void UpdateProducts(int productID, string category, string name, string color, double price, int stock, string size, string description)
        {
            connection.Open();
            string selectQuery = "UPDATE Products SET Category='" + category + "',Product_Name='" + name + "',Color='" + color + "',Price='" + price + "',Stocks='" + stock + "',Product_Size='" + size + "',Product_Description='" + description + "' WHERE Product_ID ='" + productID + "';";
            command = new SqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();
            connection.Close();

            SuccessMessage("Product Updated!");
        }

        //Delete and restore products
        public void SetStatusProducts(string product_Status, int product_ID)
        {

            connection.Open();
            string selectQuery = "UPDATE Products SET Product_Status = '" + product_Status + "' WHERE Product_ID ='" + product_ID + "';";
            string selectCartQuery = "UPDATE Cart SET Product_Status = '" + product_Status + "' WHERE Product_ID ='" + product_ID + "';";
            command = new SqlCommand(selectQuery + selectCartQuery, connection);
            mdr = command.ExecuteReader();
            connection.Close();

            if (product_Status == "Inactive")
            {
                SuccessMessage("Product Deleted");
            }
            else
            {
                SuccessMessage("Product Restored");
            }

        }

        //-----Client Side-----//  

        //Add to cart
        public void AddToCart(int product_ID, string category, string productName, string productColor, double productPrice, int productQuantity, string productImg, string productSize, string productDescription)
        {
            string userID = DataBase.user_ID;
            int user_ID = Int32.Parse(userID);

            int SumProductQuantity = 0;

            connection.Open();
            string selectQuery = "SELECT Cart.Product_ID, Cart.Quantity, Products.Stocks " +
                                 "FROM [waywewore].[dbo].[Cart] AS Cart INNER JOIN [waywewore].[dbo].[Products] AS Products  ON Cart.Product_ID = Products.Product_ID " +
                                 "WHERE Cart.Product_ID = '" + product_ID + "'";
            SqlCommand commandDatabase = new SqlCommand(selectQuery, connection);
            mdr = commandDatabase.ExecuteReader();

            //Checks if the item is available on cart
            if (mdr.Read())
            {
                SumProductQuantity = Int32.Parse(mdr[1] + "") + productQuantity;

                if (SumProductQuantity > Int32.Parse(mdr[2] + ""))
                {
                    ErrorMessage("You reached the maximum stock");
                    connection.Close();
                }
                else
                {
                    connection.Close();
                    connection.Open();
                    string updateCartQuery = "UPDATE Cart SET Quantity = '" + SumProductQuantity + "' WHERE Product_ID ='" + product_ID + "';";
                    SqlCommand commandToUpdateCartQuantity = new SqlCommand(updateCartQuery, connection);
                    commandToUpdateCartQuantity.CommandTimeout = 60;

                    try
                    {
                        SqlDataReader myReader = commandToUpdateCartQuantity.ExecuteReader();
                        SuccessMessage("Added to cart");
                    }
                    catch (Exception ex)
                    {
                        // Show any error message.
                        ErrorMessage(ex.Message);
                    }

                    connection.Close();
                }

            }
            else
            {
                //Otherwise add new item on cart
                connection.Close();
                connection.Open();
                string insertQuery = "INSERT INTO Cart (Account_ID, Product_ID, Category, Product_Name, Color, Price , Quantity, Product_images, Product_Size, Product_Description, Product_Status) " +
                                     "VALUES ('" + user_ID + "' , '" + product_ID + "' , '" + category + "', '" + productName + "', '" + productColor + "', '" + productPrice + "', '" + productQuantity + "','" + productImg + "','" + productSize + "','" + productDescription + "','Active')";
                SqlCommand commandToInsertNewItems = new SqlCommand(insertQuery, connection);
                commandToInsertNewItems.CommandTimeout = 60;

                try
                {
                    SqlDataReader myReader = commandToInsertNewItems.ExecuteReader();
                    ErrorMessageDialogue messageDialogue = new ErrorMessageDialogue("Added to Cart");
                    messageDialogue.ShowDialog();
                }
                catch (Exception ex)
                {
                    ErrorMessage(ex.Message);
                }
                
                connection.Close();
                
            }   

        }
        //Update cart
        public void UpdateAddCartProduct(int productID)
        {
            connection.Open();
            string addQtyQuery = "UPDATE Cart SET Quantity = Quantity + 1 WHERE Product_ID = '"+ productID + "';";
            command = new SqlCommand(addQtyQuery, connection);
            mdr = command.ExecuteReader();
            connection.Close();
        }
        public void UpdateDeductCartProduct(int productID)
        {
            connection.Open();
            string addQtyQuery = "UPDATE Cart SET Quantity = Quantity - 1 WHERE Product_ID = '" + productID + "';";
            command = new SqlCommand(addQtyQuery, connection);
            mdr = command.ExecuteReader();
            connection.Close();
        }
        //Delete Product on Cart
        public void DeleteCartProduct(int cartID) 
        {
            connection.Open();
            string addQtyQuery = "DELETE FROM Cart WHERE Cart_ID = '" + cartID + "';";
            command = new SqlCommand(addQtyQuery, connection);
            mdr = command.ExecuteReader();
            connection.Close();
        }
    }

    class loadData : DataBase
    {
        //-----Admin Side-----//    
        //Active User
        public void userRecords(DataGridView dataCustomer, string user_Type, string user_Status)
        {
            connection.Open();
            command = new SqlCommand("SELECT * FROM Account WHERE User_Type = '"+user_Type+"' AND User_Status = '"+ user_Status+ "'", connection);
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
            command = new SqlCommand("SELECT * FROM Account WHERE User_Status = '" + user_Status + "'", connection);
            mdr = command.ExecuteReader();

            while (mdr.Read())
            {
                dataCustomer.Rows.Add(mdr[0].ToString(), mdr[1].ToString(), mdr[2].ToString(), mdr[3].ToString(), mdr[4].ToString(), mdr[5].ToString(), mdr[7].ToString(), mdr[6].ToString(), mdr[8].ToString());
            }
            connection.Close();
        }

        //Load product to be deleted
        public void ProductArchive(DataGridView dataProduct, string product_Status)
        {

            connection.Open();
            command = new SqlCommand("SELECT * FROM Products WHERE Product_Status = '" + product_Status + "'", connection);
            mdr = command.ExecuteReader();

            while (mdr.Read())
            {
                dataProduct.Rows.Add(mdr[0].ToString(), mdr[2].ToString(), mdr[3].ToString(), mdr[4].ToString(), mdr[5].ToString(), mdr[6].ToString(), mdr[8].ToString(), mdr[9].ToString(), mdr[10].ToString(), mdr[11].ToString());
            }
            connection.Close();
        }

        //Load product to be updated
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
                ErrorMessage(ex.Message);
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
                ErrorMessage(ex.Message);
            }

            return products;
        }

        //Fetching All User
        public string AllUser(string users)
        {
            try
            {
                connection.Open();
                string selectQuery = "SELECT COUNT(*) FROM Account WHERE User_Status = 'Active';";
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
                ErrorMessage(ex.Message);
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
                    int id = int.Parse(mdr[0] + "");
                    string category = "" + mdr[2];
                    string name = "" + mdr[2];
                    string color = "" + mdr[4];
                    double price = Double.Parse(mdr[5] + "");
                    int stocks = int.Parse(mdr[6] + "");
                    Image image = Image.FromFile(@"" + mdr[7]);
                    string imgPath = "" + mdr[7];
                    string size = "" + mdr[8];
                    string description = "" + mdr[9];

                    UserControl_Product productAvailable = new UserControl_Product(id, image, imgPath, name, price, stocks, description, size, color, category);
                    flowLayoutPanel.Controls.Add(productAvailable);
                }

            }
            catch (Exception ex)
            {
                ErrorMessage(ex.Message);
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
                    int id = int.Parse(mdr[0] + "");
                    Image image = Image.FromFile(@"" + mdr[7]);
                    string imgPath = "" + mdr[7];
                    string name = "" + mdr[2];
                    double price = Double.Parse(mdr[5] + "");
                    int stocks = int.Parse(mdr[6] + "");
                    string description = "" + mdr[9];
                    string size = "" + mdr[8];
                    string color = "" + mdr[4];
                    string category = "" + mdr[2];

                    UserControl_Product productAvailable = new UserControl_Product(id, image, imgPath, name, price, stocks, description, size, color, category);
                    flowLayoutPanel.Controls.Add(productAvailable);
                }

            }
            catch (Exception ex)
            {
                ErrorMessage(ex.Message);
            }
            connection.Close();
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
                    int id = int.Parse(mdr[0] + "");
                    Image image = Image.FromFile(@"" + mdr[7]);
                    string imgPath = "" + mdr[7];
                    string name = "" + mdr[2];
                    double price = Double.Parse(mdr[5] + "");
                    int stocks = int.Parse(mdr[6] + "");
                    string description = "" + mdr[9];
                    string size = "" + mdr[8];
                    string color = "" + mdr[4];
                    string category = "" + mdr[2];

                    UserControl_Product productAvailable = new UserControl_Product(id, image, imgPath, name, price, stocks, description, size, color, category);
                    flowLayoutPanel.Controls.Add(productAvailable);
                }

            }
            catch (Exception ex)
            {
                ErrorMessage(ex.Message);
            }
            connection.Close();
        }

        //Load Users Cart
        public void LoadCart(FlowLayoutPanel flowLayoutPanel)
        {
            string userid = DataBase.user_ID;
            int user_ID = Int32.Parse(userid);

            try
            {
                connection.Open();

                //string selectJoinedQuerry = "SELECT * FROM[waywewore].[dbo].[Cart] AS Cart INNER JOIN[waywewore].[dbo].[Products] " +
                //                            "AS Product ON Cart.Product_ID = Product.Product_ID " +
                //                            "WHERE Cart.Account_ID = '" + user_ID + "' AND Product.Product_Status = 'Active' ";

                string selectJoinedQuerry = "SELECT * FROM[waywewore].[dbo].[Cart] AS Cart INNER JOIN[waywewore].[dbo].[Products] " +
                                            "AS Product ON Cart.Product_ID = Product.Product_ID " +
                                            "WHERE Cart.Account_ID = '" + user_ID + "' ";

                command = new SqlCommand(selectJoinedQuerry, connection);
                mdr = command.ExecuteReader();

                int total = 0;

                while (mdr.Read())
                {
                    string productStatus = "" + mdr[12];

                    if(productStatus == "Inactive")
                    {
                        int cartID = int.Parse(mdr[0] + "");
                        int productID = Int32.Parse(mdr[2] + "");
                        Image image = Image.FromFile(@"" + mdr[8]);
                        double price = Double.Parse(mdr[6] + "");
                        int quantity = Int32.Parse(mdr[7] + "");
                        string description = "" + mdr[10];
                        string size = "" + mdr[9];
                        string color = "" + mdr[5];
                        string category = "" + mdr[3];
                                                                                                           
                        UserControl_ProductCartInactive UC_ProductCartInactive = new UserControl_ProductCartInactive(cartID, user_ID, productID, image, price, quantity, description, size, color, category);
                        flowLayoutPanel.Controls.Add(UC_ProductCartInactive);
                    }
                    else 
                    {
                        int cartID = int.Parse(mdr[0] + "");
                        int productID = Int32.Parse(mdr[2] + "");
                        Image image = Image.FromFile(@"" + mdr[8]);
                        double price = Double.Parse(mdr[6] + "");
                        int quantity = Int32.Parse(mdr[7] + "");
                        total = Convert.ToInt32(price) * quantity;
                        int stock = Int32.Parse(mdr[19] + "");
                        string description = "" + mdr[10];
                        string size = "" + mdr[9];
                        string color = "" + mdr[5];
                        string category = "" + mdr[3];

                        UserControl_ProductCart UC_ProductCart = new UserControl_ProductCart(cartID, user_ID, productID, image, price, quantity, total, stock, description, size, color, category);

                        flowLayoutPanel.Controls.Add(UC_ProductCart);
                    }

                    

                }

            }
            catch (Exception ex)
            {
                ErrorMessage(ex.Message);
            }
            connection.Close();
        }

        //Load Users cart total items
        public void LoadTotalItems(FlowLayoutPanel flowLayoutPanel)
        {
            string userid = DataBase.user_ID;
            int user_ID = Int32.Parse(userid);

            try
            {
                connection.Open();

                string selectJoinedQuerry = "SELECT * FROM[waywewore].[dbo].[Cart] AS Cart INNER JOIN[waywewore].[dbo].[Products] AS Product " +
                                            "ON Cart.Product_ID = Product.Product_ID WHERE Cart.Account_ID = '" + user_ID + "' AND Product.Product_Status = 'Active' ";
                command = new SqlCommand(selectJoinedQuerry, connection);
                mdr = command.ExecuteReader();

                int total = 0;

                while (mdr.Read())
                {
                    int cartID = int.Parse(mdr[0] + "");
                    int productID = Int32.Parse(mdr[2] + "");
                    Image image = Image.FromFile(@"" + mdr[8]);
                    double price = Double.Parse(mdr[6] + "");
                    int quantity = Int32.Parse(mdr[7] + "");
                    total = Convert.ToInt32(price) * quantity;
                    int stock = Int32.Parse(mdr[19] + "");
                    string description = "" + mdr[10];
                    string size = "" + mdr[9];
                    string color = "" + mdr[5];
                    string category = "" + mdr[3];

                    UserControl_ProductCart UC_ProductCart = new UserControl_ProductCart(cartID, user_ID, productID, image, price, quantity, total, stock, description, size, color, category);

                    UC_ProductCart.Controls.Remove(UC_ProductCart.btn_DeleteProduct);
                    UC_ProductCart.Controls.Remove(UC_ProductCart.btn_Plus);
                    UC_ProductCart.Controls.Remove(UC_ProductCart.btn_Minus);
                    UC_ProductCart.cmb_ProductSize.Enabled = false;
                    UC_ProductCart.cmb_Color.Enabled = false;

                    flowLayoutPanel.Controls.Add(UC_ProductCart);
                }

            }
            catch (Exception ex)
            {
                ErrorMessage(ex.Message);
            }
            connection.Close();
        }

        //Load Buy Item
        public void LoadBuyItem(int productID, string productImg, string productName, double productPrice, string productCategory, int productQuantity, string productSize, string productColor, string productDescription)
        {
            string userid = DataBase.user_ID;
            int userID = Int32.Parse(userid);

            UserControl_ProductCart UC_ProductCart = new UserControl_ProductCart(userID, productID, productImg, productName, productPrice, productCategory, productQuantity, productSize, productColor, productDescription);
            
            //Removes and Diabled unnecessary controls
            UC_ProductCart.Controls.Remove(UC_ProductCart.btn_DeleteProduct);
            UC_ProductCart.Controls.Remove(UC_ProductCart.btn_Plus);
            UC_ProductCart.Controls.Remove(UC_ProductCart.btn_Minus);
            UC_ProductCart.cmb_ProductSize.Enabled = false;
            UC_ProductCart.cmb_Color.Enabled = false;

            Form_ClientPay form_ClientPay = new Form_ClientPay();
            form_ClientPay.flPanel_ProductTotal.Controls.Add(UC_ProductCart);
            form_ClientPay.lbl_TotalPrice.Text = (productPrice * productQuantity).ToString();

            form_ClientPay.ShowDialog();
        }

        //Load cart total price
        public string LoadCartTotalPrice(string totalPrice)
        {
            string userid = DataBase.user_ID;
            int user_ID = Int32.Parse(userid);

            try
            {
                connection.Open();

                string selectJoinedQuerry = "SELECT * FROM[waywewore].[dbo].[Cart] AS Cart INNER JOIN[waywewore].[dbo].[Products] AS Product ON Cart.Product_ID = Product.Product_ID WHERE Cart.Account_ID = '" + user_ID + "'";
                command = new SqlCommand(selectJoinedQuerry, connection);
                mdr = command.ExecuteReader();

                int ProductCartTotal = 0;
                int total = 0;

                while (mdr.Read())
                {
                    int id = int.Parse(mdr[0] + "");
                    double price = Double.Parse(mdr[6] + "");
                    int quantity = Int32.Parse(mdr[7] + "");
                    total = Convert.ToInt32(price) * quantity;
                    ProductCartTotal += total;
                    int stock = Int32.Parse(mdr[19] + "");
                }

                totalPrice = ProductCartTotal.ToString();


            }
            catch (Exception ex)
            {
                ErrorMessage(ex.Message);
            }

            connection.Close();
            return totalPrice;
        }

    }
}