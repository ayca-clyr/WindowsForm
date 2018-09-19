using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class EmployeeRepository : BaseRepository<Employee>
    {
        // Bu class comple Kullanıldı
        TaskManagemenetContext _context;
        internal EmployeeRepository(TaskManagemenetContext context)
            : base(context)
        {
            _context = context;
        }

        public int Get(string mail, string Password)
        {
            try
            {
                int employeeID = _context.Set<Employee>().FirstOrDefault(x => x.Email == mail && x.Password == Password).EmployeeID;
                return employeeID;
            }
            catch(Exception)
            {
                throw;
            }
        }

        public int GetMailRemember(string mail)
        {
            try
            {
                int employeeID = _context.Set<Employee>().FirstOrDefault(x => x.Email == mail ).EmployeeID;
                return employeeID;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public object GetCBxTest()
        {
            var query = (from emp in _context.Set<Employee>()
                         where  emp.AcoountTypeID == 3 || emp.AcoountTypeID == 4 || emp.AcoountTypeID == 5
                         select emp
                     
                         ).ToList();
            return query;
        }
        public object GetCBxTestPost()
        {
            var query = (from emp in _context.Set<Employee>()
                         where emp.AcoountTypeID == 4 
                         select emp

                         ).ToList();
            return query;
        }
        public object GetCBxTestManager()
        {
            var query = (from emp in _context.Set<Employee>()
                         where emp.AcoountTypeID == 2
                         select emp

                         ).ToList();
            return query;
        }


        

        public object GetCBxBusiness()
        {
            var query = (from emp in _context.Set<Employee>()
                         where  emp.AcoountTypeID == 4 || emp.AcoountTypeID == 5
                         select emp

                         ).ToList();
            return query;
        }

        public object GetCBxTestingPost()
        {
            var query = (from emp in _context.Set<Employee>()
                         where emp.AcoountTypeID == 2 || emp.AcoountTypeID == 5
                         select emp

                         ).ToList();
            return query;
        }


        public object GetCBxBusinessManager()
        {
            var query = (from emp in _context.Set<Employee>()
                         where emp.AcoountTypeID == 1 || emp.AcoountTypeID == 2 
                         select emp

                         ).ToList();
            return query;
        }  
    }
}
