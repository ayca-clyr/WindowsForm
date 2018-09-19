using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CodeFirst.Entity
{
    class Territories
    {
        public int TerritoriesID { get; set; }
        public string TerritoriesDescription { get; set; }
        public int RegionID { get; set; }
       
        public List<Employee> Employees { get; set; }
    }
}
