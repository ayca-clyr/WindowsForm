using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    // Extension Methods
    // 1.DAha önceden yazımı tamamlanmış (derlenmiş) sınıflara, instance metodu gibi görünen metotları sonradan yazmaktır. Genişleme metotları (sınıfları sonradan genişletmek gibi düşünülebilir.)
    // 2.Extension metot yazdığını sınıf STATIC olmalıdır.
    // 3.Extension metotlar STATIC yazılmalıdır.
    static class StringExtensions
    {
       // public static string FullTrim(this string value, int index)
        //{
        //    
        //    return "";
        //}
        public static string FullTrim(this string value)
        {
            //
            return "";
        }

        public static int ToInt(this string value)
        {
            int number;
            int.TryParse(value, out number);
            return number;
        }



    }
}
