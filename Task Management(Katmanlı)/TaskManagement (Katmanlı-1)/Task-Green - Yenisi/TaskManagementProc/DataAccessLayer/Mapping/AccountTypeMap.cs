using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
    class AccountTypeMap : EntityTypeConfiguration<AccountType>
    {
        public AccountTypeMap()
        {
            HasKey(a => a.AccountTypeID);

            Property(a => a.Name)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);
        }
    }
}
