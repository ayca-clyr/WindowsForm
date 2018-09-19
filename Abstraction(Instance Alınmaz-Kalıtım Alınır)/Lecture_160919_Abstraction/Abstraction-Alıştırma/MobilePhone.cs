using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Alıştırma
{
    class MobilePhone : Phone
    {
        public int Bellek { get; set; }
        public string IsletimSistemi { get; set; }
        public override int sesAc()
        {
            int ses = 0;
            return ses + 100;
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
