using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace WWWPOS
{
    internal class Class_Products
    {
        //Representation (Fields)
        public int Product_ID { get; set; }
        public int Account_ID { get; set; }
        public string Product_Category { get; set; }
        public string Product_Name { get; set; }
        public string Product_Color { get; set; }
        public double Product_Price { get; set; }
        public int Product_Stock { get; set; }
        public string Product_Images { get; set; }
        public string Product_Size { get; set; }
        public string Product_Descripiton { get; set; }
        public string Product_Status { get; set; }
        public string Product_Added_At { get; set; }

        //Contructors 
        public Class_Products(int productID, int accountID, string productCategory, string productName,
                       string productColor, double productPrice, int productStock, 
                       string productImages, string productSize, string productDescription,
                       string productStatus, string productAddedAt)
        {
            Product_ID = productID;
            Account_ID = accountID;
            Product_Category = productCategory;
            Product_Name = productName;
            Product_Color = productColor;
            Product_Price = productPrice;
            Product_Stock = productStock;
            Product_Images = productImages;
            Product_Size = productSize;
            Product_Descripiton = productDescription;
            Product_Status = productStatus;
            Product_Added_At = productAddedAt;
        }

        //Methods (Operation)
    }
}
