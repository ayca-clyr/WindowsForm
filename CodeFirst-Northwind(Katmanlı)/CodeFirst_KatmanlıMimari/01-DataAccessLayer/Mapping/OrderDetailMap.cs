using _01_Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DataAccessLayer.Mapping
{
    public class OrderDetailMap : EntityTypeConfiguration<OrderDetail>
    {
      public OrderDetailMap()
      {
          Property(od => od.Quantity)
              .IsOptional();

          HasRequired(od => od.Order)
              .WithMany()
              .HasForeignKey(od => od.OrderID);

          HasRequired(od => od.Product)
              .WithMany()
              .HasForeignKey(od => od.ProductID);

          HasKey(od => new { od.OrderID, od.ProductID });
         
      }
    }
}
