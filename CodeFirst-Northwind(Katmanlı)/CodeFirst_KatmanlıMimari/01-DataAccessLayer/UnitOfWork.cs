using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DataAccessLayer
{
   public class UnitOfWork
    {
       AlphaTeamContext _context;
       public UnitOfWork()
       {
           _context = new AlphaTeamContext();
       }
       CategoryRepository _categoryRepository;
       public CategoryRepository CategoryRepository
       {
           get
           {
               if (_categoryRepository == null)
               {
                   _categoryRepository = new CategoryRepository(_context);
               }
               return _categoryRepository;
           }
       }
       ProductRepository _proRepository;
       public ProductRepository ProductRepository
       {
           get
           {
               if (_proRepository == null)
               {
                   _proRepository = new ProductRepository(_context);
               }
               return _proRepository;
           }
       }

       OrderDetailRepository _orderDetailsRepository;
       public OrderDetailRepository OrderDetailsRepository
       {
           get
           {
               if (_orderDetailsRepository == null)
               {
                   _orderDetailsRepository = new OrderDetailRepository(_context);
               }
               return _orderDetailsRepository;
           }
       }

       DbContextTransaction _tran;
       public bool ApplyChanges()
       {
           bool isSuccess = false;
           _tran = _context.Database.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);  // Commit doğru çalışması.
           try
           {
               _context.SaveChanges();   // İşlemlerin hepsi doğruysa Save işlemini yap.
               _tran.Commit();           // Tran'ı aç.
               isSuccess = true;
           }
           catch (Exception)
           {
               _tran.Rollback();   // İşlemlerin herhangi biri bile yanlışsa işlemleri geri al. 
               isSuccess = false;
           }
           finally
           {
               _tran.Dispose();   // Tran'ı kapat.
           }
           return isSuccess;
       }
    }
}
