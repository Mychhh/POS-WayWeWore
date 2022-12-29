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

                string selectActiveProductQuery = "SELECT * FROM Products WHERE Product_Status = 'Active';";
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
            command = new SqlCommand("SELECT * FROM Account WHERE User_Type = '" + user_Type + "' AND User_Status = '" + user_Status + "'", connection);
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

        //Load product archive
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

                        flowLayoutPanel.Controls.Add(UC_Products);
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
                                flowLayoutPanel.Controls.Add(UC_Products);
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
                                flowLayoutPanel.Controls.Add(UC_Products);
                                break;
                        }

                    }

                    break;
            }

        }

        public void LoadCart(FlowLayoutPanel flowLayoutPanel)
        {
            string userid = DataBase.user_ID;
            int user_ID = Int32.Parse(userid);

            try
            {
                connection.Open();
                string selectJoinedQuerry = "SELECT * FROM[waywewore].[dbo].[Cart] AS Cart INNER JOIN[waywewore].[dbo].[Products] " +
                                            "AS Product ON Cart.Product_ID = Product.Product_ID " +
                                            "WHERE Cart.Account_ID = '" + user_ID + "' ";

                command = new SqlCommand(selectJoinedQuerry, connection);
                mdr = command.ExecuteReader();

                int total = 0;

                while (mdr.Read())
                {
                    string productStatus = "" + mdr[11];

                    if (productStatus == "Inactive")
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

                        Console.WriteLine(color);

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

                string selectJoinedQuerry = "SELECT * FROM[waywewore].[dbo].[Cart] AS Cart INNER JOIN[waywewore].[dbo].[Products] AS Product " +
                    "                       ON Cart.Product_ID = Product.Product_ID WHERE Cart.Account_ID = '" + user_ID + "' AND Product.Product_Status = 'Active' ";
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
