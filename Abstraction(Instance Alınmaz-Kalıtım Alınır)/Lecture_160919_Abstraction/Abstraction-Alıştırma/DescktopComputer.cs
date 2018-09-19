using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Alıştırma
{
    class DescktopComputer : Computer
    {
        public string KasaModeli { get; set; }
        public string MonitorModeli { get; set; }
        public override int sesAc()
        {
            int ses = 0;
            return ses + 50;
        }
        public override int sesKapat()
        {
            int ses = 100;
            return ses - 80;
        }

        public override bool AcikKapali()
        {
            return true;
        }

    }
}
