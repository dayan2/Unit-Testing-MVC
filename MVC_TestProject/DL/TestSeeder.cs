using Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class TestSeeder : DropCreateDatabaseIfModelChanges<TestDBContext>
    {
        protected override void Seed(TestDBContext context)
        {

            Customer cus1 = new Customer
            {
                ID = 1,
                Name = "dayan"
            };
            context.customers.Add(cus1);
            base.Seed(context);
        }
    }
}
