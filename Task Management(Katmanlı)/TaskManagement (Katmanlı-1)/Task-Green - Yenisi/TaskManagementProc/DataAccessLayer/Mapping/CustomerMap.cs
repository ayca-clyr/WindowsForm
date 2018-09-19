using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
    class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            HasKey(c => c.CustomerID);

            Property(c => c.ContactName)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);

            Property(c=> c.CompanyName)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);

            Property(c => c.Address)
                .HasColumnType("varchar")
                .HasMaxLength(100);

            Property(c => c.Email)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);

            Property(c => c.Phone)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(25);


        }
    }
}
