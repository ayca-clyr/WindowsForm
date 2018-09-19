using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7__Abstraction
{
    // sealed => miras vermek istemezsek böyle
    sealed class Limousine : Car
    {
        // Burada Start stop methodu ara katmanda ezildiği için virtual gibi davranır burada
        // istersek ezeriz limuzin de farklı bir ses çıkarır.
        public bool HasFridge { get; set; }
        
    }
}
