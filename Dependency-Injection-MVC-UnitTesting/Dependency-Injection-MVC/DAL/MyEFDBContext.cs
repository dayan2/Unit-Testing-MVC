using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MyEFDBContext : DbContext
    {
        public MyEFDBContext(): base("context")
        {
            Database.SetInitializer<MyEFDBContext>( new Seeder() );
        }
        public DbSet<Entity.Person> Persons { get; set; }
    }
}
