using _01_DataAccessLayer;
using _01_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_BusinessLayer
{
    public class CategoryBLL : IBusiness<Category>
    {
        UnitOfWork _uow;

        public CategoryBLL()
        {
            _uow = new UnitOfWork();
        }
        public bool Add(Category item)
        {
            if (!string.IsNullOrWhiteSpace(item.Name))
            {
                _uow.CategoryRepository.Add(item);
                return _uow.ApplyChanges();
            }
            return false;
        }

        public bool Remove(Category item)
        {
            _uow.CategoryRepository.Remove(item);
            return _uow.ApplyChanges();
        }

        public bool Update(Category item)
        {
            if (!string.IsNullOrWhiteSpace(item.Name))
            {
                _uow.CategoryRepository.Update(item);
                return _uow.ApplyChanges();
            }
            return false;
        }

        public Category Get(int id)
        {
            return _uow.CategoryRepository.Get(id);
        }

        public List<Category> GetAll()
        {
            return _uow.CategoryRepository.GetAll();
        }
    }
}
