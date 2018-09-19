using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class TaskRepository : BaseRepository<Taskk>
    {
        TaskManagemenetContext _context;
        internal TaskRepository(TaskManagemenetContext context)
            : base(context)
        {
            _context = context;
        }

        public object GetTaskAllNotRequest()
        {
            var query = (from emp in _context.Set<Employee>()
                         join pro in _context.Set<Project>() on emp.EmployeeID equals pro.EmployeeID
                         join cus in _context.Set<Customer>() on pro.CustomerID equals cus.CustomerID                       
                         join t in _context.Set<Taskk>() on pro.ProjectID equals t.ProjectID                   
                         
                         select new
                         {
                            GörevNumarası = t.TaskID,
                             GörevTalep = t.RequestType,
                             GörevAdı = t.Name,
                             GörevAçıklaması=t.Description,
                             ProjeAdı=pro.Name,
                             YetkiliAdıSoyadı = emp.FirstName + " " + emp.LastName,
                             MüşteriAdı=cus.CompanyName,
                             GörevBaşlamaTarihi = t.StartDate,
                             GörevBitişTarihi = t.EndDate,
                         }).ToList();
            return query;
        }      
    }
}
