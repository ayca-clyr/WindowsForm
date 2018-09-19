using _02_CodeFirst.Entities.Mapping;
using _02_CodeFirst.Migrations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CodeFirst.Entities
{
    class CompanyContext : DbContext
    {
        public CompanyContext()
            : base("name=Entities")
        {

        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }

        // Fluent Mapping : 

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            #region Mapping
            //modelBuilder.Entity<Company>()
            //    .ToTable("Sirket")    // Company class'ının sql de ismini Sirket olarak değiştirdik.
            //    .HasKey(x => x.ID);   // Id kolonunu PrimaryKey yaptık.
            //modelBuilder.Entity<Company>()
            //    .Property(p => p.ID)     // ID property'sine nitelik ekliycem.
            //    .IsRequired()            // Boş geçilemez.
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity); // Otomatik artan olsun.

            //modelBuilder.Entity<Company>()
            //    .Property(p => p.CompanyName)
            //    .IsRequired()
            //    .HasMaxLength(25)
            //    .HasColumnName("SirketAdi")
            //    .HasColumnType("varchar");


            //modelBuilder.Entity<Company>()
            //    .Ignore(s => s.EmployeeCount); // NotMapped   // Sql'da gösterme ama entitiy olarak kullanacağım.

                //    modelBuilder.Entity<Employee>()
                //        .ToTable("Çalışanlar")
                //        .HasKey(x => x.ID);

                //    modelBuilder.Entity<Employee>()
                //        .Property(p => p.ID)
                //        .IsRequired()
                //        .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

                //    modelBuilder.Entity<Employee>()
                //        .Property(p => p.FirstName)
                //        .IsRequired()
                //        .HasMaxLength(25)
                //        .HasColumnName("Ad")
                //        .HasColumnType("varchar");

                //modelBuilder.Entity<Employee>()
                //        .Property(p => p.FirstName)
                //        .IsRequired()
                //        .HasMaxLength(25)
                //        .HasColumnName("Soyad")
                //        .HasColumnType("varchar");

                //modelBuilder.Entity<Employee>()
                //        .Property(p => p.Address)
                //        .HasMaxLength(50)
                //        .HasColumnName("Adres")
                //        .HasColumnType("varchar");

                //modelBuilder.Entity<Employee>()
                //        .Property(p => p.Phone)
                //        .HasMaxLength(50)
                //        .HasColumnName("Telefon")
                //        .HasColumnType("varchar");

                //modelBuilder.Entity<Employee>()
                //        .Ignore(s => s.FullName);




            #endregion

            // Entities'de klasör oluşturduk Mapping diye.
            // Mappingde class açtık CompanyMap diye. 
            // ve bu sınıfa kütüphane olarak "using System.Data.Entity.ModelConfiguration;" ekledik.
            // CompanyMap'e EntityTypeConfiguration<Company> kalıtım olarak bunu alıyoruz.
            // .ctor açıyoruz ve içine . ile yazdıklarımızı kısadan yazıyoruz.

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();  // Tekil-çoğul eklerini kaldırmak için kullanılır.

            modelBuilder.Configurations.Add(new CompanyMap()); // CompanyMap sınıfını bağlamak için. Aktif etmek için.
            modelBuilder.Configurations.Add(new EmployeeMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
