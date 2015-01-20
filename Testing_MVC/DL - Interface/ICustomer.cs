
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL___Interface
{
    public interface ICustomer
    {
        List<Customer> Customers { get; }
        Customer GetCustomer(int id);
    }
}
