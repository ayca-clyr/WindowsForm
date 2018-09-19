using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Traniee : Person 
    {
        //propfull
        private string _traneeNumber;

        public string TraneeNumber
        {
            get { return _traneeNumber; }
            set { _traneeNumber = value; }
        }
        


    }
}
