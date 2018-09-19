using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuş
{
    class Marti : Kuş,IUcabilir,IYuzebilir
    {
        public void Uc()
        {
            throw new NotImplementedException();
        }

        public void Hizlan()
        {
            throw new NotImplementedException();
        }

        public void Dur()
        {
            throw new NotImplementedException();
        }

        public string Yuz()
        {
            return "Hem uçabiliyorum hem yüzebilirim";
        }
    }
}
