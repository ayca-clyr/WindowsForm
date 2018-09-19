using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1__Example
{
   abstract class Electronic
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public Color Color { get; set; }
        public int WarrantyPeriod { get; set; }
    }
}
