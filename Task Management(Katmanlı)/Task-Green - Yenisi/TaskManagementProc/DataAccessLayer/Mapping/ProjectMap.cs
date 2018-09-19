using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
    class ProjectMap : EntityTypeConfiguration<Project>
    {
        public ProjectMap()
        {
            HasKey(c => c.ProjectID);

            //Property(c => c.RequestType)
            //    .IsOptional()
            //    .HasColumnType("varchar")
            //    .HasMaxLength(25);

            Property(c => c.Name)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(100);

            Property(c => c.ProjectStatus)
                .IsOptional()
                .HasColumnType("bit");

            Property(c => c.Description)
                .IsRequired()
                .HasColumnType("varchar(max)");

            Property(c => c.GenerateDate)
                .IsRequired()
                .HasColumnType("datetime");

            Property(c => c.DeadLine)
                .IsRequired()
                .HasColumnType("datetime");

            Property(c => c.StartDate)
                .IsOptional()
                .HasColumnType("datetime");

            Property(c => c.EndDate)
                .IsOptional()
                .HasColumnType("datetime");

            HasRequired(c => c.Employee)
                .WithMany()
                .HasForeignKey(c => c.EmployeeID)
                .WillCascadeOnDelete(false);

            HasRequired(c => c.Customer)
                .WithMany()
                .HasForeignKey(c => c.CustomerID);

            HasOptional(t => t.Situaition)
                .WithMany()
                .HasForeignKey(t => t.SituaitionID);


        }
    }
}
