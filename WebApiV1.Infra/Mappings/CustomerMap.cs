using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiV1.Infra.Models;

namespace WebApiV1.Infra.Context
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            HasKey(x => x.Id);
            Property(x => x.Email).IsRequired().IsFixedLength().HasMaxLength(50);
            Property(x => x.Name).IsRequired().IsFixedLength().HasMaxLength(70);
            HasMany(x => x.Items);
        }
    }
}
