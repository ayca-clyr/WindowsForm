using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuş
{
    class Karga : Kuş,IUcabilir
    {

        public void Uc()
        {
            System.Windows.Forms.MessageBox.Show("Çok dertliyim uçabiliyorum ama yüzemiyorum"); 
        }

        public void Hizlan()
        {
            System.Windows.Forms.MessageBox.Show("Ben kinci bir hayvanım :D, birini gözüme kestirdim"); 
        }

        public void Dur()
        {
            System.Windows.Forms.MessageBox.Show("Yuppi! Sonunda dinlenecebileceğimmm"); 
        }
    }
}
