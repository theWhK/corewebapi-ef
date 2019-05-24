using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiV1.Infra.Mappings;
using WebApiV1.Infra.Models;

namespace WebApiV1.Infra.Context
{
    public class TodoContext : DbContext
    {
        public TodoContext() : base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TodoDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {
            
        }

        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new TodoItemMap());
            modelBuilder.Configurations.Add(new CustomerMap());
        }

    }
}
