using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWWPOS
{
    internal class Class_Orders
    {
        public int OrderNumber { get; set; }
        public int AccountID { get; set; }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string ImagePath { get; set; }
        public string Status { get; set; }
        public string OrderStatus { get; set; }
        public string AddedToCartAt { get; set; }

        public Class_Orders(int orderNumber, int accountID, int productID,
                            string name, string category, string color, string size, 
                            double price, int quantity, string imagePath, 
                            string status, string orderStatus, string addedToCartAt)
        {
            OrderNumber = orderNumber;
            AccountID = accountID;
            ProductID = productID;
            Name = name;
            Category = category;
            Color = color;
            Size = size;
            Price = price;
            Quantity = quantity;
            ImagePath = imagePath;
            Status = status;
            OrderStatus = orderStatus;
            AddedToCartAt = addedToCartAt;
        }
    }
}
