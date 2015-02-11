using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcClient.Controllers
{
    public class CustomerController : Controller
    {
        public FakeCustomerRepository FRepo = new FakeCustomerRepository();
        public ActionResult Index()
        {
            List<Data.Entity.Customer> list = FRepo.GetAllCustomers;
            return View(list);
        }

    }
}
