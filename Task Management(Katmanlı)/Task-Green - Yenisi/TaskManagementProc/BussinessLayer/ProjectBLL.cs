using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BussinessLayer
{
    public class ProjectBLL : IBusiness<Project>
    {
        UnitOfWork _uow;
        public ProjectBLL()
        {
            _uow = new UnitOfWork();
        }
 
        public object GetTaskSoftWare()
        {
            return _uow.ProjectRepostory.GetTaskSoftWare();
        }

        public object GetTaskTesting()
        {
            return _uow.ProjectRepostory.GetTaskTesting();
        }
      
        public object ProjectGetAllListTeam()
        {
            return _uow.ProjectRepostory.ProjectGetAllListTeam();
        }
        public object ProjectGetAllList()
        {
            return _uow.ProjectRepostory.ProjectGetAllList();
        }


        public object GetTaskAll()
        {
            return _uow.ProjectRepostory.GetTaskAll();
        }

        public bool Add(Project item)
        {
            if (!string.IsNullOrWhiteSpace(item.Name) && !string.IsNullOrWhiteSpace(item.Description))
            {
                _uow.ProjectRepostory.Add(item);
                return _uow.ApplyChanges();
            }
            return false;
        }
        public Project Get(int id)
        {
            return _uow.ProjectRepostory.Get(id);
        }

        public List<Project> GetAll()
        {
            return _uow.ProjectRepostory.GetAll();
        }

        public bool Remove(Project item)
        {
            _uow.ProjectRepostory.Remove(item);
            return _uow.ApplyChanges();
        }

        public bool Update(Project item)
        {
            _uow.ProjectRepostory.Update(item);
            return _uow.ApplyChanges();
        }

    }
}
