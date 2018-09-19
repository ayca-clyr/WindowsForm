using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Alıştırma
{
    class PlasmaTelevision : Television
    {
        public bool Internet { get; set; }
        public override int sesAc()
        {
            int ses = 0;
            return ses + 45;
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
