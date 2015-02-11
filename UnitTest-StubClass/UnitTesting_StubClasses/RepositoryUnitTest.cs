using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcClient.Controllers;
using Data;
using System.Web.Mvc;
using System.Collections.Generic;

namespace UnitTesting_StubClasses
{
    [TestClass]
    public class RepositoryUnitTest
    {
        [TestMethod]
        public void CustomerController_IndexMethod_ReturningValueShouldBe_A_CustomerList()
        {
            CustomerController controller = new CustomerController();
            var res = (controller.Index() as ViewResult);
            var actual = res.Model as List<Data.Entity.Customer>;
            
            Assert.IsInstanceOfType(actual, typeof(List<Data.Entity.Customer>));
        }
        [TestMethod]
        public void FakeCustomerRepository_AddCustomersMethod_ShouldAddTheCustomerObject()
        {
            FakeCustomerRepository repo = new FakeCustomerRepository();
            Data.Entity.Customer cus = new Data.Entity.Customer
            {
                ID = 3,
                Name = "Dayan"
            };
            repo.AddCustomer(cus);

            var actual = repo.GetCustomerById(3);            
            
            Assert.AreEqual("Dayan" , actual.Name);
        }

    }
}
