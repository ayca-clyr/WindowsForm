using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_OOP_Polymorhism_Çok_Biçimlilik_
{
    class Insan
    {
        public string TCKN { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }

        public virtual void YogurtYe()
        {

        }
    }
}
