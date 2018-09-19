using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11___ExtensionMethods
{
    static class Int32Extensions
    {
        // Neye extensions yazıyorsak onun ayrı sınıfı olsun parametreye bakmak lazım. 
        //this int value parametresine bak

        public static bool ToBoolean(this int value)
        {
            if (value == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
