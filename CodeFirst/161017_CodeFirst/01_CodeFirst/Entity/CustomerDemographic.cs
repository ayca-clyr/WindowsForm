using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CodeFirst.Entity
{
    class CustomerDemographic
    {
        public string CustomerDemographicID {get;set;}
        public string CustomerDesc { get; set; }
        public List<Customer> CustomerCustomerDemo { get; set; }
    }
}
