using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL___Interface
{
    public interface IPerson
    {
        List<Entity.Person> GetPerson { get; }
        Person GetPersonById(int id);
        void Update(Entity.Person person);
        void AddPerson(Entity.Person per);
        void RemoveById(int id);
    }
}
