using _01_Entity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Entity
{
    public partial class Form1 : Form
    {

        // "Class"'a sağ tıkla "Manage Nuget Packages" seç ve "Online" kısmına "Entity Framework" yaz. "Microsof NET 4.5" de ve mor olanı "Install" et sözleşmeyi kabul et.

        // ORM (Object Relational Mapping) => İlişkisel veri tabanı ile nesne yönelimli programlama arasındaki ilişkiyi kuran ve ilişkisel veri tabanındaki bilgileri yönetmek için nesneye dayalı olarak modellemeye imkan tanıyan bir tekniktir.
        // .Net'de ORM frameworkler : Entity Framework, Nhibernate,DotNorm,FastObjects.NET.. 
        // Entity Framework = Temel amacı geliştiricilerinin veritabanı işlemleri ile çok uğraşmadan direk uygulamaya odaklanmasını sağlamaktır.  
        // * 3 Yaklaşımı bulunmaktır.
        // 1 - DatabaseFirst => SQL'imizde hazır, var olan bir ddatabase'den uygulamamıza yansıma almamızı sağlar.Database'in içerisinde var olan tablolar class olarak aktarılır.
        // 2 - ModelFirst => Database'im yok. Uygulama tarafında database'imi diyagran kısmında oluşturuyorum. En az kullanılan yaklaşımdır.
        // 3 - CodeFirst => Yansıma yok. Yansımamı uygulama tarafında kendim yazıyorum.Tablolarımı class şeklinde, alan isimlerini property olarak belirtiyorum. Program çalıştığında eğer otomatik mifration da ise sql tarafında database'i yazdığım class'lara göre kendi oluşturuyor. En büyük avantajı farklı projelerde aynı databse yapısının kullanılabilmesi. En iyi performanslı yaklaşımdır.Fakat tablo sayısı arttığında oluşturma sırasında sıkıntı çıkartabilir.
         
           
            
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
            // by 'dan sonraki yazılan Name = g.Key KEY satırı yani
            // by'dan öncekide neyde işlem yapıcaksak o query3 p, c

            NorthwindEntities dbContext = new NorthwindEntities();
            var query1= (
                from c in dbContext.Categories
                select c
                );



            // 2.Yöntem             
           // dataGridView1.DataSource = dbContext.Categories.ToList();
          
            
            var query2 = (
                from c in dbContext.Categories
                join p in dbContext.Products on c.CategoryID equals p.CategoryID
                select new
                {
                    c.CategoryName,
                    p.ProductName
                }
                ).ToList();


            #region Hangi kategoride kaç adet ürünüm var

            var query3 = (
          from c in dbContext.Categories
          join p in dbContext.Products on c.CategoryID equals p.CategoryID
          group p by c.CategoryName into g
          select new
          {

              CategoriAdi = g.Key,
              Toplam = g.Sum(x => x.UnitsInStock)
          }
          ).ToList(); 
            #endregion


            #region Hangi katagoride kaç farklı ürün var

            var query4 = (
                from c in dbContext.Categories
                join p in dbContext.Products on c.CategoryID equals p.CategoryID
                group c by c.CategoryName into g
                orderby g.Key descending    // Sıralama
                select new
                {
                    CategoriAdi = g.Key,
                    ÜrünSayısı = g.Count()
                }
                ).ToList();
            
            #endregion

            #region Fiyatı 20 ile 50 arasında olan ürünlerin UrunID, UrunAdi, Fiyati, StokMiktari ve KategoriAdi'ni listeleyiniz.

            var query5 = (
                from p in dbContext.Products
                join c in dbContext.Categories on p.CategoryID equals c.CategoryID
                where p.UnitPrice < 50 && p.UnitPrice > 20
                select new
                {
                    p.ProductID,
                    p.ProductName,
                    p.UnitPrice,
                    p.UnitsInStock,
                    c.CategoryName
                }).ToList();
            
            #endregion

            #region 1997 yılında satılan ürünler 1 Version

            DateTime baslagic = new DateTime(1997, 1, 1);
            DateTime bitis = new DateTime(1997, 12, 31);
            var query6 = (
                from p in dbContext.Products
                join od in dbContext.Order_Details on p.ProductID equals od.ProductID
                join o in dbContext.Orders on od.OrderID equals o.OrderID
                where o.ShippedDate > baslagic && o.ShippedDate < bitis

                select new
                {
                    p.ProductName,
                    o.ShippedDate
                }

                ).ToList(); 
            #endregion

            #region 1997 yılında satılan ürünler 2 Version
         
            var query7 = (
                from p in dbContext.Products
                join od in dbContext.Order_Details on p.ProductID equals od.ProductID
                join o in dbContext.Orders on od.OrderID equals o.OrderID
                where o.ShippedDate.Value.Year == 1997
                orderby p.ProductName ascending
                select new
                {
                    p.ProductName,
              
                }

                ).ToList();
            #endregion

            #region 1997 Temmuz ayında satılan ürünler 2 Version

            var query8 = (
                from p in dbContext.Products
                join od in dbContext.Order_Details on p.ProductID equals od.ProductID
                join o in dbContext.Orders on od.OrderID equals o.OrderID
                where o.ShippedDate.Value.Year == 1997 && o.ShippedDate.Value.Month == 7
                orderby p.ProductName ascending
                group p by p.ProductName into g 
                select new
                {
                   ProductName =  g.Key,
                   Toplam = g.Count()

                }

                ).ToList();
            #endregion



            dataGridView1.DataSource = query8;





        
        }
    }
}
