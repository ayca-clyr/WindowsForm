using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapciOrnegi
{
    public class KitapBilgileri
    {
        public string _kitapAdi;
        public string _YazarAdi;
        public DateTime _yayinlanmaTarihi;
        public string _kategori;
        public override string ToString()
        {
            return _kitapAdi + " " + _YazarAdi;
        }
    }
}
