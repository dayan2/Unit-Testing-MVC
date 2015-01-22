using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting_Simple_MVC.Controllers;
using UnitTesting_Simple_MVC.Models;
using System.Web.Mvc;

namespace UnitTesting_Simple_TestProject
{
    [TestClass]
    public class ProductUnitTest
    {
        [TestMethod]
        public void ProductController_returns_the_right_view()
        {
            //if this didn't work install the 'web mvc' from the nugets......
            ProductController controller = new ProductController();
            var res = controller.Products();
            Assert.AreEqual("Index" , res.ViewName);
        }
        [TestMethod]
        public void ProductController_returning_the_right_data()
        {
            //if this didn't work install the 'web mvc' from the nugets......
            ProductController controller = new ProductController();
            var pr = (Product)controller.GetProduct().ViewData.Model;
            Assert.AreEqual("Dayan" , pr.Name);
        }
        [TestMethod]
        public void ProductController_ProductRedirect_IfIdLessThanOne_RedirectToThe_Right_Path()
        {
            //if this didn't work install the 'web mvc' from the nugets......
            ProductController controller = new ProductController();
            var res = (RedirectToRouteResult)controller.ProductRedirect(-1);
            Assert.AreEqual("ProductRedirect", res.RouteValues["action"]);
        }
        [TestMethod]
        public void ProductController_ProductRedirect_IfIdGreaterThanOne_Return_Right_data()
        {
            //if this didn't work install the 'web mvc' from the nugets......
            ProductController controller = new ProductController();
            var res = controller.ProductRedirect(2);
            //Assert.AreEqual("Dayan", res.Name);
            Assert.IsInstanceOfType(res, typeof(ViewResult));//you need to make sure that 'ProductRedirect()' returns an ActionResult, because of the above uunit test.... 
            //it won't work with 'ViewResult'.... so in here i'm checking whether it is just a viewresult returning type.....
        }

        [TestMethod]
        public void ProductController_ProductSenderJson_Returns_Json_Object()
        {
            ProductController controller = new ProductController();

            var actual = (JsonResult)controller.ProductSenderJson();

            Assert.IsInstanceOfType(actual, typeof(JsonResult));
        }
    }
}
