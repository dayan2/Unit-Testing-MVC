using DAL;
using DAL___Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dependency_Injection_MVC.Controllers
{
    public class PersonController : Controller
    {
        public IPerson repo;
        public PersonController()
        {
            this.repo = new PersonRepository();
        }
        public PersonController(IPerson repo)
        {
            this.repo = repo;
        }

        public ActionResult Index()
        {
            List<Entity.Person> plist = repo.GetPerson;

            return View(repo.GetPerson);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Entity.Person person = repo.GetPersonById(id);
            return View(person);
        }
        [HttpPost]
        public ActionResult Edit(Entity.Person person)
        {
            //Entity.Person per = repo.GetPersonById(person.ID);           

            repo.Update(person);
            //repo.AddPerson(person);

            return RedirectToAction("Index","Person");
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Entity.Person per)
        {
            repo.AddPerson(per);
            return RedirectToAction("Index" , "Person");
        }
        public ActionResult Details(int id)
        {
            Entity.Person person = repo.GetPersonById(id);
            return View(person);
        }
        public ActionResult Delete(int id)
        {
            repo.RemoveById(id);
            return RedirectToAction("Index","Person");
        }
    }
}
