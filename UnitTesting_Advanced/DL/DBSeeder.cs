using Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class DBSeeder : DropCreateDatabaseAlways<MyEFContext>
    {
        protected override void Seed(MyEFContext context)
        {
            List<Entity.Customer> cus = new List<Entity.Customer>()
            {
                new Entity.Customer{ID = 1, FName = "dayan", LName = "mendis"},
                new Entity.Customer{ID = 2, FName = "neranjan", LName = "Mendis"},
                new Entity.Customer{ID = 3, FName = "john", LName = "silva"}
            };
            foreach (var item in cus)
            {
                context.Customers.Add(item);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
