using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWWPOS.ClassOrdersFolder
{
    internal class Class_InvoiceCashier
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public int Subtotal { get; set; }

        public Class_InvoiceCashier(string productName, int quantity, int subtotal)
        {
            ProductName = productName;
            Quantity = quantity;
            Subtotal = subtotal;
        }
    }
}
