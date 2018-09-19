using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class TaskkBLL : IBusiness<Taskk>
    {
        UnitOfWork _uow;
        public TaskkBLL()
        {
            _uow = new UnitOfWork();
        }
        public bool Add(Taskk item)
        {

            if (!string.IsNullOrWhiteSpace(item.Name))
            {
                _uow.TaskRepository.Add(item);
                return _uow.ApplyChanges();
            }
            return false;
        }
        public Taskk Get(int id)
        {
            return _uow.TaskRepository.Get(id);
        }

        public List<Taskk> GetAll()
        {
            return _uow.TaskRepository.GetAll();
        }

        public bool Remove(Taskk item)
        {
            _uow.TaskRepository.Remove(item);
            return _uow.ApplyChanges();
        }

        public object GetTaskAllNotRequest()
        {
            return _uow.TaskRepository.GetTaskAllNotRequest();
        }

        public bool Update(Taskk item)
        {
            if (!string.IsNullOrWhiteSpace(item.Name))
            {
                _uow.TaskRepository.Update(item);
                return _uow.ApplyChanges();
            }
            return false;
        }
    }
}
