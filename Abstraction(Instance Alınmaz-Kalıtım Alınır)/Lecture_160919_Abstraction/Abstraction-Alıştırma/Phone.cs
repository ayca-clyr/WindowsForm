using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Alıştırma
{
    class Phone : Elektronic
    {
        public Tip TusTipi { get; set; }
        public override int sesAc()
        {
            int ses = 0;
            return ses + 100;
        }
        public override int sesKapat()
        {
            int ses = 100;
            return ses - 100;
        }

        public override bool AcikKapali()
        {
            return true;
        }
    }
}
