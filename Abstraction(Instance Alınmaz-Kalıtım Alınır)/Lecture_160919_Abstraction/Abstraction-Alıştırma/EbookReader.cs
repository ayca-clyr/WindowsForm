using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Alıştırma
{
    class EbookReader : Computer
    {
        public string EKitapBicimi { get; set; }
        public override int sesAc()
        {
            int ses = 0;
            return ses + 15;
        }
        public override int sesKapat()
        {
            int ses = 100;
            return ses - 90;
        }

        public override bool AcikKapali()
        {
            return true;
        }
    }
}
