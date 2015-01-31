using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Moq;
using DL___Interface;
using UnitTesting_Advanced.Controllers;
using System.Collections.Generic;

namespace UnitTesting_Advanced.Tests
{
    [TestClass]
    public class CustomerUnitTest
    {
        [TestMethod]
        public void CustomerController_Save_The_Customer_Should_Be_Saved_In_The_DB()
        {
            //Arrange
            Mock<ICusRepo> mock = new Mock<ICusRepo>();

            mock.Setup(x => x.Save(It.IsAny<Entity.Customer>()));

            //Act
            CustomerController controller = new CustomerController(mock.Object);
            controller.Create(new Entity.Customer());

            //Assert
            mock.Verify();//ur Save Method is Functioning properly
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void CustomerController_Save_An_Exception_Should_Be_Raised()
        {
            //Arrange
            Mock<ICusRepo> mock = new Mock<ICusRepo>();

            mock.Setup(x => x.Save(It.IsAny<Entity.Customer>() ))
                .Throws<FileNotFoundException>();

            //Act
            CustomerController controller = new CustomerController(mock.Object);
            controller.Create(new Entity.Customer());
        }

        [TestMethod]
        public void CustomerController_GetCustomers_CustomersList_Receive_A_Value()
        {
            //Arrange
            Mock<ICusRepo> mock = new Mock<ICusRepo>();
            List<Entity.Customer> cuslist = new List<Entity.Customer>() 
            {
                new Entity.Customer{ID = 1, FName = "", LName = ""},
                new Entity.Customer{ID = 2, FName = "", LName = ""}
            };

            mock.Setup(x => x.GetCustomers)
                .Returns(cuslist);

            //Act
            CustomerController controller = new CustomerController(mock.Object);
            controller.GetCustomers();

            //Assert
            //Checking whether your getting da Customers List(is your GetCustomers property functioning properly)
            mock.VerifyGet(x => x.GetCustomers);
        }

        [TestMethod]
        public void CustomerController_Calculate_Method_Calculate_Should_Be_Run_Twice()
        {
            //Arrange
            Mock<ICusRepo> mock = new Mock<ICusRepo>();

            //Act
            CustomerController controller = new CustomerController(mock.Object);
            controller.Calculate();

            //Assert
            mock.Verify(x => x.Calculate(It.IsAny<int>()) , Times.Exactly(2) );
        }

        
    }
}
