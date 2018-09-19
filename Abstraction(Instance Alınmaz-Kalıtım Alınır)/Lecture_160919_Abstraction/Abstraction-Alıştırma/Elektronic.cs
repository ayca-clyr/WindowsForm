using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Alıştırma
{
    abstract class Elektronic
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Engine { get; set; } // Watt

        public int Inc { get; set; }
        public Color Color { get; set; }

        public abstract int sesAc();
        public abstract int sesKapat();
        public abstract bool AcikKapali();
        




    }
}
