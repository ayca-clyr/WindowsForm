using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7__Abstraction
{
    class Truck : Vehicle
    {
        // Vehicle 'e ctrl + . yap bütün abstract methodlar kendi yazılacak
        public int LoadCapacity { get; set; }


        public override string Start()
        {
            return "Gür gür gür gür";

        }

        public override string Stop()
        {
            return "Ipppsss";
        }


        public override string Horn()
        {
            return "Dooooooooooot";
        }

        public override string ToString()
        {
            return "KAMYON";
        }
    }
}
