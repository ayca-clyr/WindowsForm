using _01_DataAccessLayer;
using _01_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_BusinessLayer
{
   public class OrderDetailBLL : IBusiness<OrderDetail>
    {
       UnitOfWork _uow;
       public OrderDetailBLL()
       {
           _uow = new UnitOfWork();
       }

       public bool Add(OrderDetail item)
       {
           _uow.OrderDetailsRepository.Add(item);
               return _uow.ApplyChanges();
          
          
       }

       public bool Remove(OrderDetail item)
       {
           _uow.OrderDetailsRepository.Remove(item);
           return _uow.ApplyChanges();
       }

       public bool Update(OrderDetail item)
       {
           _uow.OrderDetailsRepository.Update(item);
           return _uow.ApplyChanges();
       }

       public OrderDetail Get(int id)
       {
           return _uow.OrderDetailsRepository.Get(id);
       }

       public List<OrderDetail> GetAll()
       {
           return _uow.OrderDetailsRepository.GetAll();
       }
    }
}
