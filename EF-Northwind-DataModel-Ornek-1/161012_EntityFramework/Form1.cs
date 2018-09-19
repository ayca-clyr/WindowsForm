using _161012_EntityFramework.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _161012_EntityFramework
{
    //REgion kısa yok Ctrl +k +s
    public partial class Form1 : Form
    {
        //ORM (Object Relational Mapping) => İlişkisel ver tabanı ile nesne yönelimli programlama arasındaki ilişkiyi kuran ve ilişkisel veri tabanındaki bilgileri yönetmek için nesneye dayalı olarak modellemeye imkan tanıyan bir tekniktir.
        //.Net de ORM framework leri : Entity Framework, Nhibernate, DotNorm, FastObjects.Net...

        //Entity Framework => Temel amacı uygulama geliştiricilerinin veritabanı işlemleri ile çok uğraşmadan direk odaklanmasını sağlamaktır.,

        //3 yaklaşımı bulunmaktadır.
        //1. DatabaseFirst => SQL imizde hazır, var olan bir database'den uygulamamızda yansıma almamızı sağlar.Database'in içerisinde var olan tablolar class olarak aktarılır.
        //2. ModelFirst => Database'im yok.Uygulama tarafında database'imi diyagram kısmından oluşturuyorum. En az kullanılan yaklaşımdır.
        //3. CodeFirst => Yansıma yok.Yansımamı uygulama tarafında kendim yazıyorum.Tablolarımi class şeklinde, alan isimlerini property olarak belirtiyorum. Program çalıştıgında eğer "otomatik migration" da ise sql tarafında database'i yazdığım class'lara göre kendi oluşturuyor.En büyük avantajı farklı projelerde aynı database yapısının kullanılabilmesi.En iyi performanslı yaklaşımdır.Fakat tablo sayısı arttıgında oluşturma sırasında sıkıntı çıkartabilir.

        public Form1()
        {
            InitializeComponent();
        }
        //Entity FrameWork Proje üzerinde sağ tıkla 
        //Manage Nuget seç 
        //yada Tools tan Nuget Package
        //Arama yerine Entity FrameWork yaz ve sol üstten Online içine gir
        //Microsoft and .Net tıkla 
        //Açılan pencereden Entity FrameWork İnstall et.
        //Projenin referance kısmında EntityFramework ve EntityFramework.SqlServer eklenecektir.

        private void Form1_Load(object sender, EventArgs e)
        {
            NorthwindEntities dbContext = new NorthwindEntities();
            var query = (
                from c in dbContext.Categories
                select c
                );

            //dataGridView1.DataSource = query.ToList();
            //2.Yöntem
            //dataGridView1.DataSource = dbContext.Categories.ToList();

            #region   CategoryName,ProductName
            var query2 = (
                    from c in dbContext.Categories
                    join p in dbContext.Products on c.CategoryID equals p.CategoryID
                    select new
                    {
                        c.CategoryName,
                        p.ProductName
                    });

            #endregion

            #region kategoride  kaç farklı  ürünüm var
            var query6 = (
           from c in dbContext.Categories
           join p in dbContext.Products on c.CategoryID equals p.CategoryID
           group c by c.CategoryName into g
           select new
           {
               Category = g.Key,
               Count = g.Count()
           }

           ).Distinct();


            #endregion

            #region Hangi Kategoride kaç adet ürünüm var
            var query3 = (
         from c in dbContext.Categories
         join p in dbContext.Products on c.CategoryID equals p.CategoryID
         group p by c.CategoryName into g
         orderby g.Key descending //sıralama
         select new
         {
             Category = g.Key, //Key dediğimiz = c.CategoriesName yani group by dan snra yazdıgımız
             SumStock = g.Sum(x => x.UnitsInStock)
         });


            #endregion

            #region Fiyatı 20 ile 50 arasında olan ürünlerin,UrunID, UrunAdi, Fiyati, StokMiktari ve KategoriAdi ni Lisyeleyiniz.

            var query5 = (
from c in dbContext.Categories
join p in dbContext.Products on c.CategoryID equals p.CategoryID
where p.UnitPrice >= 20 && p.UnitPrice <= 50
select new
{
    //Kolon adı verdik
    Id = p.ProductID,
    Name = p.ProductName,
    Price = p.UnitPrice,
    Stock = p.UnitsInStock,
    Category = c.CategoryName
});

            #endregion





            #region  1997 yılı 7 ayda satılan ürünler

      var query4 = (
      from od in dbContext.Order_Details
      join p in dbContext.Products on od.ProductID equals p.ProductID
      join o in dbContext.Orders on od.OrderID equals o.OrderID
      where o.ShippedDate.Value.Year == 1997 && o.ShippedDate.Value.Month == 7
      orderby p.ProductName ascending //İsme göre sıralama
      group p by p.ProductName into g

      select new
      { 
    Name = g.Key,
    Sum = g.Count()


      }

).Distinct();
            #endregion


      dataGridView1.DataSource = query4.ToList();
           






        }
    }
}
