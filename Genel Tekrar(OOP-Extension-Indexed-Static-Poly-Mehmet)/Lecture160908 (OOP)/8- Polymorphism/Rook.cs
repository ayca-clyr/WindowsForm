using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8__Polymorphism
{
   sealed class Rook : ChessPiece
    {
        public override string Move()
        {
            return "Düşey ve yatay şekilde dümdüz ilerlerim, önüme çıkanı yerim.";
        }
        public override string ToString()
        {
            //return "Kale";
            // Direkt sınıf adını getirir.
            return this.GetType().Name;
        }
    }
}
