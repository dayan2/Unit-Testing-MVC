using Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class CustomerContext : DbContext
    {
        public CustomerContext() :base("CustomerContext")
        {
            Database.SetInitializer(new Seeder());
        }
        public DbSet<Entity.Customer> Customers { get; set; }

        
    }
}
