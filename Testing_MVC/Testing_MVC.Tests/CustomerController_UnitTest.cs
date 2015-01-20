using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using DL___Interface;

using Entity;
using Testing_MVC.Controllers;
using System.Collections.Generic;

namespace Testing_MVC.Tests
{
    [TestClass]
    public class CustomerController_UnitTest
    {
        [TestMethod]
        public void Customer_Returns_ListOfCustomers_Model()
        {
            Mock<ICustomer> mock = new Mock<ICustomer>();


            //this is saying when ur trying to call the ICustomer property(Customers), instead of requesting it return this list....
            //So that it will not reach the Database
            mock.Setup(e => e.Customers).Returns(new List<Customer>
            {
                new Customer{ID = 11 , Name = "neranjan"},
                new Customer{ID = 91 , Name = "Ewerdney"}
            });

            ///sending these elements to the Controller constructor.....
            CustomerController cont = new CustomerController(mock.Object);

            var actual = (List<Customer>)cont.Index().Model;

            //Assert.AreEqual(typeof(List<Customer>) , actual);
            Assert.IsInstanceOfType(actual, typeof(List<Entity.Customer>));
        }
        [TestMethod]
        public void CustomerController_Returns_Customer_Object()
        {
            Mock<ICustomer> mock = new Mock<ICustomer>();

            //this is saying when ur trying to call the ICustomer property(Customers), instead of requesting it return this list....
            //So that it will not reach the Database
            mock.Setup(e => e.GetCustomer(1)).Returns(new Customer { ID = 11 , Name = "neranjan" });

            ///sending these elements to the Controller constructor.....
            CustomerController cont = new CustomerController(mock.Object);

            var actual = (Customer)cont.Cus().Model;

            Assert.IsInstanceOfType(actual, typeof(Entity.Customer));
        }
    }
}
