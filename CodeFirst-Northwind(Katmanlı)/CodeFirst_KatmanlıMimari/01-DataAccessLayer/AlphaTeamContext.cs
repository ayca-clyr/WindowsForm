using _01_DataAccessLayer.Mapping;
using _01_Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DataAccessLayer
{
    public class AlphaTeamContext : DbContext
    {
        public AlphaTeamContext()
            : base("AlphaContext")
        {
        }
        internal DbSet<Category> Categories { get; set; }
        internal DbSet<Product> Products { get; set; }
        internal DbSet<Order> Orders { get; set; }
        internal DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new OrderDetailMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}

