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
using System.Collections;
using System.Windows.Documents;

namespace WWWPOS
{

    internal class DataBase
    {
    //SQl Declaration
        public static string user_ID, message, user_Name;
        public static bool isLogin = false;
        public const string SQLServerLink = "Data Source=DESKTOP-83HB1MK\\SQLEXPRESS; Initial Catalog=waywewore; Integrated Security=True";
        protected  SqlConnection connection = new SqlConnection(SQLServerLink);
        protected SqlCommand command;
        protected SqlDataReader mdr;

        protected SqlCommand sqlCommand;
        protected SqlDataReader dataReader;

    //Dialogue Box declaration
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

        //Product Stack
        protected Stack<Class_Products> productsStack = new Stack<Class_Products>();
        protected List<Class_Products> productsList = new List<Class_Products>();

    //-----About User-----//

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
                        message = "Success";
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
                user_Name = mdr["Full_Name"].ToString();
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

    //-----About Products-----//

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

        //Gets the number of rows of the Orders Table
        public int GetNumberOfRows()
        {
            int numberOfRows = 0;
            connection.Open();
            string getNumberOfRows = "SELECT COUNT(*) FROM Orders";

            try
            {
                sqlCommand = new SqlCommand(getNumberOfRows, connection);
                dataReader = sqlCommand.ExecuteReader();
                if (dataReader.Read())
                {
                    numberOfRows = Int32.Parse(dataReader[0] + "");
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                ErrorMessage(ex.Message);
            }

            return numberOfRows;
        }
        //Gets last number order
        public int GetLastOrderNumber()
        {
            int getNumberOfRowsOrders = GetNumberOfRows();
            int LastOrderNumber = 0;

            string getOrderNumberOfLastRowQuery = "SELECT TOP 1 * FROM Orders ORDER BY OrderID DESC";

            //Checks if the table is empty
            if (getNumberOfRowsOrders <= 0)
            {
                //if the table is empty
                LastOrderNumber = 1;
            }
            else
            {
                try
                {
                    connection.Open();
                    sqlCommand = new SqlCommand(getOrderNumberOfLastRowQuery, connection);
                    dataReader = sqlCommand.ExecuteReader();

                    if (dataReader.Read())
                    {
                        LastOrderNumber = Int32.Parse(dataReader[0] + "");
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    // Show any error message.
                    ErrorMessage(ex.Message);
                }
            }

            return LastOrderNumber;
        }

        //Get orders from client
        public void GetOrders(int productid, int ordernumber, string productname, string productcategory, string productcolor, string productsize,double productprice, int productquantity, string productimage,string productstatus)
        {
            
            //Account ID
            int user_ID = Int32.Parse(DataBase.user_ID);

            //change value of last order number parameter
            ordernumber = GetLastOrderNumber();

            //Model
            //connection.Open();
            string iquery = "INSERT INTO Orders(AccountID, OrderNumber, ProductID, Name, Category, Color, Size, Price, Quantity, ImagePath, Status) " +
                            "VALUES ('" + user_ID + "', '" + ordernumber + "' , '" + productid + "', '" + productname + "'," +
                                    "'" + productcategory + "', '" + productcolor + "', '" + productsize + "'," +
                                    "'" + productprice + "','" + productquantity + "','" + productimage + "','" + productstatus + "')";

            try
            {
                sqlCommand = new SqlCommand(iquery, connection);
                sqlCommand.CommandTimeout = 60;
                dataReader = sqlCommand.ExecuteReader();

                SuccessMessage("Product Added Succesfully!");
                message = "Success";
                //connection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                ErrorMessage(ex.Message);
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
        //Product Payments 
        public void PlaceOrder()
        {
            string userID = DataBase.user_ID;
            int user_ID = Int32.Parse(userID);

            //updates the CartStatus to Pending
            try
            {
                connection.Open();
                string placeOrderQuery = "UPDATE Cart SET Cart_Status = 'Pending' WHERE Account_Id ='" + user_ID + "' AND Product_Status = 'Active' ";
                sqlCommand = new SqlCommand(placeOrderQuery, connection);
                dataReader = sqlCommand.ExecuteReader();
                connection.Close();
                SuccessMessage("Placed Order Succesfully \n\n Go to cashier");

                //adds row to Orders Table
                try
                {
                    connection.Close();
                    connection.Open();
                    string pendingOrderQuery = "SELECT * FROM Cart WHERE Account_ID = '" + user_ID + "' AND Product_Status = 'Active' AND Cart_Status = 'Pending'";
                    sqlCommand = new SqlCommand(pendingOrderQuery, connection);
                    dataReader = sqlCommand.ExecuteReader();

                    while (dataReader.Read())
                    {
                        int Cart_ID = Int32.Parse(dataReader[0] + "");
                        int Account_ID = Int32.Parse(dataReader[1] + "");
                        int Product_ID = Int32.Parse(dataReader[2] + "");
                        string Category = "" + dataReader[3];
                        string Product_Name = "" + dataReader[4];
                        string Color = "" + dataReader[5];
                        double Price = Double.Parse(dataReader[6] + "");
                        int Quantity = Int32.Parse(dataReader[7] + "");
                        string Product_images = "" + dataReader[8];
                        string Product_Size = "" + dataReader[9];
                        string Product_Description = "" + dataReader[10];
                        string Product_Status = "" + dataReader[11];
                        string ProductAddedToCart_at = "" + dataReader[12];
                        string Cart_Status = "" + dataReader[13];

                        GetOrders(Product_ID, 1, Product_Name, Category, Color, Product_Size, Price, Quantity, Product_images, Product_Status);
                    }

                    connection.Close();

                    //Deletes the product Cart
                    //try
                    //{
                    //    connection.Open();
                    //    string deleteCartProduct = "DELETE FROM Cart WHERE Account_ID = '" + user_ID + "' ";

                    //    sqlCommand = new SqlCommand(deleteCartProduct, connection);
                    //    dataReader = sqlCommand.ExecuteReader();
                    //    connection.Close();
                    //}
                    //catch (Exception ex)
                    //{
                    //    // Show any error message.
                    //    ErrorMessage(ex.Message);
                    //}

                }
                catch (Exception ex)
                {
                    // Show any error message.
                    ErrorMessage(ex.Message);
                }

            }
            catch (Exception ex)
            {
                // Show any error message.
                ErrorMessage(ex.Message);
            }

        }
    }

}