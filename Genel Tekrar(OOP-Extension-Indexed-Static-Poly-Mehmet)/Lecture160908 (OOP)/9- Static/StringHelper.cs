using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9__Static
{
   static class StringHelper
    {
        public static string FullTrim(string value)
        {
            string trimmedValue = value.Trim();

            string fixedValue = "";

            for (int i = 0; i < trimmedValue.Length; i++)
            {
                if (i == 0)
                {
                    fixedValue += char.ToUpper(trimmedValue[i]);
                }
                else
                {
                    fixedValue += char.ToLower(trimmedValue[i]);
                }
            }

            return fixedValue;
        }
    }
}
