using DL___Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class Repository : ICusRepo
    {
        MyEFContext context = new MyEFContext();

        public List<Entity.Customer> GetCustomers { get { return context.Customers.ToList(); } }

        

        void ICusRepo.Save(Entity.Customer cus)
        {
            context.Customers.Add(cus);
            context.SaveChanges();
        }
        
        int ICusRepo.Calculate(int a)
        {
            return a + 10;
        }
    }
}
