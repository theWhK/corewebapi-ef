using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiV1.Infra.Models;

namespace WebApiV1.Infra.Mappings
{
    public class TodoItemMap : EntityTypeConfiguration<TodoItem>
    {
        public TodoItemMap()
        {
            HasKey(x => x.Id);
            Property(x => x.Name);
            Property(x => x.IsComplete);
        }
    }
}
