using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind_Sepet_Uygulaması
{
    class Customers
    {
        public string CustomerID { get; set; }
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
            return FirstName;
        }

    }
    class OrderDetails
    {
        public int ProductID { get; set; }
        public int OrderID { get; set; }
        public int Quantity { get; set; }
        public int Discount { get; set; }
        public int UnitPrice { get; set; }

    }
    class Orders
    {
        public int OrderID { get; set; }
        public string ShipVia { get; set; }
        public override string ToString()
        {
            return ShipVia;
        }

    }

    class Products
    {
        public string ProductName { get; set; }
        public int ProductID { get; set; }
        public int UnitsInStock { get; set; }
        public override string ToString()
        {
            return ProductName;
        }
    }
}
