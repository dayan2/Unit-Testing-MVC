using DAL___Interface;
using Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PersonRepository : IPerson
    {
        MyEFDBContext context = new MyEFDBContext();
        List<Entity.Person> IPerson.GetPerson
        {
            get { return context.Persons.ToList(); }
        }


        Entity.Person IPerson.GetPersonById(int id)
        {
            Entity.Person person = context.Persons.Find(id);            
            return person;
        }


        void IPerson.Update(Entity.Person person)
        {
            if(person != null)
            {
                context.Entry(person).State = EntityState.Modified;
                context.SaveChanges();
            }
            //Person per = context.Persons.Where(e => e.ID = person.ID);
            //if(per != null)
            //{
            //    per.Name = person.Name;
            //}            
        }


        void IPerson.AddPerson(Entity.Person per)
        {            
             context.Persons.Add(per);
             context.SaveChanges();
        }


        void IPerson.RemoveById(int id)
        {
            var person = context.Persons.Find(id);
            if(person != null)
            {
                context.Persons.Remove(person);
                context.SaveChanges();
            }
        }
    }
}
