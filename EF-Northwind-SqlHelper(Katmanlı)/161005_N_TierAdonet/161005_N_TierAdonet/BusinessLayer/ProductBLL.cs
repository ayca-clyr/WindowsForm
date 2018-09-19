using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public class ProductBLL : IBusiness<Product,Int32>
    {
       ProductDAL _proDAL = new ProductDAL();


       public bool Insert(Product item)
       {
           if (string.IsNullOrWhiteSpace(item.ProductName))
               return false;
           int affectedRows = 0;
           affectedRows = _proDAL.Insert(item);

           return affectedRows > 0;
       }

       public bool Update(Product item)
       {
            if (string.IsNullOrWhiteSpace(item.ProductName))
                return false;
            int affectedRows = 0;
            affectedRows = _proDAL.Update(item);

            return affectedRows > 0;
        }

       public bool Delete(Product item)
       {
            int affectedRows = _proDAL.Delete(item);

            return affectedRows > 0;
        }

       public List<Product> GetAll()
       {

            List<Product> proList = _proDAL.GetAll();
            return proList;
        }

       public Product Get(int id)
       {
            Product pro = _proDAL.Get(id);
            return pro;
        }
    }
}
