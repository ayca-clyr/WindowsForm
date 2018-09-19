using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3__StructInWinForms
{
    //SINIFLAR REFERANS TİPLİDİR.
    // Değer tiplidir.
    struct Volume
    {
        // Structlarda net ve bundan fazla kod olmasın

        // Başlangıç değerleri veremeyiz.
        public int Height;
        public int Width;
        public int Depth;

        public bool IsCube()
        {
            return Width != 0 && Width == Height && Height == Depth; 
        }

    }
}
