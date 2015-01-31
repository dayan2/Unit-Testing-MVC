using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL___Interface
{
    public interface ICusRepo
    {
        List<Entity.Customer> GetCustomers { get; }
        int Calculate(int a);
        void Save(Entity.Customer cus);
    }
}
