using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Uygulama
{
    class SqlHelper
    {
        //Sabit Değer Tanımlama
        //1.const ile sabit değer tanımlayabiliyorum(değeri değiştirilemeyen fieldlardır) (const ile sabit tanımlanan değişkenin ilk değerini o anda vermek şarttır.)
        //2.static ile sabit değer tanımlanabilir. Readonly keyword ile değeri değiştirilemeyen fieldlar yaratırız ancak ilk değeri o anda vermek şart değildir. Constructor metodunda da ilk değer verilebilir.
        static SqlHelper() 
        {
            ConnectionStringStaticReadOnly = "server=AYCACALAYIR\\SQLEXPRESS;database=Northwind;Integrated Security=true;";
            cnn2 = new SqlConnection(ConnectionStringStaticReadOnly);
        }
        //const => constant
        //1.yöntem
        public const string ConnectionString = "server=.;database=Northwind;Integrated Security=true;";
        //2.yöntem
        public static string ConnectionStringStatic = "server=.;database=Northwind;Integrated Security=true;";
        //3.yöntem
        public static readonly string ConnectionStringStaticReadOnly;
        //4.Yöntem => Kod tarafında SqlConnectiondan instance almamak için kullanıyorum. SqlHelper'ın constructor'ında instance alma işlemini gerçekleştirdik.
        public static SqlConnection cnn2 { get; set; }

    }
}
