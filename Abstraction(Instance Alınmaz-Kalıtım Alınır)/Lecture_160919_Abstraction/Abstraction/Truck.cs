using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Truck : Vehicle  // Vehicle üstüne gelip Ctrl . dediğinde tüm abstractları getirir. Overrideleri. 
    {
      
        public int LoadCapacity { get; set; }  // Taşıma kapasitesi

        public override string Start()
        {
            return "Gür gür gür gür";
        }

        public override string Stop()
        {
            return "Ippssss";
        }
        public override string Horn()
        {
            return "Darirarirarira";
        }

        public override string ToString()
        {
            return "Kamyon";
        }

    }
}
