using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class MyEFContext : DbContext
    {
        public MyEFContext() : base("MyEFContext")
        {
            Database.SetInitializer(new DBSeeder());
        }

        public DbSet<Entity.Customer> Customers { get; set; }
    }
}
