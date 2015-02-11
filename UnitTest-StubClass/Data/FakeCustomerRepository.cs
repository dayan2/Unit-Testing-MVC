using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class FakeCustomerRepository
    {
        private MyFakeEFContext context;
        private List<Entity.Customer> CList = new List<Entity.Customer>
        {
            new Entity.Customer{ID = 1, Name = "Dayan"},
            new Entity.Customer{ID = 2, Name = "Dayan"}
        };
        public FakeCustomerRepository()
        {
            this.context = new MyFakeEFContext();
        }
        public List<Entity.Customer> GetAllCustomers { get { return CList; } }
        public void AddCustomer(Entity.Customer cus)
        {
            CList.Add(cus);
        }
        public Entity.Customer GetCustomerById(int id)
        {
            //Entity.Customer cus = CList.Find(id);
            var cus = CList.Find(item => item.ID == id);
            return cus;
        }
    }
}
