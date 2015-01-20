using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DL___Interface;
using Entity;
using System.Collections.Generic;
using MVC_TestProject.Controllers;
using Moq;

namespace MVC_TestProject.Tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Customer_Contain_ListOfCustomers_Model()
        {
            //install the 'moq' library from the nugets
            Mock<ICustomer> mock = new Mock<ICustomer>();


            //this is saying when ur trying to call the ICustomer property(Customers), instead of requesting it return this list....
            //So that it will not reach the Database
            mock.Setup(e => e.Customers).Returns(new Customer[]
            {
                new Customer{ID = 11 , Name = "neranjan"},
                new Customer{ID = 91 , Name = "Ewerdney"}
            } as IList<Customer>);

            ///sending these elements to the Controller constructor.....
            CustomerController cont = new CustomerController(mock.Object);

            var actual = (List<Customer>)cont.Index().Model;

            //Assert.IsInstanceOfType((actual), List<Customer>);
            //Assert.IsInstanceOfType(typeof(Customer), actual);
            //Assert.IsInstanceOf<Foo>(testObj);
            Assert.IsInstanceOfType<List<Customer>>(actual);
        }
    }
}
