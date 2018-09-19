using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
     public class Taskk
    {
         public int TaskID { get; set; }
         public string Name { get; set; }
         public string Description { get; set; }
         public int? ProjectID { get; set; }
         public int SituaitionID { get; set; }
         public Situaition Situaition { get; set; }
         public DateTime StartDate { get; set; }
         public DateTime EndDate { get; set; }
         public int? EmployeeID { get; set; }
         public Employee Employee { get; set; }
         public Employee Manager { get; set; }
         public int ManagerID { get; set; }
         public virtual Project Project { get; set; }
        public string RequestType { get; set; }
        public string RequestTypeDescription { get; set; }




    }
}
