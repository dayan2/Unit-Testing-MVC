using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnitTesting_Simple_MVC.Models;

namespace UnitTesting_Simple_MVC.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Product/

        public ActionResult Index()
        {
            return View();
        }

        public ViewResult Products()
        {
            return View("Index");
        }

        public ViewResult GetProduct()
        {
            Product product = new Product
            {
                ID = 1,
                Name = "Dayan"
            };

            return View(product);
        }
        public ActionResult ProductRedirect(int id)
        {
            if (id <= 1)
                return RedirectToAction("ProductRedirect", "Product");
            Product product = new Product{ ID = 1, Name = "Dayan" };
            return View("ProductRedirect", product);
        }

        public ActionResult ProductSenderJson()
        {
            Product product = new Product
            {
                ID = 1,
                Name = "Dayan"
            };
            return Json(product);
        }


    }
}
