using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12__Interface
{
    class Truck : Car, IVehicle
    {
        // Car'dan kalıtım aldık
        // IVehicle metotlarını buraya çağırmamıza gerek yok diğer tarafta Car da bu metotlar var
        
         //Bunlara gerek yok 
        //public void Start()
        //{
        //    throw new NotImplementedException();
        //}

        //public void Stop()
        //{
        //    throw new NotImplementedException();
        //}

        //public string Horn()
        //{
        //    return "doooot";
        //}

        //public string Accelerate()
        //{
        //    throw new NotImplementedException();
        //}

        //public string Brake()
        //{
        //    throw new NotImplementedException();
        //}

    }
}
