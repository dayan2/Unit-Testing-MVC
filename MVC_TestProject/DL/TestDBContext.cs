using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class TestDBContext : DbContext
    {
        public TestDBContext()
            : base("TestDBContext")
        {
            Database.SetInitializer(new TestSeeder());
        }

        public DbSet<Entity.Customer> customers { get; set; }
    }
}
