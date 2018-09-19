using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    interface IDataMapper<TEntitiy, TKey>  // Category - Product gibi tüm class'lar TEntitiy olacak. int-string gibi ifadeler yerine ise TKey olacak
    {

        //int Insert(Category item);
        //int Update(Category item);
        //int Delete(Category item);
        //List<Category> GetAll();
        //Category Get(int id);

        int Insert(TEntitiy item);
        int Update(TEntitiy item);
        int Delete(TEntitiy item);
        List<TEntitiy> GetAll();
        TEntitiy Get(TKey id);
    }
}
