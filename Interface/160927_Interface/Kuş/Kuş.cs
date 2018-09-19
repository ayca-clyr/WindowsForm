using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuş
{
    abstract class Kuş
    {
        private string _tur;
        public string Tur
        {
            get { return _tur; }
            set { _tur = value; }
        }
        private string _renk;
        public string Renk
        {
            get { return _renk; }
            set { _renk = value; }
        }
        private int _gagaBoyu;
        public int GagaBoyu
        {
            get { return _gagaBoyu; }
            set { _gagaBoyu = value; }
        }

        // Tüm kuşların yumurtladığı düşünelerek yumurtlama işlemini buraya ekliyoruz.
        public virtual string Yumurtla()
        {
            return "yavrum oldu :)";
        }
        public override string ToString()
        {
            return this.Renk + " " + this.GagaBoyu;
        }
    }
}
