using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_OOP_Polymorhism_Çok_Biçimlilik_
{
    class Ogrenci:Insan
    {
        //Virtual : Override edilebilmesine müsade etmektir.
        //Override: Metodun içini değiştirmektir.
        

        public decimal Vize { get; set; }
        public decimal Final { get; set; }

        public override string ToString()
        {
            return  Adi+" "+Soyadi;
        }
        public override void YogurtYe()
        {
            
        }
    }
}
