using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WWWPOS.ClientControl.ClientCart;
using WWWPOS.ClientControl.Products;
using WWWPOS.SideBarControl.Inventory;
using WWWPOS.SideBarControl;
using WWWPOS.SideBarControl.Products;
using System.Reflection;
using System.Security.Cryptography;
using System.Windows.Controls.Primitives;
using WWWPOS.MessageFolder;
using WWWPOS.SideBarControl.Orders.PendingOrders;
using WWWPOS.SideBarControl.Orders;
using System.ComponentModel;
using System.Windows.Data;
using WWWPOS.ErrorMessage;
using System.Data;
using WWWPOS.SideBarControl.Dashboard;
using Google.Protobuf.WellKnownTypes;
using System.Data.Common;
using WWWPOS.SideBarControl.Sales;

namespace WWWPOS
{
    internal class Class_LoadData : DataBase
    {
    
    //-----Admin Side-----//    

        //Get All Active Product and Store it in Stack
        public void GetActiveProduct()
        {
            try
            {
                connection.Open();

                string selectActiveProductQuery = "SELECT * FROM Products WHERE Product_Status = 'Active' ORDER BY ProductAdd_at DESC";
                sqlCommand = new SqlCommand(selectActiveProductQuery, connection);
                dataReader = sqlCommand.ExecuteReader();

                bool hasItem = false;

                while (dataReader.Read())
                {
                    int productid = int.Parse(dataReader[0] + "");
                    int accountid = int.Parse(dataReader[1] + "");
                    string productcategory = "" + dataReader[2];
                    string productname = "" + dataReader[3];
                    string productcolor = "" + dataReader[4];
                    double productprice = Double.Parse(dataReader[5] + "");
                    int productstock = int.Parse(dataReader[6] + "");

                    Image productimage = Image.FromFile(@"" + dataReader[7]);
                    string productimagepath = "" + dataReader[7];

                    string productsize = "" + dataReader[8];
                    string productdescription = "" + dataReader[9];
                    string productstatus = "" + dataReader[10];
                    string productaddedat = "" + dataReader[11];

                    //Creating a new product
                    Class_Products Products = new Class_Products(productid, accountid, productcategory,
                                                                    productname, productcolor, productprice,
                                                                    productstock, productimagepath, productsize,
                                                                    productdescription, productstatus, productaddedat);

                    //Checkpoint for product duplication
                    if (productsList.Any())
                    {
                        for (int i = 0; i < productsList.Count; i++)
                        {
                            Class_Products CheckProducts = productsList[i];

                            if (CheckProducts.Product_Name == productname)
                            {
                                CheckProducts.Product_Color += "#" + productcolor;
                                CheckProducts.Product_Size += "#" + productsize;
                                hasItem = true;
                                break;
                            }
                            
                        }
                    }

                    if (hasItem == false)
                    {
                        //Adding new product to List
                        productsList.Add(Products);
                    }
                    else if(hasItem == true)
                    {
                        hasItem = false;
                    }

                    //Adding new product to Stack
                    //productsStack.Push(Products);
                }
                dataReader.Close();
                sqlCommand.Clone();
                connection.Close();
            }
            catch (Exception ex)
            {
                ErrorMessage(ex.Message);
            }
        }

        //Get a particular product
        public string[] GetParticularProduct(string productcategory, string productname, string productcolor, string productsize)
        {
            string ProductID = "";
            string AccountID = "";
            string Category = "";
            string Name = "";
            string Color = "";
            string Price = "";
            string Stock = "";
            string ImagePath = "";
            string Size = "";
            string Description = "";
            string Status = "";
            string AddedAt = "";

            try
            {
                connection.Open();
                string selectParticularProductQuery = "SELECT * FROM Products " +
                                                      "WHERE Category = '" + productcategory + "' AND Product_Name = '" + productname + "' " +
                                                      "AND Color = '" + productcolor + "' AND Product_Size = '" + productsize + "' ";
                sqlCommand = new SqlCommand(selectParticularProductQuery, connection);
                dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    //Change the field of the item
                    ProductID = "" + dataReader[0];
                    AccountID = "" + dataReader[1];
                    Category = "" + dataReader[2];
                    Name = "" + dataReader[3];
                    Color = "" + dataReader[4];
                    Price = "" + dataReader[5];
                    Stock = "" + dataReader[6];
                    ImagePath = "" + dataReader[7];
                    Size = "" + dataReader[8];
                    Description = "" + dataReader[9];
                    Status = "" + dataReader[10];
                    AddedAt = "" + dataReader[11];
                }

            }
            catch (Exception ex)
            {
                ErrorMessage(ex.Message);
            }
            connection.Close();
            
            string[] name = { ProductID, AccountID, Category, Name, Color, Price, Stock, ImagePath, Size, Description, Status, AddedAt };


            return name;
        }

        //Fetching All Stocks
        public void selectProduct(FlowLayoutPanel flowLayoutPanel, string productPanel)
        {
            //Calls the method
            GetActiveProduct();

            //Read
            if (productPanel == "panelView")
            {
                for (int i = 0; i < productsList.Count; i++)
                {
                    Class_Products objClassProducts = productsList[i];

                    UserControl_AdminViewProducts adminViewProducts =
                    new UserControl_AdminViewProducts(objClassProducts.Product_ID, objClassProducts.Product_Category,
                                                      objClassProducts.Product_Name, objClassProducts.Product_Price,
                                                      objClassProducts.Product_Stock, objClassProducts.Product_Color,
                                                      objClassProducts.Product_Size, objClassProducts.Product_Descripiton,
                                                      Image.FromFile(objClassProducts.Product_Images));

                    flowLayoutPanel.Controls.Add(adminViewProducts);
                }
            }
            //Update
            else if (productPanel == "panelEdit")
            {
                for (int i = 0; i < productsList.Count; i++)
                {
                    Class_Products objClassProducts = productsList[i];

                    UserControl_Update adminViewUpdateProducts =
                    new UserControl_Update(objClassProducts.Product_ID, objClassProducts.Product_Category,
                                                      objClassProducts.Product_Name, objClassProducts.Product_Price,
                                                      objClassProducts.Product_Stock, objClassProducts.Product_Color,
                                                      objClassProducts.Product_Size, objClassProducts.Product_Descripiton,
                                                      Image.FromFile(objClassProducts.Product_Images));

                    flowLayoutPanel.Controls.Add(adminViewUpdateProducts);
                }
            }
            //Delete
            else if (productPanel == "panelDelete")
            {
                for (int i = 0; i < productsList.Count; i++)
                {
                    Class_Products objClassProducts = productsList[i];

                    UserControl_Delete adminDeleteProducts =
                    new UserControl_Delete(objClassProducts.Product_ID, objClassProducts.Product_Category,
                                                      objClassProducts.Product_Name, objClassProducts.Product_Price,
                                                      objClassProducts.Product_Stock, objClassProducts.Product_Color,
                                                      objClassProducts.Product_Size, objClassProducts.Product_Descripiton,
                                                      Image.FromFile(objClassProducts.Product_Images));

                    flowLayoutPanel.Controls.Add(adminDeleteProducts);
                }
            }

        }

        //Active User
        public void userRecords(DataGridView dataCustomer, string user_Type, string user_Status)
        {
            connection.Open();
            command = new SqlCommand("SELECT * FROM Account WHERE User_Type = '" + user_Type + "' AND User_Status = '" + user_Status + "'  ORDER BY Register_at DESC", connection);
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
            command = new SqlCommand("SELECT * FROM Account WHERE User_Status = '" + user_Status + "'  ORDER BY Register_at DESC", connection);
            mdr = command.ExecuteReader();

            while (mdr.Read())
            {
                dataCustomer.Rows.Add(mdr[0].ToString(), mdr[1].ToString(), mdr[2].ToString(), mdr[3].ToString(), mdr[4].ToString(), mdr[5].ToString(), mdr[7].ToString(), mdr[6].ToString(), mdr[8].ToString());
            }
            connection.Close();
        }

        //Load product archive
        public void ProductArchive(DataGridView dataProduct, string product_Status)
        {

            connection.Open();
            command = new SqlCommand("SELECT * FROM Products WHERE Product_Status = '" + product_Status + "' ORDER BY ProductAdd_at DESC", connection);
            mdr = command.ExecuteReader();

            while (mdr.Read())
            {
                dataProduct.Rows.Add(mdr[0].ToString(), mdr[2].ToString(), mdr[3].ToString(), mdr[4].ToString(), mdr[5].ToString(), mdr[6].ToString(), mdr[8].ToString(), mdr[9].ToString(), mdr[10].ToString(), mdr[11].ToString());
            }
            connection.Close();
        }

        //Dashboard
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
        public string AllSales(string sales)
        {
            try
            {
                connection.Open();
                string selectQuery = "SELECT SUM(Price) FROM Orders WHERE OrderStatus = 'Success'";
                command = new SqlCommand(selectQuery, connection);
                mdr = command.ExecuteReader();

                double numberOfSales = 0;

                if (mdr.Read())
                {
                    numberOfSales = Double.Parse(mdr[0] + "");
                }

                int convertedSales = Convert.ToInt32(numberOfSales);

                sales = convertedSales.ToString();
            }
            catch (Exception ex)
            {
                ErrorMessage(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            
            return sales;
        }
        public void LoadChartSales(UserControlDashboard userControlDashboard)
        {
            try
            {
                connection.Open();

                string loadChartQuery = "SELECT ProductID, Name, Category, Quantity  FROM Orders WHERE OrderStatus = 'Success'";

                command = new SqlCommand(loadChartQuery, connection);
                mdr = command.ExecuteReader();

                ClassProductSales classProductSales = new ClassProductSales();
                bool hasSameValue = false;

                while (mdr.Read())
                {
                    if (classProductSales.ProductCategory.Any())
                    {
                        foreach(string category in classProductSales.ProductCategory)
                        {
                            if (category == "" + mdr[2])
                            {
                                hasSameValue = true;
                                //gets the index of list by finding its value
                                int indexOfCategory = classProductSales.ProductCategory.IndexOf(category);
                                //gets the value of list by its index
                                int valueOfIndexCategory = classProductSales.ProductQuantity[indexOfCategory];
                                //updating the list value by its index
                                classProductSales.ProductQuantity[indexOfCategory] = valueOfIndexCategory + Int32.Parse(mdr[3] + "");
                                break;

                            }
                        }
                    }

                    if (hasSameValue == false)
                    {
                        classProductSales.ProductCategory.Add("" + mdr[2]);
                        classProductSales.ProductQuantity.Add(Int32.Parse(mdr[3] + ""));
                    }else if(hasSameValue == true)
                    {
                        hasSameValue = false;
                    }
                    
                }

                //checks the value of classProductsSales
                foreach (string sales in classProductSales.ProductCategory)
                {
                    userControlDashboard.xValuescategory.Add(sales);
                }
                //checks the value of classProductsSales
                foreach (int products in classProductSales.ProductQuantity)
                {
                    userControlDashboard.yValuesquantity.Add(products);
                }

            }
            catch (Exception ex)
            {
                ErrorMessage(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            
        }

        //Sales
        public void GetDesiredChartData(UserControlSales UC_Sales, string query, string whatProduct)
        {
            //"SELECT ProductID, Name, Category, Quantity  FROM Orders WHERE OrderStatus = 'Success'"

            try
            {
                connection.Open();

                string loadDesiredChartQuery = query;

                command = new SqlCommand(loadDesiredChartQuery, connection);
                mdr = command.ExecuteReader();

                ClassSalesChartData classSalesChartData = new ClassSalesChartData();
                bool hasSameValue = false;
                int numProduct = 0;
                int numQuantity = 0;

                while (mdr.Read())
                {
                    switch (whatProduct)
                    {
                        case "AllProduct":
                            numProduct = 1;
                            numQuantity = 3;
                            break;

                        case "ParticularProduct":
                            numProduct = 1;
                            numQuantity = 2;
                            break;
                    }

                    if (classSalesChartData.Product.Any())
                    {
                        foreach (string product in classSalesChartData.Product)
                        {
                            if (product == "" + mdr[numProduct])
                            {
                                hasSameValue = true;
                                //gets the index of list by finding its value
                                int indexOfCategory = classSalesChartData.Product.IndexOf(product);
                                //gets the value of list by its index
                                int valueOfIndexCategory = classSalesChartData.Quantity[indexOfCategory];
                                //updating the list value by its index
                                classSalesChartData.Quantity[indexOfCategory] = valueOfIndexCategory + Int32.Parse(mdr[numQuantity] + "");
                                break;
                            }
                        }
                    }

                    if (hasSameValue == false)
                    {
                        classSalesChartData.Product.Add("" + mdr[numProduct]);
                        classSalesChartData.Quantity.Add(Int32.Parse(mdr[numQuantity] + ""));
                    }
                    else if (hasSameValue == true)
                    {
                        hasSameValue = false;
                    }

                }

                UC_Sales.xValues.Clear();
                UC_Sales.yValues.Clear();

                //checks the value of classProductsSales
                foreach (string sales in classSalesChartData.Product)
                {
                    UC_Sales.xValues.Add(sales);
                }
                //checks the value of classProductsSales
                foreach (int products in classSalesChartData.Quantity)
                {
                    UC_Sales.yValues.Add(products);
                }

            }
            catch (Exception ex)
            {
                ErrorMessage(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        //-----Client Side-----//

        //Loads available product
        public void LoadAllAvailableProducts(FlowLayoutPanel flowLayoutPanel, string productPanel)
        {
            //Calls the method
            GetActiveProduct();

            switch (productPanel)
            {
                case "AllProduct":

                    for (int i = 0; i < productsList.Count; i++)
                    {
                        Class_Products objClassProducts = productsList[i];

                        UserControl_Product UC_Products =
                        new UserControl_Product(objClassProducts.Product_ID, objClassProducts.Product_Images, objClassProducts.Product_Name,
                                                objClassProducts.Product_Price, objClassProducts.Product_Stock, objClassProducts.Product_Descripiton,
                                                objClassProducts.Product_Size, objClassProducts.Product_Color, objClassProducts.Product_Category);
                        if (objClassProducts.Product_Stock >= 1)
                        {
                            flowLayoutPanel.Controls.Add(UC_Products);
                        }
                    }

                    break;

                case "TshirtProduct":

                    for (int i = 0; i < productsList.Count; i++)
                    {
                        Class_Products objClassProducts = productsList[i];

                        UserControl_Product UC_Products =
                        new UserControl_Product(objClassProducts.Product_ID, objClassProducts.Product_Images, objClassProducts.Product_Name,
                                                objClassProducts.Product_Price, objClassProducts.Product_Stock, objClassProducts.Product_Descripiton,
                                                objClassProducts.Product_Size, objClassProducts.Product_Color, objClassProducts.Product_Category);

                        switch (objClassProducts.Product_Category)
                        {
                            case "T-Shirts":
                                if (objClassProducts.Product_Stock >= 1)
                                {
                                    flowLayoutPanel.Controls.Add(UC_Products);
                                }
                                break;
                        }
                        
                    }

                    break;

                case "ShortProduct":

                    for (int i = 0; i < productsList.Count; i++)
                    {
                        Class_Products objClassProducts = productsList[i];

                        UserControl_Product UC_Products =
                        new UserControl_Product(objClassProducts.Product_ID, objClassProducts.Product_Images, objClassProducts.Product_Name,
                                                objClassProducts.Product_Price, objClassProducts.Product_Stock, objClassProducts.Product_Descripiton,
                                                objClassProducts.Product_Size, objClassProducts.Product_Color, objClassProducts.Product_Category);

                        switch (objClassProducts.Product_Category)
                        {
                            case "Shorts":
                                if (objClassProducts.Product_Stock >= 1)
                                {
                                    flowLayoutPanel.Controls.Add(UC_Products);
                                }
                                break;
                        }

                    }

                    break;
            }

        }

        //Load Cart
        public void LoadCart(FlowLayoutPanel flowLayoutPanel)
        {
            string userid = DataBase.user_ID;
            int user_ID = Int32.Parse(userid);

            try
            {
                connection.Open();
                string selectJoinedQuerry = "SELECT * FROM[waywewore].[dbo].[Cart] AS Cart INNER JOIN[waywewore].[dbo].[Products] " +
                                            "AS Product ON Cart.Product_ID = Product.Product_ID " +
                                            "WHERE Cart.Account_ID = '" + user_ID + "' AND Cart.Cart_Status IS NULL ORDER BY [Cart].ProductAddedToCart_at DESC";

                command = new SqlCommand(selectJoinedQuerry, connection);
                mdr = command.ExecuteReader();

                int total = 0;

                while (mdr.Read())
                {
                    string productStatus = "" + mdr[11];
                    int productStocks = Int32.Parse(mdr[20] + "");

                    if (productStatus == "Inactive" || productStocks <= 0)
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
                        UC_ProductCartInactive.cmb_ProductSize.Enabled = false;
                        UC_ProductCartInactive.cmb_Color.Enabled = false;


                        flowLayoutPanel.Controls.Add(UC_ProductCartInactive);
                    }
                    else if (productStatus == "Active")
                    {
                        int cartID = int.Parse(mdr[0] + "");
                        int productID = Int32.Parse(mdr[2] + "");
                        Image image = Image.FromFile(@"" + mdr[8]);
                        double price = Double.Parse(mdr[6] + "");
                        int quantity = Int32.Parse(mdr[7] + "");
                        total = Convert.ToInt32(price) * quantity;
                        int stock = Int32.Parse(mdr[20] + "");
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

                string selectJoinedQuerry = "SELECT* FROM[waywewore].[dbo].[Cart] AS Cart INNER JOIN[waywewore].[dbo].[Products] AS Product ON Cart.Product_ID = Product.Product_ID " +
                                            "WHERE Cart.Account_ID = '" + user_ID + "' AND Product.Product_Status = 'Active' AND Cart.Cart_Status IS NULL AND Product.Stocks >= 1" +
                                            "ORDER BY[Cart].ProductAddedToCart_at DESC";
                
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
                    int stock = Int32.Parse(mdr[20] + "");
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
            int userID = Int32.Parse(DataBase.user_ID);

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

                string selectJoinedQuerry = "SELECT * FROM[waywewore].[dbo].[Cart] AS Cart INNER JOIN[waywewore].[dbo].[Products] AS Product " +
                    "                       ON Cart.Product_ID = Product.Product_ID WHERE Cart.Account_ID = '" + user_ID + "' AND Product.Product_Status = 'Active' AND Product.Stocks >= 1";
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
                    int stock = Int32.Parse(mdr[20] + "");
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

        //-----Cashier Side-----//
        
        //Load Order ID
        public void GetOrderID(FlowLayoutPanel flowLayoutPanel)
        {
            //Gets the data from Orders Table
            GetDataFromOrderTable();


            if (classOrderStatus.Any())
            {
                List<int> objOrderNumber = new List<int>();

                bool hasSameOrderNumber = false;

                //Dummy to have a copy of instance UserControl_PendingOrderContainer to add ParticularPendingProducts
                Class_OrdersStatus DummyObjClassOrderStatus = classOrderStatus[0];
                UserControl_PendingOrderContainer Dummy_UC_PendingOrderContainer = new UserControl_PendingOrderContainer(DummyObjClassOrderStatus.OrderNumber);
                int DummyOrderTotalPrice = 0;

                for (int i = 0; i < classOrderStatus.Count; i++)
                {
                    Class_OrdersStatus objClassOrderStatus = classOrderStatus[i];

                    //checks if the Collections has any value
                    if (objOrderNumber.Any())
                    {
                        for (int orderNumberIndex = 0; orderNumberIndex < objOrderNumber.Count; orderNumberIndex++)
                        {

                            if (objClassOrderStatus.OrderNumber == objOrderNumber[orderNumberIndex])
                            {
                                hasSameOrderNumber = true;

                                //Just Add particular pending orders on the Pending orders container
                                UserControl_ParticularPendingOrder UC_ParticularPendingOrder =
                            new UserControl_ParticularPendingOrder(objClassOrderStatus.OrderNumber, objClassOrderStatus.OrderID, objClassOrderStatus.Name, objClassOrderStatus.Category, objClassOrderStatus.Color,
                                                                   objClassOrderStatus.Size, objClassOrderStatus.Price, objClassOrderStatus.Quantity,
                                                                   (objClassOrderStatus.Quantity * Convert.ToInt32(objClassOrderStatus.Price)), objClassOrderStatus.Status);
                                //

                                try
                                {

                                    connection.Open();
                                    string checkStockQuery = "SELECT Products.Stocks, Orders.Quantity, Orders.OrderNumber " +
                                                             "FROM [waywewore].[dbo].Products AS Products " +
                                                             "INNER JOIN [waywewore].[dbo].Orders AS Orders ON Products.Product_ID = Orders.ProductID " +
                                                             "WHERE Products.Product_ID = '" + objClassOrderStatus.ProductId + "' AND Orders.ProductID = '" + objClassOrderStatus.ProductId + "' " +
                                                             "AND Orders.OrderStatus = 'Pending' AND Orders.OrderNumber = '" + objClassOrderStatus.OrderNumber + "' ";
                                    sqlCommand = new SqlCommand(checkStockQuery, connection);
                                    mdr = sqlCommand.ExecuteReader();

                                    if (mdr.Read())
                                    {
                                        if (Int32.Parse(mdr[0] + "") < Int32.Parse(mdr[1] + ""))
                                        {
                                            //
                                            Dummy_UC_PendingOrderContainer.btn_MarkAsSuccess.Enabled = false;
                                            Dummy_UC_PendingOrderContainer.btn_MarkAsSuccess.BackColor = Color.DimGray;

                                            UC_ParticularPendingOrder.lbl_IsPacked.BackColor = Color.IndianRed;
                                            UC_ParticularPendingOrder.lbl_IsPacked.ForeColor = Color.WhiteSmoke;
                                            UC_ParticularPendingOrder.lbl_IsPacked.Visible = true;
                                            UC_ParticularPendingOrder.lbl_IsPacked.Text = "Product Unavailable";
                                            UC_ParticularPendingOrder.btn_ItemPacked.Enabled = false;

                                            Dummy_UC_PendingOrderContainer.flPanel_ParticularItem.Controls.Add(UC_ParticularPendingOrder);
                                        }
                                        else
                                        {
                                            Dummy_UC_PendingOrderContainer.flPanel_ParticularItem.Controls.Add(UC_ParticularPendingOrder);

                                            DummyOrderTotalPrice += Convert.ToInt32(objClassOrderStatus.Price) * objClassOrderStatus.Quantity;
                                            Dummy_UC_PendingOrderContainer.lbl_OrderTotal.Text = DummyOrderTotalPrice.ToString();
                                        }
                                    }

                                    connection.Close();
                                }
                                catch (Exception ex)
                                {
                                    // Show any error message.
                                    ErrorMessage("I am here " + ex.Message);
                                    connection.Close();
                                }

                                //
                                //Dummy_UC_PendingOrderContainer.flPanel_ParticularItem.Controls.Add(UC_ParticularPendingOrder);

                                //DummyOrderTotalPrice += Convert.ToInt32(objClassOrderStatus.Price) * objClassOrderStatus.Quantity;
                                //Dummy_UC_PendingOrderContainer.lbl_OrderTotal.Text = DummyOrderTotalPrice.ToString();
                            }

                        }

                    }

                    if (hasSameOrderNumber == false)
                    {
                        DummyOrderTotalPrice = 0; 
                        UserControl_PendingOrderContainer UC_PendingOrderContainer = new UserControl_PendingOrderContainer(objClassOrderStatus.OrderNumber);

                        //re-assign the instance of dummy UserControl_PendingOrderContainer
                        Dummy_UC_PendingOrderContainer = UC_PendingOrderContainer;

                        flowLayoutPanel.Controls.Add(UC_PendingOrderContainer);
                        objOrderNumber.Add(objClassOrderStatus.OrderNumber);

                        UserControl_ParticularPendingOrder UC_ParticularPendingOrder =
                    new UserControl_ParticularPendingOrder(objClassOrderStatus.OrderNumber, objClassOrderStatus.OrderID, objClassOrderStatus.Name, objClassOrderStatus.Category, objClassOrderStatus.Color,
                                                                   objClassOrderStatus.Size, objClassOrderStatus.Price, objClassOrderStatus.Quantity,
                                                                   (objClassOrderStatus.Quantity * Convert.ToInt32(objClassOrderStatus.Price)), objClassOrderStatus.Status);

                        //
                        try
                        {
                            
                            connection.Open();
                            string checkStockQuery = "SELECT Products.Stocks, Orders.Quantity, Orders.OrderNumber " +
                                                     "FROM [waywewore].[dbo].Products AS Products " +
                                                     "INNER JOIN [waywewore].[dbo].Orders AS Orders ON Products.Product_ID = Orders.ProductID " +
                                                     "WHERE Products.Product_ID = '" + objClassOrderStatus.ProductId + "' AND Orders.ProductID = '" + objClassOrderStatus.ProductId + "' " +
                                                     "AND Orders.OrderStatus = 'Pending' AND Orders.OrderNumber = '" + objClassOrderStatus.OrderNumber + "' ";
                            sqlCommand = new SqlCommand(checkStockQuery, connection);
                            mdr = sqlCommand.ExecuteReader();

                            if (mdr.Read())
                            {
                                if (Int32.Parse(mdr[0] + "") < Int32.Parse(mdr[1] + ""))
                                {
                                    //
                                    UC_PendingOrderContainer.btn_MarkAsSuccess.Enabled = false;
                                    UC_PendingOrderContainer.btn_MarkAsSuccess.BackColor = Color.DimGray;

                                    UC_ParticularPendingOrder.lbl_IsPacked.BackColor = Color.IndianRed;
                                    UC_ParticularPendingOrder.lbl_IsPacked.ForeColor = Color.WhiteSmoke;
                                    UC_ParticularPendingOrder.lbl_IsPacked.Visible = true;
                                    UC_ParticularPendingOrder.lbl_IsPacked.Text = "Product Unavailable";
                                    UC_ParticularPendingOrder.btn_ItemPacked.Enabled = false;

                                    UC_PendingOrderContainer.flPanel_ParticularItem.Controls.Add(UC_ParticularPendingOrder);
                                }
                                else
                                {
                                    UC_PendingOrderContainer.flPanel_ParticularItem.Controls.Add(UC_ParticularPendingOrder);

                                    int OrderTotalPrice = Convert.ToInt32(objClassOrderStatus.Price) * objClassOrderStatus.Quantity;
                                    DummyOrderTotalPrice += OrderTotalPrice;

                                    UC_PendingOrderContainer.lbl_OrderTotal.Text = DummyOrderTotalPrice.ToString();
                                }
                            }

                            connection.Close();
                        }
                        catch (Exception ex)
                        {
                            // Show any error message.
                            ErrorMessage("I am here " + ex.Message);
                            connection.Close();
                        }
                        //

                        //UC_PendingOrderContainer.flPanel_ParticularItem.Controls.Add(UC_ParticularPendingOrder);

                        //int OrderTotalPrice = Convert.ToInt32(objClassOrderStatus.Price) * objClassOrderStatus.Quantity;
                        //DummyOrderTotalPrice += OrderTotalPrice;

                        //UC_PendingOrderContainer.lbl_OrderTotal.Text = DummyOrderTotalPrice.ToString();
                    }
                    else if (hasSameOrderNumber)
                    {
                        hasSameOrderNumber = false;
                    }
                }

            }
        }

        //Get the length of order
        public int GetOrderQuantity (int orderNumber)
        {
            int orderQty = 0;
            //Deletes the particular order
            try
            {
                connection.Open();
                string getOrderQuantity = "SELECT COUNT(*) FROM Orders WHERE OrderNumber = '" + orderNumber + "' ";

                sqlCommand = new SqlCommand(getOrderQuantity, connection);
                dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    orderQty = Int32.Parse(dataReader[0] + "");
                }
                
            }
            catch (Exception ex)
            {
                // Show any error message.
                ErrorMessage(ex.Message);
            }
            connection.Close();
            return orderQty;
        }

        //Get Success Orders
        public void GetSuccessOrders(DataGridView dataProduct)
        {
            //Get success Orders
            try
            {
                connection.Open();

                string getSuccessOrderQuery = "SELECT * FROM Orders WHERE OrderStatus = 'Success' ORDER BY OrderID DESC";
                sqlCommand = new SqlCommand(getSuccessOrderQuery, connection);
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
                    int totalPrice = Convert.ToInt32( Convert.ToInt32(price) * quantity);
                    string imagePath = "" + dataReader[10];
                    string status = "" + dataReader[11];
                    string orderStatus = "" + dataReader[12];
                    string addedToCartAt = "" + dataReader[13];
                    string placedOrder = "" + dataReader[14];

                    dataProduct.Rows.Add(dataReader[0].ToString(), dataReader[5].ToString(), dataReader[4].ToString(), dataReader[6].ToString(), dataReader[7].ToString(), dataReader[8].ToString(), dataReader[9].ToString(), totalPrice.ToString());

                }

            }
            catch (Exception ex)
            {
                ErrorMessage(ex.Message);
            }

            connection.Close();
        }

        //Load Purchase
        public void GetPurchaseOrder(DataGridView dataProduct, string whatPurchase)
        {
            switch (whatPurchase)
            {

                case "TShirt":

                    try
                    {
                        connection.Open();
                        string getTShirtPurchaseQuery = "SELECT * FROM Orders WHERE OrderStatus = 'Success' AND Category = 'T-Shirts' ORDER BY OrderID DESC";
                        sqlCommand = new SqlCommand(getTShirtPurchaseQuery, connection);
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
                            int totalPrice = Convert.ToInt32(Convert.ToInt32(price) * quantity);
                            string imagePath = "" + dataReader[10];
                            string status = "" + dataReader[11];
                            string orderStatus = "" + dataReader[12];
                            string addedToCartAt = "" + dataReader[13];
                            string placedOrder = "" + dataReader[14];

                            dataProduct.Rows.Add(dataReader[0].ToString(), dataReader[5].ToString(), dataReader[4].ToString(), dataReader[6].ToString(), dataReader[7].ToString(), dataReader[8].ToString(), dataReader[9].ToString(), totalPrice.ToString());
                        }

                    }
                    catch (Exception ex)
                    {
                        ErrorMessage(ex.Message);
                    }

                    connection.Close();

                    break;

                case "Short":

                    try
                    {
                        connection.Open();
                        string getTShirtPurchaseQuery = "SELECT * FROM Orders WHERE OrderStatus = 'Success' AND Category = 'Shorts' ORDER BY OrderID DESC";
                        sqlCommand = new SqlCommand(getTShirtPurchaseQuery, connection);
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
                            int totalPrice = Convert.ToInt32(Convert.ToInt32(price) * quantity);
                            string imagePath = "" + dataReader[10];
                            string status = "" + dataReader[11];
                            string orderStatus = "" + dataReader[12];
                            string addedToCartAt = "" + dataReader[13];
                            string placedOrder = "" + dataReader[14];

                            dataProduct.Rows.Add(dataReader[0].ToString(), dataReader[5].ToString(), dataReader[4].ToString(), dataReader[6].ToString(), dataReader[7].ToString(), dataReader[8].ToString(), dataReader[9].ToString(), totalPrice.ToString());
                        }

                    }
                    catch (Exception ex)
                    {
                        ErrorMessage(ex.Message);
                    }

                    connection.Close();

                    break;
            }

        }
    }
}
