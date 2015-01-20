using Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL___Interface
{
    public interface ICustomer
    {
        IList<Customer> Customers { get; }
    }
}
