using DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class UnitOfWork
    {
        TaskManagemenetContext _context;

        public UnitOfWork()
        {
            _context = new TaskManagemenetContext();
        }

        AccountTypeRepository _accountTypeRepository;

        public AccountTypeRepository AccountTypeRepository
        {
            get
            {
                if(_accountTypeRepository == null)
                {
                    _accountTypeRepository = new AccountTypeRepository(_context);
                }
                return _accountTypeRepository;
            }
        }

        CustomerRepository _customerRepository;
        public CustomerRepository CustomerRepository
        {
            get
            {
                if (_customerRepository == null)
                {
                    _customerRepository = new CustomerRepository(_context);
                }
                return _customerRepository;
            }
        }


        EmployeeRepository _employeeRepository;
        public EmployeeRepository EmployeeRepository
        {
            get
            {
                if (_employeeRepository == null)
                {
                    _employeeRepository = new EmployeeRepository(_context);
                }
                return _employeeRepository;
            }
        }

        ProjectRepository _projectRepository;
        public ProjectRepository ProjectRepostory
        {
            get
            {
                if (_projectRepository == null)
                {
                    _projectRepository = new ProjectRepository(_context);
                }
                return _projectRepository;
            }
        }

        SituaitionRepository _situaitionRepository;
        public SituaitionRepository SituaitionRepository
        {
            get
            {
                if (_situaitionRepository == null)
                {
                    _situaitionRepository = new SituaitionRepository(_context);
                }
                return _situaitionRepository;
            }
        }

        TaskRepository _taskRepository;
        public TaskRepository TaskRepository
        {
            get
            {
                if (_taskRepository == null)
                {
                    _taskRepository = new TaskRepository(_context);
                }
                return _taskRepository;
            }
        }


        DbContextTransaction _tran;

        public bool ApplyChanges()
        {
            bool isSuccess = false;
            _tran = _context.Database.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);

            try
            {
                _context.SaveChanges();
                _tran.Commit();
                isSuccess = true;
            }
            catch (Exception)
            {

                _tran.Rollback();
                isSuccess = false;
            }
            finally
            {
                _tran.Dispose();
            }
            return isSuccess;
        }


    }
}
