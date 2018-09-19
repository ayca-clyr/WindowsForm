using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace _02_CodeFirst.Entities.Mapping
{
    class CompanyMap : EntityTypeConfiguration<Company>
    {
        public CompanyMap()
        {
            
                ToTable("Sirket")    // Company class'ının sql de ismini Sirket olarak değiştirdik.
                .HasKey(x => x.ID);   // Id kolonunu PrimaryKey yaptık.
          
                Property(p => p.ID)     // ID property'sine nitelik ekliycem.
                .IsRequired()            // Boş geçilemez.
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity); // Otomatik artan olsun.

            
                Property(p => p.CompanyName)
                .IsRequired()
                .HasMaxLength(25)
                .HasColumnName("SirketAdi")
                .HasColumnType("varchar");


           
                Ignore(s => s.EmployeeCount); // NotMapped   // Sql'da gösterme ama entitiy olarak kullanacağım.
            
        }
    }
}
