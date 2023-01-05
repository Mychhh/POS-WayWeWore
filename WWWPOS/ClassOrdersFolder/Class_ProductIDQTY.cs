using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWWPOS.ClassOrdersFolder
{
    internal class Class_ProductIDQTY
    {
        public int ProductID { get; set; }
        public int ProductQTY { get; set; }

        public Class_ProductIDQTY(int productID, int productQTY)
        {
            ProductID = productID;
            ProductQTY = productQTY;
        }
    }
}
