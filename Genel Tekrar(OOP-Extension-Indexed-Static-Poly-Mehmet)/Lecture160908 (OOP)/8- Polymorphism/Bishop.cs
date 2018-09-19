using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8__Polymorphism
{
   sealed class Bishop : ChessPiece
    {
        public override string Move()
        {
            return "Çapraz ilerlerim, yönümdeki taşı yiyebilirim.";
        }

        public override string ToString()
        {
            return "Fil";
        }
    }
}
