using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_03
{
    class SqlHelper
    {
        // Sabit Değer Tanımlama
        // 1.Const ile sabit değer tanımlayabiliyorum (değeri değiştirilemeyen fieldlardır.)(const ile sabit tanımlanan değişkenin ilk değerini o anda vermek şarttır.)
        // 2.Static ile sabit değer tanımlanabilir. Readonly keyword ile değeri değiştirelemeyen field'lar yaratırız. Ama ilk değeri o anda vermek şart değildir. Constructor metodunda da ilk değer verilebilir.
        static SqlHelper()
        {
            ConnectionStringStaticReadonly = "server=PC;database=Northwind;Integrated Security=true;";
            cnn2 = new SqlConnection(ConnectionStringStaticReadonly);
        }

        // 1.Yöntem
        //const => constant

        public const string Connection = "server=PC;database=Northwind;Integrated Security=true;";

        // 2.Yöntem
        public static string ConnectionStringStatic = "server=PC;database=Northwind;Integrated Security=true";

        // 3.Yöntem
        public static readonly string ConnectionStringStaticReadonly;

        // 4.Yöntem => Kod tarafından SqlConnection'dan instance almamak için kullanıyorum.SqlHelper'in constructor'ında instance alma işlemini gerçekleştirdik.
        public static SqlConnection cnn2 { get; set; }
 
    }
}
