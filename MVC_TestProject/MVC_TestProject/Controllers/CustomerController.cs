using DL;
using DL___Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_TestProject.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomer cusrepo;
        public CustomerController(){
            this.cusrepo = new CustomerRepository();
        }
        public CustomerController(ICustomer cus)
        {
            this.cusrepo = cus;
        }

        public ViewResult Index()
        {
            return View(cusrepo.Customers);
        }

    }
}
