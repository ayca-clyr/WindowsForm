using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CodeFirst.Entity
{
    class Region
    {
        public int RegionID { get; set; }
        public string RegionDescription { get; set; }

        public List<Territories> Territories { get; set; }

    }
}
