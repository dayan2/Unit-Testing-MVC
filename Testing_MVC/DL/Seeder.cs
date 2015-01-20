using Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class Seeder :DropCreateDatabaseIfModelChanges<CustomerContext>
    {
        protected override void Seed(CustomerContext context)
        {
            Customer cus1 = new Customer { ID = 1, Name = "dayan" };
            Customer cus2 = new Customer { ID = 2, Name = "Mendis" };
            context.Customers.Add(cus1);
            context.Customers.Add(cus2);
            base.Seed(context);
        }
    }
}
