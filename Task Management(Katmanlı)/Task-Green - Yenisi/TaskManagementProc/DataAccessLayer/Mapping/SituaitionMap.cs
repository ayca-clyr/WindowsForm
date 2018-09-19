using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
    class SituaitionMap : EntityTypeConfiguration<Situaition>
    {
        public SituaitionMap()
        {
            HasKey(s=> s.SituationID);

            Property(s => s.Name)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(25);
        }
    }
}
