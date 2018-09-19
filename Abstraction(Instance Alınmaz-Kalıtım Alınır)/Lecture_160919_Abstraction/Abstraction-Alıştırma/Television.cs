using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Alıştırma
{
    class Television : Elektronic
    {
        
       
        public override int sesAc()
        {
            int ses = 0;
            return ses + 25;
        }
        public override int sesKapat()
        {
            int ses = 100;
            return ses - 76;
        }

        public override bool AcikKapali()
        {
            return true;
        }
    }
}
