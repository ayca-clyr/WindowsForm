using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Alıştırma
{
    class Computer : Elektronic
    {
        public int Ram { get; set; }
        public string Islemci { get; set; }
   
        public int EkranCozunurlugu { get; set; }

        public override int sesAc()
        {
            int ses = 0;
            return ses + 30;
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
