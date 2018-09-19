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


            #region 1- CategoryName'i 'Condiment' olan ürünlerin stok bilgisini ve ne zaman sipariş edildiğini listeleyiniz.
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

            #endregion

            #region 2- "Chai" ve "Tofu" ürünlerinin 1997-07-01 tarihinden önceki siparişlerinin ürün adını,ürün sayısını ve gönderildiği şehri listeleyen sorguyu yazınız.
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
            #endregion
            #region 3- Territory ID si 10000 ile 32500 arasında olan satıcıların ürün gönderdikleri müşterilerin telefon numaralarını listeleyin?

            var query3 = (
                    from od in db.Order_Details
                    join o in db.Orders on od.OrderID equals o.OrderID
                    join c in db.Customers on o.CustomerID equals c.CustomerID
                    join emp in db.Employees on o.EmployeeID equals emp.EmployeeID
                    from et in emp.Territories
                    join t in db.Territories on et.TerritoryID equals t.TerritoryID
                    join r in db.Region on t.RegionID equals r.RegionID
                    select new
                    {
                        c.ContactName,
                        c.Phone
                    }

          ).Distinct();

            #endregion

#region  4- Shippers 'ı United Package olan ürün detaylarını ve tedarikçilerini listeleyiniz?

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

            #endregion

            #region 5 - Venezuelaya gönderilecek olan siparişlerin hangi çalışanım tarafından sipariş alındığını bu çalışanımın kime rapor gönderdiğini bu siparişin hangi kargo ve hangi şirkete gönderileceğini, son olarakta bu kargo şirketinin telefonunu istemekteyiz.

            var query5 = (
                from o in db.Orders
                join em in db.Employees on o.EmployeeID equals em.EmployeeID
                join em1 in db.Employees on em.EmployeeID equals em1.EmployeeID
                join shi in db.Shippers on o.ShipVia equals shi.ShipperID
                where o.ShipCountry == "Venezuela"
                select new
                {
                    em.FirstName,
                    em.LastName,
                    em1.ReportsTo,
                    shi.CompanyName,
                    o.ShipName,
                    shi.Phone

                }
                );

            #endregion
            #region  6 - 1997-05-27 ile 1998-08-03 tarihleri arasinda janet'in ALFKI ID'li sirkete gonderdigi urunlerin stok durumunu gosteriniz.
            DateTime baslangic = new DateTime(1997, 05, 27);
            DateTime bitis = new DateTime(1998, 08, 03);
            var query6 = (
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
            #endregion

            // 7- Satış yapan çalışanın her sipariş için ürün bazlı olarak kaç adet sattıklarını büyükten küçüğe sıralayarak firma isimleri ve çalışan isimleri ile listeleyiniz.İndirimde olan ürünlere indirimde yazınız değil ise normal yazınız.

            var query7 = (
                from cus in db.Customers
                join o in db.Orders on cus.CustomerID equals o.CustomerID
                join od in db.Order_Details on o.OrderID equals od.OrderID
                join p in db.Products on od.ProductID equals p.ProductID

                select p
                );
#region 8 - Aynı kategoride sipariş veren müşterileri sıralayınız.

            var query8 = (

                from c in db.Categories
                join p in db.Products on c.CategoryID equals p.CategoryID
                join od in db.Order_Details on p.ProductID equals od.ProductID
                join o in db.Orders on od.OrderID equals o.OrderID
                join cus in db.Customers on o.CustomerID equals cus.CustomerID
                select new
                {
                    cus.CompanyName,
                    c.CategoryName
                }


               );

            #endregion

            #region 9 - Kategori adı 'dairy products' olan, andrew adlı çalışanın satmış olduğu ve sipariş tarihi 1997 - 06 - 19'den sonra olan aynı zamanda stokta bulunan ürünleri gösteren tabloyu getiriniz.
            DateTime tarih2 = new DateTime(1997, 06, 19);

            var query9 = (
               from c in db.Categories
               join p in db.Products on c.CategoryID equals p.CategoryID
               join od in db.Order_Details on p.ProductID equals od.ProductID
               join o in db.Orders on od.OrderID equals o.OrderID
               join emp in db.Employees on o.EmployeeID equals emp.EmployeeID
               where c.CategoryName == "dairy products" && emp.FirstName == "Andrew" && p.UnitsInStock > 0 && o.ShippedDate > tarih2
               select new
               {
                   p.ProductName
               });
            #endregion
            #region 10 - Ürünler tablosundaki stok sayısının 50 den az olup bu ürünlerin hangi tarihte kaç adet gönderildiğini getiren sorguyu yazınız.
            var query10 = (
                   from p in db.Products
                   join od in db.Order_Details on p.ProductID equals od.ProductID
                   join o in db.Orders on od.OrderID equals o.OrderID
                   where p.UnitsInStock < 50
                   group o.RequiredDate by p.ProductName into g
                   select new
                   {
                       Ürün = g.Key,
                       ÜrünSayısı = g.Count(),
                       Orders = g.FirstOrDefault()

                   }

                   );
            #endregion
          #region 11 - 1995 yılından bugüne kadar verilen siparişlerden USA'e giden ürünlerin isimlerini ve tedarik eden firmaların ID lerini raporlayan sorguyu yazınız.
            var query11 = (
                   from o in db.Orders
                   join od in db.Order_Details on o.OrderID equals od.OrderID
                   join p in db.Products on od.ProductID equals p.ProductID
                   join sup in db.Suppliers on p.SupplierID equals sup.SupplierID

                   where o.ShippedDate.Value.Year > 1995 && o.ShippedDate < DateTime.Now && o.ShipCountry == "USA"
                   select new
                   {
                       p.ProductName,
                       sup.SupplierID
                   }

                   );
            #endregion
           #region 12 - Geç teslim edilen ürünlerin kargo şirketi isimleri , gidecekleri şehir ve kategori isimleri ve fiyatları ve ürünün stok miktarı ve satılan adet miktarını listeleyiniz.
            var query12 = (
                 from p in db.Products
                 join od in db.Order_Details on p.ProductID equals od.ProductID
                 join o in db.Orders on od.OrderID equals o.OrderID
                 join shi in db.Shippers on o.ShipVia equals shi.ShipperID
                 join c in db.Categories on p.CategoryID equals c.CategoryID
                 where o.OrderDate < o.RequiredDate
                 select new
                 {
                     shi.CompanyName,
                     o.ShipCity,
                     c.CategoryName,
                     p.UnitPrice,
                     p.UnitsInStock,
                     od.Quantity


                 }
                  );
            #endregion
           // 13 - Tüm cirom ne kadar ? (Order Details.Quantity * Products.UnitPrice)

            var query13 = (
                from od in db.Order_Details
                join p in db.Products on od.ProductID equals p.ProductID
                group new { od, p } by od.UnitPrice into g
                select new
                {
                    Ürün = g.Key,
                    // Ciro = g.Sum(x => x.Quantity , x => x.UnitPrice )
                }
                );

#region 14 - En pahalı ürünüm hangisi?

            var query14 = (
                from p in db.Products
                orderby p.UnitPrice descending
                select new
                {
                    p.ProductName,
                    p.UnitPrice
                }
                ).Skip(1).Take(1);
            #endregion

            dGVList.DataSource = query14.ToList();
        }
    }
}
