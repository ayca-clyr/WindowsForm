using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CodeFirst.Entities.Mapping
{
    class EmployeeMap : EntityTypeConfiguration<Employee>
    {

        public EmployeeMap()
        {
            ToTable("Çalışanlar")
                .HasKey(x => x.ID);

            Property(p => p.ID)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.FirstName)
                .IsRequired()
                .HasMaxLength(25)
                .HasColumnName("Ad")
                .HasColumnType("varchar");

            Property(p => p.LastName)
           .IsRequired()
           .HasMaxLength(25)
           .HasColumnName("Soyad")
           .HasColumnType("varchar");


            Property(p => p.Address)
          .HasMaxLength(50)
          .HasColumnName("Adres")
          .HasColumnType("varchar");

            Property(p => p.Phone)
          .HasMaxLength(50)
          .HasColumnName("Telefon")
          .HasColumnType("varchar");
           
            Ignore(s => s.FullName);
        }
    }
}
