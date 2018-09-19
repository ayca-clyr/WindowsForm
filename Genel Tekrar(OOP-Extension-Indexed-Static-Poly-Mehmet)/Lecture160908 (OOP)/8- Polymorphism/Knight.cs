using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8__Polymorphism
{
   sealed class Knight : ChessPiece
    {

        public override string Move()
        {
            return "L şeklinde ilerlerim, engel tanımam.";
        }

        public override string ToString()
        {
            return "At";
        }
    }
}
