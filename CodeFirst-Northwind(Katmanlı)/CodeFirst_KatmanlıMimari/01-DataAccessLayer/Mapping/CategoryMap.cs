using _01_Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DataAccessLayer.Mapping
{
   public class CategoryMap : EntityTypeConfiguration<Category>
    {
       // Category class'î için map'leme işlmei yapacağımı belirttim.
       public CategoryMap()
       {
           HasKey(c => c.CategoryID);

           Property(c => c.Name)
               .IsRequired()         // Zorunlu
               .HasColumnType("varchar")
               .HasMaxLength(50);
           Property(c => c.Description)
               .HasColumnType("varchar")
               .IsOptional();      // Null geçilebilir.
       }
    }
}
