using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_OOP_Inheritance
{
    public class Ogrenci:Insan // Insan sınıfından miras aldık. Ebebeyn olan Insandır.
    {
        public string  OkulNo { get; set; }
        public double  Vize { get; set; }
        public double Final { get; set; }
        
    }
}
