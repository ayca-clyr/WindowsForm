using _01_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DataAccessLayer
{
   public class OrderDetailRepository : BaseRepository<OrderDetail>
    {
        internal OrderDetailRepository(AlphaTeamContext context)
            : base(context)
        {

        }
    }
}
