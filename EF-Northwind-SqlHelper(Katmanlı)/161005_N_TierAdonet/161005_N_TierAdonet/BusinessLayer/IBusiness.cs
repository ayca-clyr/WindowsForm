using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    interface IBusiness<TEntitiy, TKey>
    {
        bool Insert(TEntitiy item);
        bool Update(TEntitiy item);
        bool Delete(TEntitiy item);
        List<TEntitiy> GetAll();
        TEntitiy Get(TKey id);
    }
}
