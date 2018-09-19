using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12__Interface
{
    class Car :IVehicle,IMachine
    {

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public string Horn()
        {
          return"düüüt";
        }

        public string Accelerate()
        {
            throw new NotImplementedException();
        }

        public string Brake()
        {
            throw new NotImplementedException();
        }
        public string Make
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Model
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
