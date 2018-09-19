using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8__Polymorphism
{
   sealed class Pawn : ChessPiece
    {
        public override string Move()
        {
            return "Bir kare düz ilerlerim, çaprazdaki taşı yiyebilirim.";
        }
        public override string ToString()
        {
            return "Piyon";
        }
    }
}
