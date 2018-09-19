using DataAccessLayer.Mapping;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   public class TaskManagemenetContext:DbContext
    {
        public TaskManagemenetContext():base("TaskManagemenetContext")
        {
            //Configuration.LazyLoadingEnabled = false;
        }
        internal DbSet<AccountType> AccountTypes { get; set; }
        internal DbSet<Customer> Customers { get; set; }

        internal DbSet<Employee> Employees { get; set; }
        internal DbSet<Project> Projects { get; set; }
        internal DbSet<Situaition> Situaitions { get; set; }
        internal DbSet<Taskk> Taskks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AccountTypeMap());
            modelBuilder.Configurations.Add(new CustomerMap());

            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new ProjectMap());
            modelBuilder.Configurations.Add(new SituaitionMap());
            modelBuilder.Configurations.Add(new TaskMap());

            base.OnModelCreating(modelBuilder);
        }



        
    }
}
