using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuş
{
    class Daire
    {
        public const double pi = 3.14;
        private int _cap;
        public int Cap
        {
            get { return _cap; }
            set { _cap = value; }
        }

        public double AlanHesapla()
        {
            return pi * (Cap / 2) * (Cap / 2);
        }
    }
}
