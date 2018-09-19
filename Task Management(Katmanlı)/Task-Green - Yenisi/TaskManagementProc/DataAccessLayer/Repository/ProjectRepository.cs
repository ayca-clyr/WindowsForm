using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace DataAccessLayer.Repository
{
    public class ProjectRepository : BaseRepository<Project>
    {
        TaskManagemenetContext _context;
        internal ProjectRepository(TaskManagemenetContext context)
            : base(context)
        {
            _context = context;
        }

        public object ProjectGetAllListTeam()
        {
            var query = (from emp in _context.Set<Employee>()
                         join pro in _context.Set<Project>() on emp.EmployeeID equals pro.EmployeeID
                         join cus in _context.Set<Customer>() on pro.CustomerID equals cus.CustomerID
                         join t in _context.Set<Taskk>() on pro.ProjectID equals t.ProjectID

                         select new
                         {
                             GörevNumarası = t.TaskID,
                             ProjeAdı = pro.Name,
                             ProjeAçıklaması = pro.Description,
                             YetkiliAdı = emp.FirstName,
                             YetkiliSoyadı = emp.LastName,
                             MüşteriAdı = cus.CompanyName,
                             ProjeAktifliği = pro.ProjectStatus,
                             ProjeDurumu = pro.Situaition.Name,
                             İstenenBaşlamaTarihi = pro.GenerateDate,
                             İstenenBitirmeTarihi = pro.DeadLine,
                             GörevTalep = t.RequestType,
                             GörevTalepAçıklaması = t.RequestTypeDescription,
                             GörevDurumu = t.Situaition.Name,
                             cus.CustomerID,
                             emp.EmployeeID,
                             pro.ProjectID,
                             t.SituaitionID,

                         }).ToList();

            return query;
        }

        public object ProjectGetAllList()
        {
            var query = (from emp in _context.Set<Employee>()
                         join pro in _context.Set<Project>() on emp.EmployeeID equals pro.EmployeeID
                         join cus in _context.Set<Customer>() on pro.CustomerID equals cus.CustomerID

                         select new
                         {
                             ProjeNumarası = pro.ProjectID,
                             ProjeAdı = pro.Name,
                             ProjeAçıklaması = pro.Description,
                             YetkiliAdı = emp.FirstName,
                             YetkiliSoyadı = emp.LastName,
                             MüşteriAdı = cus.CompanyName,
                             ProjeAktifliği = pro.ProjectStatus,
                             ProjeDurumu = pro.Situaition.Name,
                             İstenenBaşlamaTarihi = pro.GenerateDate,
                             İstenenBitirmeTarihi = pro.DeadLine,
                             cus.CustomerID,
                             emp.EmployeeID,
                             pro.SituaitionID,

                         }).ToList();

            return query;
        }

        public object GetTaskAll()
        {
            var query = (from emp in _context.Set<Employee>()
                         join pro in _context.Set<Project>() on emp.EmployeeID equals pro.EmployeeID
                         join cus in _context.Set<Customer>() on pro.CustomerID equals cus.CustomerID
                         join t in _context.Set<Taskk>() on pro.ProjectID equals t.ProjectID
                         where t.RequestType == "Hata" || t.RequestType == "İstek"
                         select new
                         {
                             GörevNumarası = t.TaskID,
                             ProjeAdı = pro.Name,
                             ProjeAçıklaması = pro.Description,
                             YetkiliAdı = emp.FirstName,
                             YetkiliSoyadı = emp.LastName,
                             MüşteriAdı = cus.CompanyName,
                             ProjeAktifliği = pro.ProjectStatus,
                             ProjeDurumu = pro.Situaition.Name,
                             İstenenBaşlamaTarihi = pro.GenerateDate,
                             İstenenBitirmeTarihi = pro.DeadLine,
                             GörevTalep = t.RequestType,
                             GörevTalepAçıklaması = t.RequestTypeDescription,
                             GörevDurumu = t.Situaition.Name,
                             cus.CustomerID,
                             emp.EmployeeID,
                             pro.ProjectID,
                             t.SituaitionID,

                         }).ToList();

            return query;
        }

        public object GetTaskSoftWare()
        {

            var query = (from tas in _context.Set<Taskk>()
                         join emp in _context.Set<Employee>() on tas.EmployeeID equals emp.EmployeeID

                         where emp.AcoountTypeID == 5 && tas.SituaitionID == 2

                         select new
                         {
                             GörevNumarası = tas.TaskID,
                             GörevAdı = tas.Name,
                             YetkiliAdı = emp.FirstName,
                             YetkiliSoyadı = emp.LastName,
                             GörevAçıklaması = tas.Description,
                             GörevTalep = tas.RequestType,
                             GörevTalepAçıklaması = tas.RequestTypeDescription,
                             GörevBaşlangıçTarihi = tas.StartDate,
                             GörevBitişTarihi = tas.EndDate,
                             emp.AcoountTypeID,
                             emp.EmployeeID,
                             tas.SituaitionID,

                         }).ToList();

            return query;
        }

        public object GetTaskTesting()
        {

            var query = (from tas in _context.Set<Taskk>()
                         join emp in _context.Set<Employee>() on tas.EmployeeID equals emp.EmployeeID
                         join p in _context.Set<Project>() on emp.EmployeeID equals p.EmployeeID into pro
                         from pr in pro.DefaultIfEmpty()

                         where emp.AcoountTypeID == 4 && tas.SituaitionID == 3 && (tas.RequestType == "Hata" || tas.RequestType == "İstek")

                         select new
                         {
                             GörevNumarası = tas.TaskID,
                             GörevTalep = tas.RequestType,
                             GörevTalepAçıklaması = tas.RequestTypeDescription,
                             GörevAdı = tas.Name,
                             YetkiliAdı = emp.FirstName,
                             YetkiliSoyadı = emp.LastName,
                             GörevAçıklaması = tas.Description,
                             GörevBaşlamaTarihi = tas.StartDate,
                             GörevBitişTarihi = tas.EndDate,
                             emp.AcoountTypeID,
                             emp.EmployeeID,
                             tas.SituaitionID,
                             tas.Project.ProjectID,

                         }).ToList();

            return query;
        }


    }
}
