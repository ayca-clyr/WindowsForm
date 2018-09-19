﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CodeFirst.Entity
{
    class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }

        public int CategoryID { get; set; }
        //[ForeignKey("CategoryID")]  Referans ver ama bu işlem gerçekleşmiyor.

        // public List<Category> Categories { get; set; }
        public List<Order> Orders { get; set; }

    }
}
