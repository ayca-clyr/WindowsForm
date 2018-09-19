using Queries.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queries
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            NorthwindEntities1 db = new NorthwindEntities1();

            // 1- CategoryName'i 'Condiment' olan ürünlerin stok bilgisini ve ne zaman sipariş edildiğini listeleyiniz.
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

            // 2- "Chai" ve "Tofu" ürünlerinin 1997-07-01 tarihinden önceki siparişlerinin ürün adını,ürün sayısını ve gönderildiği şehri listeleyen sorguyu yazınız.
            DateTime tarih = new DateTime(1997, 07, 01);
            var query2 = (
                from p in db.Products
                join od in db.Order_Details on p.ProductID equals od.ProductID
                join o in db.Orders on od.OrderID equals o.OrderID
                where (p.ProductName == "Chai" || p.ProductName == "Tofu") && o.ShippedDate < tarih
  
                select new
                {
                    p.ProductName,
                    p.UnitsInStock,
                    o.ShipCity,
                }
                );

            // 3- Territory ID si 10000 ile 32500 arasında olan satıcıların ürün gönderdikleri müşterilerin telefon numaralarını listeleyin?

            //var query3 = (
            //    from t in db.Territories
            //    join et in db.E
               
            //    );


            // 4- Shippers 'ı United Package olan ürün detaylarını ve tedarikçilerini listeleyiniz?

            var query4 = (
                from sh in db.Shippers
                join o in db.Orders on sh.ShipperID equals o.ShipVia
                join od in db.Order_Details on o.OrderID equals od.OrderID
                join p in db.Products on od.ProductID equals p.ProductID
                join sup in db.Suppliers on p.SupplierID equals sup.SupplierID
                where sh.CompanyName == "United Package"
                select new
                {
                    sup.CompanyName,
                    sup.ContactName,
                    p.ProductName,
                    p.UnitsInStock,
                    p.UnitPrice,
                }
                ).Distinct();

            // 5 - Venezuelaya gönderilecek olan siparişlerin hangi çalışanım tarafından sipariş alındığını bu çalışanımın kime rapor gönderdiğini bu siparişin hangi kargo ve hangi şirkete gönderileceğini, son olarakta bu kargo şirketinin telefonunu istemekteyiz.

            var query5 = (
                from o in db.Orders
                join em in db.Employees on o.EmployeeID equals em.EmployeeID
                join em1 in db.Employees on em.EmployeeID equals em1.EmployeeID
                join shi in db.Shippers on o.ShipVia equals shi.ShipperID
                where o.ShipCountry == "Venezuela"
                select new
                {
                    em.FirstName ,
                   em.LastName,               
                    em1.ReportsTo,
                    shi.CompanyName,
                   o.ShipName,
                    shi.Phone

                }
                );

            // 6 - 1997-05-27 ile 1998-08-03 tarihleri arasinda janet'in ALFKI ID'li sirkete gonderdigi urunlerin stok durumunu gosteriniz.

            DateTime baslangic = new DateTime(1997,05,27);
            DateTime bitis = new DateTime(1998,08,03);
            var query6 =(
                from emp in db.Employees
                join o in db.Orders on emp.EmployeeID equals o.OrderID
                join od in db.Order_Details on o.OrderID equals od.OrderID
                join p in db.Products on od.ProductID equals p.ProductID
                where emp.FirstName == "Janet" && o.CustomerID == "ALFKI" && o.ShippedDate < bitis && o.ShippedDate > baslangic
                select new
                {
                    p.UnitsInStock
                }
                );


            dGVList.DataSource = query6.ToList();
        }
    }
}
