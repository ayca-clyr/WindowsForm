using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class EmployeeBLL : IBusiness<Employee>
    {
        UnitOfWork _uow;
        public EmployeeBLL()
        {
            _uow = new UnitOfWork();
        }
        public object GetCBxTest()
        {
            return _uow.EmployeeRepository.GetCBxTest();
        }
        public object GetCBxTestPost()
        {
            return _uow.EmployeeRepository.GetCBxTestPost();
        }

        public object GetCBxTestingPost()
        {
            return _uow.EmployeeRepository.GetCBxTestingPost();
        }
        public object GetCBxTestManager()
        {
            return _uow.EmployeeRepository.GetCBxTestManager();
        }
        public object GetCBxBusiness()
        {
            return _uow.EmployeeRepository.GetCBxBusiness();
        }
        public object GetCBxBusinessManager()
        {
            return _uow.EmployeeRepository.GetCBxBusinessManager();
        }

        public bool Add(Employee item)
        {
            if (!string.IsNullOrWhiteSpace(item.FirstName) && !string.IsNullOrWhiteSpace(item.LastName) && !string.IsNullOrWhiteSpace(item.Email) && !string.IsNullOrWhiteSpace(item.Password) && !string.IsNullOrWhiteSpace(item.Phone))
            {
                _uow.EmployeeRepository.Add(item);
                return _uow.ApplyChanges();
            }
            return false;
        }

        public Employee Get(int id)
        {
            return _uow.EmployeeRepository.Get(id);
        }


        public Employee Get(string mail, string password)
        {
            try
            {
                int id = _uow.EmployeeRepository.Get(mail, password);
                return Get(id);
            }
            catch (Exception)
            {
                throw new Exception("Kullanıcı Kayıtlı Değildir!");
            }
        }

        public Employee GetMailRemember(string mail)
        {
            try
            {
                int id = _uow.EmployeeRepository.GetMailRemember(mail);
                return Get(id);
            }
            catch (Exception)
            {

                throw new Exception("Kullanıcı Kayıtlı Değildir!");
            }
        }

        public List<Employee> GetAll()
        {
            return _uow.EmployeeRepository.GetAll();
        }

        public bool Remove(Employee item)
        {
            _uow.EmployeeRepository.Remove(item);
            return _uow.ApplyChanges();
        }

        public bool Update(Employee item)
        {
            if (!string.IsNullOrWhiteSpace(item.FirstName) && !string.IsNullOrWhiteSpace(item.LastName) && !string.IsNullOrWhiteSpace(item.Email) && !string.IsNullOrWhiteSpace(item.Password) && !string.IsNullOrWhiteSpace(item.Phone))
            {
                _uow.EmployeeRepository.Update(item);
                return _uow.ApplyChanges();
            }
            return false;
        }
    }
}
