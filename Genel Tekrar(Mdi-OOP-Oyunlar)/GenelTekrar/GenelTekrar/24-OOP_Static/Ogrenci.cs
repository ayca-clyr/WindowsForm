using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_OOP_Static
{
    class Ogrenci
    {
        public Ogrenci()
        {
            TanimliOgrenciSayisi++;
        }
        public static int TanimliOgrenciSayisi { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string OkulNo { get; set; }
        public string TCKN { get; set; }

        public override string ToString()
        {
            return Adi + " " + Soyadi;
        }
        public static void YoklamaAl()
        {
            //  Metot içinden instance öğelerine (adi ve soyadi gibi) ulaşılamaz. Sadece static elemanlara ulaşılabilir. Çünkü bu metot çalıştığında instance alınmış bir öğe olmayabilir. Ve bu metot bir öğeye bağlı olarak çalışmayacaktır. 

        }
    }
}
