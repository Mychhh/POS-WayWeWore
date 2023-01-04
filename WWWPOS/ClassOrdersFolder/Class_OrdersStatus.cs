using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWWPOS
{
    internal class Class_OrdersStatus
    {
        public int OrderID { get; set; }
        public int OrderNumber { get; set; }
        public int AccountID { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string ImagePath { get; set; }
        public string Status { get; set; }
        public string OrderStatus  { get; set; }
        public string AddedToCartAt { get; set; }
        public string PlacedOrder { get; set; }

        public Class_OrdersStatus(int orderID, int orderNumber, int accountID, int productId, string name, string category, string color, string size, double price, int quantity, string imagePath, string status, string orderStatus, string addedToCartAt, string placedOrder)
        {
            OrderID = orderID;
            OrderNumber = orderNumber;
            AccountID = accountID;
            ProductId = productId;
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
            PlacedOrder = placedOrder;
        }
    }
}
