using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2_Hocanın_Çözdüğü
{
    class Driver
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public LicenseType License { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, {1} - {2}", FirstName, LastName, License);
        }
    }
}
