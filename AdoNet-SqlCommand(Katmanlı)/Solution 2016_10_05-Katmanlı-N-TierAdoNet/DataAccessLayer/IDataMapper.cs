using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace DataAccessLayer
{
    interface IDataMapper<TEntity,TKey>
    {
        int insert(TEntity item);
        int Update(TEntity item);
        int Delete(TEntity item);
        List<TEntity> GetAll();
        Category Get(TKey id);
    }
}
