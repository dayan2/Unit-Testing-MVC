using Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Seeder : DropCreateDatabaseIfModelChanges<MyEFDBContext>
    {
        protected override void Seed(MyEFDBContext context)
        {
            Person p = new Person { ID = 1, Name = "Dayan" };
            Person p1 = new Person { ID = 2, Name = "Neranjan" };
            
            context.Persons.Add(p);
            context.Persons.Add(p1);
            base.Seed(context);
        }
    }
}
