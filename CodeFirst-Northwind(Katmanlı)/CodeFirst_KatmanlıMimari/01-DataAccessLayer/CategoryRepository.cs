using _01_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DataAccessLayer
{
   public class CategoryRepository : BaseRepository<Category>
    {
       internal CategoryRepository(AlphaTeamContext context)
           : base(context)
       {

       }
    }
}
