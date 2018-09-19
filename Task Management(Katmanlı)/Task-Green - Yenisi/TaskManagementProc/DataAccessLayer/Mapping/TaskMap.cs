using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
    class TaskMap : EntityTypeConfiguration<Taskk>
    {
        public TaskMap()
        {
            HasKey(t => t.TaskID);


            Property(c => c.RequestType)
                .IsOptional()
                .HasColumnType("varchar")
                .HasMaxLength(25);

            Property(t => t.Name)
                .IsRequired()
                .HasColumnType("varchar(max)");

            Property(t => t.Description)
                .IsRequired()
                .HasColumnType("varchar(max)");

            HasRequired(t => t.Project)
                .WithMany()
                .HasForeignKey(t => t.ProjectID);

            HasRequired(t => t.Situaition)
                .WithMany()
                .HasForeignKey(t => t.SituaitionID);

            Property(t => t.StartDate)
                .IsRequired()
                .HasColumnType("datetime");

            Property(t => t.EndDate)
                .IsRequired()
                .HasColumnType("datetime");


            HasOptional(t => t.Employee)
                .WithMany()
                .HasForeignKey(t => t.EmployeeID)
                .WillCascadeOnDelete(false);


            HasRequired(t => t.Manager)
                .WithMany()
                .HasForeignKey(t => t.ManagerID)
                .WillCascadeOnDelete(false);

            Property(t => t.RequestTypeDescription)
                .IsOptional()
                .HasColumnType("varchar")
                .HasMaxLength(500);
                
            

        }
    }
}
