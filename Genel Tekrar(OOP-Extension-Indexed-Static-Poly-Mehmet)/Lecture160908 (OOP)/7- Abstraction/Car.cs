using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7__Abstraction
{
    class Car : Vehicle
    {
        public  override string Start()
        {
            // start metodu yazılmamıştır
            //throw new NotImplementedException();

            return "Vızır vızır";
        }

        public override string Stop()
        {
            return "Şıp";
        }

        public override string ToString()
        {
            return "ARABA";
        }

        public virtual void Accelerate()
        {

        }

    }
}
