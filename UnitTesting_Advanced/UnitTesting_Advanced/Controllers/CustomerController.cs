using DL;
using DL___Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace UnitTesting_Advanced.Controllers
{
    public class CustomerController : Controller
    {
        private ICusRepo repo;
        public CustomerController()
        {
            this.repo = new Repository();
        }
        public CustomerController(ICusRepo repo)
        {
            this.repo = repo;
        }

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Entity.Customer cus)
        {
            try
            {
                repo.Save(cus);
            }
            catch (FileNotFoundException  ex)
            {
                throw new FileNotFoundException("Exception thrown", ex);
            }
            return View();
        }

        public ActionResult GetCustomers()
        {
            List<Entity.Customer> CustomersList = repo.GetCustomers;
            return View();
        }

        public ActionResult Calculate()
        {
            var a1 = repo.Calculate(10);
            var a2 = repo.Calculate(20);
            return View();
        }

        

    }
}
