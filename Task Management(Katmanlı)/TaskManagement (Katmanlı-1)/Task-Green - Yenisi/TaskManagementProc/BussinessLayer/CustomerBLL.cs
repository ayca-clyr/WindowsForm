using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class CustomerBLL : IBusiness<Customer>
    {
        UnitOfWork _uow;
        public CustomerBLL()
        {
            _uow = new UnitOfWork();
        }
        public bool Add(Customer item)
        {
            if (!string.IsNullOrWhiteSpace(item.CompanyName) && !string.IsNullOrWhiteSpace(item.ContactName) && !string.IsNullOrWhiteSpace(item.Email) && !string.IsNullOrWhiteSpace(item.Phone) && !string.IsNullOrWhiteSpace(item.Address))
            {
                _uow.CustomerRepository.Add(item);
                return _uow.ApplyChanges();
            }
            return false;
        }

        public Customer Get(int id)
        {
            return _uow.CustomerRepository.Get(id);
        }

        public List<Customer> GetAll()
        {
            return _uow.CustomerRepository.GetAll();
        }

        public bool Remove(Customer item)
        {
            _uow.CustomerRepository.Remove(item);
            return _uow.ApplyChanges();
        }

        public bool Update(Customer item)
        {
            if (!string.IsNullOrWhiteSpace(item.CompanyName) && !string.IsNullOrWhiteSpace(item.ContactName) && !string.IsNullOrWhiteSpace(item.Email) && !string.IsNullOrWhiteSpace(item.Phone) && !string.IsNullOrWhiteSpace(item.Address))
            {
                _uow.CustomerRepository.Update(item);
                return _uow.ApplyChanges();
            }
            return false;
        }
    }
}
