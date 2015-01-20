using DL___Interface;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class CustomerRepository : ICustomer
    {
        CustomerContext context = new CustomerContext();
        public List<Entity.Customer> Customers { get { return context.Customers.ToList(); } }

        public Customer GetCustomer(int id)
        {
            return context.Customers.Find(id);
        }
    }
}
