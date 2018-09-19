using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
    class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            HasKey(e => e.EmployeeID);

            Property(e => e.FirstName)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);

            Property(e => e.LastName)
               .IsRequired()
               .HasColumnType("varchar")
               .HasMaxLength(50);

            Property(e => e.Phone)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(25);

            Property(e => e.Email)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(80);

            Property(e => e.Password)
               .IsRequired()
               .HasColumnType("varchar")
               .HasMaxLength(80);

            Ignore(e => e.FullName);

            HasRequired(e => e.AccountType)
                .WithMany()
                .HasForeignKey(e => e.AcoountTypeID);

        }
    }
}
