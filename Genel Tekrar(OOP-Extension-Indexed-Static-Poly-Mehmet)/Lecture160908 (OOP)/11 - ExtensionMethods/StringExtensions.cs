using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11___ExtensionMethods
{
    // Extensions Methods
    //1. Daha önceden yazımı tamamlanmış (derlenmiş) sınıflara, instance metodu gibi görünen metotları sonradan yazmaktır. Genişleme metotları(sınıfları sonradan genişletmek gibi düşünülebilir)
    //2. Extension metot yazdığıız sınıf static olmalıdır.
    //3. Extension metotlar STATIC yazılmalıdır.

    static class StringExtensions
    {
        // Neye extensions yazıyorsak onun ayrı sınıfı olsun parametreye bakmak lazım. 
        //string value parametresine bak
        public static string FullTrim(this string value)
        {
            return " ";
        }

        public static string FullTrim2(this string value, int index)
        {
            return " ";
        }


        public static int ToInt(this string value)
        {
            int number;
            int.TryParse(value, out number);
            return number;
        }

    }
}
