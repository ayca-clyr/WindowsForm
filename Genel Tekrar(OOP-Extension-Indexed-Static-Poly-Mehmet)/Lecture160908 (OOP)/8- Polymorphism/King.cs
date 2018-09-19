using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8__Polymorphism
{
    class King : ChessPiece
    {
        public override string Move()
        {
            return "Her yöne tek adım gidebiliyorum";
        }

        public override string ToString()
        {
            return "Kral";
        }
    }
}
