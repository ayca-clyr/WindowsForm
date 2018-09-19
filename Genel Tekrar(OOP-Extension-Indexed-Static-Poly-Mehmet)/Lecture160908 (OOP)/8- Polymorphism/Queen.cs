using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8__Polymorphism
{
    class Queen : ChessPiece
    {
        public override string Move()
        {
            return "Aslında ben kraldan daha yetenekliyim, bir tek at olamıyorum.";
        }
        public override string ToString()
        {
            return "Vezir";
        }
    }
}
