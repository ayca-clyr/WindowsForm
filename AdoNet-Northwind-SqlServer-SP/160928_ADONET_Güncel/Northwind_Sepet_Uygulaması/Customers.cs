﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind_Sepet_Uygulaması
{
    class Customers
    {
        public int CustomerID { get; set; }
        public string CompanyName { get; set; }
        public override string ToString()
        {
            return CompanyName;
        }
    }
    class Employees
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

    }
}
