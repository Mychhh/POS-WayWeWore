using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WWWPOS.ClassOrders;

namespace WWWPOS
{
    internal class Class_Orders : Abstract_Orders
    {
        public Class_Orders(int orderNumber, int accountID, int productID,
                            string name, string category, string color,
                            string size, double price, int quantity,
                            string imagePath, string status, string orderStatus,
                            string addedToCartAt) 
                     : base(orderNumber, accountID, productID,
                            name, category, color,
                            size, price, quantity,
                            imagePath, status, orderStatus,
                            addedToCartAt)
        {}
    }
}
