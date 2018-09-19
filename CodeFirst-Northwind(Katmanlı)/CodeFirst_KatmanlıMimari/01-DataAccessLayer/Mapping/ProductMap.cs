using _01_Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DataAccessLayer.Mapping
{
   public class ProductMap : EntityTypeConfiguration<Product>
    {
       public ProductMap()
       {
           HasKey(p => p.ProductID);

           Property(p => p.Name)
               .IsRequired()
               .HasColumnType("varchar")
               .HasMaxLength(50);

           Property(p => p.Price)
               .HasColumnType("money")
               .IsOptional();
           Property(p => p.CategoryID)
               .IsOptional();

           HasOptional(p => p.Category) // İlişki boş bırakılabilir.
               .WithMany()            // Bire çok Category class'ı karşı tarafta çok'a denk gelecek.
               .HasForeignKey(p => p.CategoryID);
         
           // Biz class'ları oluştururken CategoryID için boş geçilebilir dediğimiz için yazarken HasOptinal dedik. Ama Composite Key ise ve boş geçilemez alansa bunu HasRequired derdik.
           //HasRequired(p => p.Category)
           //    .WithMany()
           //    .HasForeignKey(p => p.CategoryID);
               


       }
    }
}
