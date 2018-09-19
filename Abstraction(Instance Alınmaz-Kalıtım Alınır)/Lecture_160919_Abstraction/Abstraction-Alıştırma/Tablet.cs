using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Alıştırma
{
    class Tablet : Computer
    {
        public bool CokYonlu { get; set; }
        public override int sesAc()
        {
            int ses = 0;
            return ses + 70;
        }
        public override int sesKapat()
        {
            int ses = 100;
            return ses - 60;
        }

        public override bool AcikKapali()
        {
            return true;
        }
    }
}
