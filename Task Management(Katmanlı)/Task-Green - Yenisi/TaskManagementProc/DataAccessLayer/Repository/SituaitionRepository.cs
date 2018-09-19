using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class SituaitionRepository :BaseRepository<Situaition>
    {
        internal SituaitionRepository(TaskManagemenetContext context)
            : base(context)
        {

        }
    }
}
