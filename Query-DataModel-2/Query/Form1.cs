using Query.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Query
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NorthwindEntities db = new NorthwindEntities();
            //1. CategoryName'i 'Condiment' olan ürünlerin stok bilgisini ve ne zaman sipariş edildiğini listeleyiniz.
            var query1 = (
                from c in db.Categories
                join p in db.Products on c.CategoryID equals p.CategoryID
                join od in db.Order_Details on p.ProductID equals od.ProductID
                join o in db.Orders on od.OrderID equals o.OrderID
                where c.CategoryName == "Condiments"
                select new
                {
                    p.UnitsInStock,
                    o.ShippedDate
                }

                );

            //2."Chai" ve "Tofu" ürünlerinin 1997-07-01 tarihinden önceki siparişlerinin ürün adını,ürün sayısını ve gönderildiği şehri listeleyen sorguyu yazınız.
            DateTime tarih = new DateTime(1997, 07, 01);
            var query2 = (
          from p in db.Products
          join od in db.Order_Details on p.ProductID equals od.ProductID
          join o in db.Orders on od.OrderID equals o.OrderID
          where (p.ProductName == "Chai" || p.ProductName == "Tofu") && o.ShippedDate < tarih
          select new
          {
              Name = p.ProductName,
              Sum = p.UnitsInStock,
              City = o.ShipCity
          }

          );

            //3.Territory ID si 10000 ile 32500 arasında olan satıcıların ürün gönderdikleri müşterilerin telefon numaralarını listeleyin?
            var query3 = (
                from od in db.Order_Details
                join o in db.Orders on od.OrderID equals o.OrderID
                join c in db.Customers on o.CustomerID equals c.CustomerID
                join emp in db.Employees on o.EmployeeID equals emp.EmployeeID
                from et in emp.Territories
                join t in db.Territories on et.TerritoryID equals t.TerritoryID
                join r in db.Regions on t.RegionID equals r.RegionID
                select new
                {
                   c.ContactName,
                   c.Phone
                }

      ).Distinct();

            dataGridView1.DataSource = query3.ToList();
        }
    }
}
