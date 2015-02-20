using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UnitTestingThroughDB.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            Repository repo = new Repository();
            Doctor doctor = new Doctor { ID = 4, Name = "Helloo" };
            repo.Add(doctor);
            return View();
        }
        public ActionResult Show()
        {
            Repository repo = new Repository();
            var list = repo.Show();
            return View(list);
        }

    }
}
