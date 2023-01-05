using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWWPOS.ClassOrdersFolder
{
    internal class Class_OrderIDQTY
    {
        public int ProductID { get; set; }
        public int ProductQty { get; set; }

        public Class_OrderIDQTY(int productID, int productQty)
        {
            ProductID = productID;
            ProductQty = productQty;
        }

    }
}
