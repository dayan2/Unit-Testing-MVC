using DL___Interface;
using Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class CustomerRepository : ICustomer
    {
        TestDBContext context = new TestDBContext();
        public IList<Customer> Customers { get { return context.customers.ToList();} }
    }
}
