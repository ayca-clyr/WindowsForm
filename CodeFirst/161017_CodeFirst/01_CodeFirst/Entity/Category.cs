using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CodeFirst.Entity
{

    // ID ya da Class+ID 'yi direk Primary key yapıyor.
    class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        // Çoka-Çok İlişki
        public List<Product> Products { get; set; }
        // Aynı tabloda ilişki kurmak için    
   
        public int? SubCatID { get; set; }


      //public List<Category> Categories { get; set; } // Kendi Kendine gidecek.
       }
}

