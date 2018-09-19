using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructWinForms
{
    // Çok net işlemler için struct kullan.
    // Kodun çok olmasın. 
    // Class gibi ama nesnenin değiştirilmemesi durumudur.Pi sayısı, hacim vs gibi.. 

                /* Yapabiliriz..
                    Button button = new Button();
                    Volume volume = new Volume();
                    button.Left = 30;
                    volume.Depth = 30;
                */

                /* Yapamayız     
                    Button button = null;
                    Volume volume = null; 
                 */



    struct Volume
    {
        // Struct'da başlangıç değeride atamayız.

        public int Height ;
        public int Width;
        public int Depth ;

        public bool IsCube()
        {
            return Width != 0 && Width == Height && Height == Depth;
        }
    }
}
