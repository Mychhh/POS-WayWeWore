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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Policy;
using System.Xml.Linq;
using WWWPOS.ClassOrdersFolder;

namespace WWWPOS
{

    internal class DataBase
    {
    //SQl Declaration
        public static string user_ID, message, user_Name;
        public static bool isLogin = false;
        public static string fromWhat = "";
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

        //Product Stack & List
        protected List<Class_Products> productsList = new List<Class_Products>();

        //Order Stack & List
        protected List<Class_Orders> ordersList = new List<Class_Orders>();

        //Order Stack & List
        protected List<Class_OrdersStatus> classOrderStatus = new List<Class_OrdersStatus>();

        //Order ProductQty
        protected List<Class_ProductIDQTY> classProductNUMQTY = new List<Class_ProductIDQTY>();

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
            }
            catch (Exception ex)
            {
                // Show any error message.
                ErrorMessage(ex.Message);
            }
            connection.Close();
            return numberOfRows;
        }
        //Gets last number order
        public int GetLastOrderNumber()
        {
            int getNumberOfRowsOrders = GetNumberOfRows();
            int LastOrderNumber = 0;

            connection.Open();
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
                    sqlCommand = new SqlCommand(getOrderNumberOfLastRowQuery, connection);
                    dataReader = sqlCommand.ExecuteReader();

                    if (dataReader.Read())
                    {
                        LastOrderNumber = Int32.Parse(dataReader[0] + "");
                    }

                }
                catch (Exception ex)
                {
                    // Show any error message.
                    ErrorMessage(ex.Message);
                }
            }
            connection.Close();
            return LastOrderNumber;
        }

        //Get orders from client
        public void GetOrders(int productid, int ordernumber, string productname, string productcategory, string productcolor, string productsize,double productprice, int productquantity, string productimage, string productstatus, string orderstatus, string addedtocartat)
        {
            
            //Account ID
            int user_ID = Int32.Parse(DataBase.user_ID);

            ////change value of last order number parameter
            //ordernumber = GetLastOrderNumber();

            //Model
            connection.Open();
            string iquery = "INSERT INTO Orders(AccountID, OrderNumber, ProductID, Name, Category, Color, Size, Price, Quantity, ImagePath, Status, OrderStatus, AddedToCartAt) " +
                            "VALUES ('" + user_ID + "', '" + ordernumber + "' , '" + productid + "', '" + productname + "'," +
                                    "'" + productcategory + "', '" + productcolor + "', '" + productsize + "'," +
                                    "'" + productprice + "','" + productquantity + "','" + productimage + "','" + productstatus + "', '" + orderstatus + "' ,'" + addedtocartat + "')"; 

            try
            {
                sqlCommand = new SqlCommand(iquery, connection);
                sqlCommand.CommandTimeout = 60;
                dataReader = sqlCommand.ExecuteReader();

                connection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                ErrorMessage(ex.Message);
                connection.Close();
            }

        }

        //-----Client Side-----//  

        //Add to cart
        public void AddToCart(int product_ID, string category, string productName, string productColor, double productPrice, int productQuantity, string productImg, string productSize, string productDescription)
        {
            int user_ID = Int32.Parse(DataBase.user_ID);

            int SumProductQuantity = 0;

            connection.Open();
            string selectQuery = "SELECT Cart.Product_ID, Cart.Quantity, Products.Stocks " +
                                 "FROM [waywewore].[dbo].[Cart] AS Cart INNER JOIN [waywewore].[dbo].[Products] AS Products  ON Cart.Product_ID = Products.Product_ID " +
                                 "WHERE Cart.Product_ID = '" + product_ID + "' AND Cart.Account_ID = '" + user_ID + "' ";
            sqlCommand = new SqlCommand(selectQuery, connection);
            mdr = sqlCommand.ExecuteReader();

            //Checks if the item is available on cart
            if (mdr.Read())
            {
                SumProductQuantity = Int32.Parse(mdr[2] + "") + productQuantity;

                if (SumProductQuantity > Int32.Parse(mdr[3] + ""))
                {
                    ErrorMessage("You reached the maximum stock");
                    connection.Close();
                }
                else
                {
                    connection.Close();
                    connection.Open();
                    string updateCartQuery = "UPDATE Cart SET Quantity = '" + SumProductQuantity + "' " +
                                             "WHERE Product_ID ='" + product_ID + "' AND Cart.Account_ID = '" + user_ID + "' ";

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
            int user_ID = Int32.Parse(DataBase.user_ID);

            connection.Open();
            string addQtyQuery = "UPDATE Cart SET Quantity = Quantity + 1 WHERE Product_ID = '"+ productID + "' AND Cart.Account_ID = '" + user_ID + "' ";
            command = new SqlCommand(addQtyQuery, connection);
            mdr = command.ExecuteReader();
            connection.Close();
        }
        public void UpdateDeductCartProduct(int productID)
        {
            int user_ID = Int32.Parse(DataBase.user_ID);

            connection.Open();
            string addQtyQuery = "UPDATE Cart SET Quantity = Quantity - 1 WHERE Product_ID = '" + productID + "'  AND Cart.Account_ID = '" + user_ID + "' ";
            command = new SqlCommand(addQtyQuery, connection);
            mdr = command.ExecuteReader();
            connection.Close();
        }
        //Delete Product on Cart
        public void DeleteCartProduct(int cartID) 
        {
            int user_ID = Int32.Parse(DataBase.user_ID);

            connection.Open();
            string addQtyQuery = "DELETE FROM Cart WHERE Cart_ID = '" + cartID + "'  AND Cart.Account_ID = '" + user_ID + "'  ";
            command = new SqlCommand(addQtyQuery, connection);
            mdr = command.ExecuteReader();
            connection.Close();
        }
        //Product Payments
        public void PlaceOrder()
        {
            int user_ID = Int32.Parse(DataBase.user_ID);

            //updates the CartStatus to Pending
            try
            {
                connection.Open();
                string placeOrderQuery = "UPDATE Cart SET Cart_Status = 'Pending' WHERE Account_Id ='" + user_ID + "' AND Product_Status = 'Active' ";
                sqlCommand = new SqlCommand(placeOrderQuery, connection);
                dataReader = sqlCommand.ExecuteReader();
                connection.Close();

            }
            catch (Exception ex)
            {
                // Show any error message.
                ErrorMessage(ex.Message);
            }

        }
        //Add data to Orders table
        public void OrdersTableInsertData()
        {
            int user_ID = Int32.Parse(DataBase.user_ID);

            //change value of last order number parameter
            int lastRowNumber = GetLastOrderNumber();

            connection.Open();
            string pendingOrderQuery = "SELECT * FROM Cart WHERE Account_ID = '" + user_ID + "' AND Product_Status = 'Active' AND Cart_Status = 'Pending'";

            //adds row to Orders Table
            try
            {
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

                    //GetOrders(Product_ID, lastRowNumber, Product_Name, Category, Color, Product_Size, Price, Quantity, Product_images, Product_Status);

                    Class_Orders orders = new Class_Orders(lastRowNumber, Account_ID, Product_ID,
                                                           Product_Name, Category, Color, Product_Size,
                                                           Price, Quantity, Product_images,
                                                           Product_Status, "Pending", ProductAddedToCart_at);

                    ordersList.Add(orders);
                }

                connection.Close();

                for (int i = 0; i < ordersList.Count; i++)
                {
                    Class_Orders orders = ordersList[i];

                    GetOrders(orders.ProductID, orders.OrderNumber, orders.Name, orders.Category,
                              orders.Color, orders.Size, orders.Price, 
                              orders.Quantity, orders.ImagePath, orders.Status,
                              orders.OrderStatus, orders.AddedToCartAt);
                }

                //clears the value of orderList
                ordersList.Clear();

            }
            catch (Exception ex)
            {
                // Show any error message.
                ErrorMessage(ex.Message);
            }
        }
        //OrdersInsertBuyData
        public void OrdersInsertBuyData(int productid, string productimg, string productname, double productprice, string productcategory, int productquantity, string productsize, string productcolor, string productdescription)
        {
            int user_ID = Int32.Parse(DataBase.user_ID);

            //change value of last order number parameter
            int lastRowNumber = GetLastOrderNumber();

            connection.Open();
            string pendingOrderQuery = "INSERT INTO Orders (OrderNumber, AccountID, ProductID, Name, Category , Color, Size, Price, Quantity, ImagePath, Status, OrderStatus) " +
                                       "VALUES ('" + lastRowNumber + "' , '" + user_ID + "' , '" + productid + "' , '" + productname + "' , '" + productcategory + "', '" + productcolor + "', '" + productsize + "', '" + productprice + "', '" + productquantity + "','" + productimg + "', 'Active', 'Pending')";

            //adds row to Orders Table
            try
            {
                sqlCommand = new SqlCommand(pendingOrderQuery, connection);
                dataReader = sqlCommand.ExecuteReader();
                connection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                ErrorMessage(ex.Message);
            }
        }
        //Deletes cart rows
        public void DeletesTheCartPending()
        {
            int user_ID = Int32.Parse(DataBase.user_ID);

            //Deletes the product Cart
            try
            {
                connection.Open();
                string deleteCartProduct = "DELETE FROM Cart WHERE Account_ID = '" + user_ID + "' ";

                sqlCommand = new SqlCommand(deleteCartProduct, connection);
                dataReader = sqlCommand.ExecuteReader();
                connection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                ErrorMessage(ex.Message);
            }
        }
        
        //-----Cashier Side-----//
        
        //Get Data from Orders Table
        public void GetDataFromOrderTable()
        {
            try
            {
                connection.Open();

                string selectOrderNumberQuery = "SELECT * FROM Orders WHERE OrderStatus = 'Pending'";
                sqlCommand = new SqlCommand(selectOrderNumberQuery, connection);
                dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    int orderID = Int32.Parse(dataReader[0] + "");
                    int orderNumber = Int32.Parse(dataReader[1] + "");
                    int accountID = Int32.Parse(dataReader[2] + "");
                    int productId = Int32.Parse(dataReader[3] + "");
                    string name = "" + dataReader[4];
                    string category = "" + dataReader[5];
                    string color = "" + dataReader[6];
                    string size = "" + dataReader[7];
                    double price = Double.Parse(dataReader[8] + "");
                    int quantity = Int32.Parse(dataReader[9] + "");
                    string imagePath = "" + dataReader[10];
                    string status = "" + dataReader[11];
                    string orderStatus = "" + dataReader[12];
                    string addedToCartAt = "" + dataReader[13];
                    string placedOrder = "" + dataReader[14];

                    Class_OrdersStatus orders = new Class_OrdersStatus(orderID, orderNumber, accountID, productId,
                                                                       name, category, color, size,
                                                                       price, quantity, imagePath, status,
                                                                       orderStatus, addedToCartAt, placedOrder);

                    classOrderStatus.Add(orders);
                }
                
            }
            catch (Exception ex)
            {
                ErrorMessage(ex.Message);
            }

            connection.Close();
        }

        //Delete Particular Product
        public void RemoveParticularProduct(int orderID)
        {
            //Deletes the particular order
            try
            {
                connection.Open();
                string deleteParticularOrder = "DELETE FROM Orders WHERE OrderID = '" + orderID + "' ";

                sqlCommand = new SqlCommand(deleteParticularOrder, connection);
                dataReader = sqlCommand.ExecuteReader();
                connection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                ErrorMessage(ex.Message);
            }
        }

        //Remove Orders
        public void RemoveOrders(int orderNumber)
        {
            //Deletes the particular order
            try
            {
                connection.Open();
                string removeOrders = "DELETE FROM Orders WHERE OrderNumber = '" + orderNumber + "' ";

                sqlCommand = new SqlCommand(removeOrders, connection);
                dataReader = sqlCommand.ExecuteReader();
                connection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                ErrorMessage(ex.Message);
            }
        }

        //Success Orders
        public void OrderSuccess(int orderNumber)
        {
            try
            {
                connection.Open();
                //update order status to success
                string updateOrdersToSuccessQuery = "UPDATE Orders SET OrderStatus = 'Success' WHERE OrderNumber = '" + orderNumber + "' ";

                sqlCommand = new SqlCommand(updateOrdersToSuccessQuery, connection);
                dataReader = sqlCommand.ExecuteReader();
                connection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                ErrorMessage("I am here " + ex.Message);
            }
        }

        //Get Order Based on OrderID
        public void GetOrderNumber(int ordernumber)
        {
            try
            {
                connection.Open();
                string getOrderNumberQuery = "SELECT * FROM Orders WHERE OrderNumber = '"+ ordernumber + "' ";
                sqlCommand = new SqlCommand(getOrderNumberQuery, connection);
                dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    int ProductID = Int32.Parse(dataReader[3] + "");
                    int ProductQTY = Int32.Parse(dataReader[9] + "");

                    Class_ProductIDQTY productIDQTY = new Class_ProductIDQTY(ProductID, ProductQTY);

                    classProductNUMQTY.Add(productIDQTY);
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                ErrorMessage(ex.Message);
            }
        }

        //Deduct Stock on Product
        public void ProductDeduction()
        {
            try
            {
                for(int i = 0; i < classProductNUMQTY.Count; i++)
                {
                    Class_ProductIDQTY productIDQTY = classProductNUMQTY[i];

                    connection.Open();
                    string deductQtyQuery = "UPDATE Products SET Stocks = Stocks - '" + productIDQTY.ProductQTY + "' WHERE Product_ID = '" + productIDQTY.ProductID + "' ";
                    sqlCommand = new SqlCommand(deductQtyQuery, connection);
                    dataReader = sqlCommand.ExecuteReader();
                    connection.Close();
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