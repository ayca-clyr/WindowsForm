using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    static class Int32Extension
    {
        public static bool ToBoolean(this int value)
        {
            if (value == 0)
            {
                return false;
            }
            return true;
        }
    }
}
