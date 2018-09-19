using _01_DataAccessLayer;
using _01_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_BusinessLayer
{
   public class ProductBLL : IBusiness<Product>
    {
        UnitOfWork _uow;
        public ProductBLL()
        {
            _uow = new UnitOfWork();
        }
        public bool Add(Product item)
        {
            if (!string.IsNullOrWhiteSpace(item.Name))
            {
                _uow.ProductRepository.Add(item);
                return _uow.ApplyChanges();

            }
            return false;
        }

        public bool Remove(Product item)
        {
            _uow.ProductRepository.Remove(item);
            return _uow.ApplyChanges();
        }

        public bool Update(Product item)
        {
            if (!string.IsNullOrWhiteSpace(item.Name))
            {
                _uow.ProductRepository.Update(item);
                return _uow.ApplyChanges();

            }
            return false;
        }

        public Product Get(int id)
        {
           return _uow.ProductRepository.Get(id);
        }

        public List<Product> GetAll()
        {
            return _uow.ProductRepository.GetAll();
        }
    }
}
