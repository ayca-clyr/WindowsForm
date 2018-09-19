using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Entities
{
   public class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public Nullable<DateTime> ShippedDate { get; set; }
    }
}
