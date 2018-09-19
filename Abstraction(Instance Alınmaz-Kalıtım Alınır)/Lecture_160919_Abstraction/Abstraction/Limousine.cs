using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    // Miras vermek istemezsek sealed deriz.
   sealed class Limousine : Car
    {
        public bool HasFridge { get; set; }    // Dolap vardır
         
    }
}
