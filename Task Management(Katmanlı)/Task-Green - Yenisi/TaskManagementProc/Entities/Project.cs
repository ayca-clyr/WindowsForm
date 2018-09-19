using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class Project
    {
        public int ProjectID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int EmployeeID{ get; set; }
        public bool ProjectStatus { get; set; }
        public Employee Employee { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        public DateTime GenerateDate { get; set; }
        public DateTime DeadLine { get; set; }
        public Nullable<DateTime> StartDate { get; set; }
        public Nullable<DateTime> EndDate { get; set; }
        public List<Employee> Employeess { get; set; }

        //public string RequestType { get; set; }
        public virtual Taskk Taskk { get; set; }
        public int? SituaitionID { get; set; }
        public Situaition Situaition { get; set; }

    }
}
