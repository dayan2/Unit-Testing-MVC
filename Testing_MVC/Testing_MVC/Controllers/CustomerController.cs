using DL;
using DL___Interface;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Testing_MVC.Controllers
{
    public class CustomerController : Controller
    {
        //
        // GET: /Customer/
        private ICustomer cusrepo;
        public CustomerController()
        {
            this.cusrepo = new CustomerRepository();
        }

        public CustomerController(ICustomer cus)
        {
            this.cusrepo = cus;
        }

        public ViewResult Index()
        {
            //List<Customer> list = new List<Customer>
            //{
            //    new Customer{ID = 11 , Name = "neranjan"}
            //};
            //List<Models.Customer> list1 = new List<Models.Customer>
            //{
            //    new Models.Customer {ID = 1, Name = "ddd", Address = ""}
            //};
            
            return View(cusrepo.Customers);
        }
        public ViewResult Cus()
        {
            var cus = cusrepo.GetCustomer(1);
            return View(cus);
        }

        

    }
}
