using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dependency_Injection_MVC.Controllers;
using Moq;
using DAL___Interface;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Dependency_Injection_MVC.Tests
{
    [TestClass]
    public class PersonControllerUnitTest
    {
        [TestMethod]
        public void PersonController_Index_Returns_PersonTypeOfList()
        {
            Mock<IPerson> mock = new Mock<IPerson>();

            mock.Setup(x => x.GetPerson).Returns(new List<Entity.Person> { 
                new Entity.Person{ID = 1 , Name = "ddayan"},
                new Entity.Person{ID = 2 , Name = "mendis"}
            });

            PersonController controller = new PersonController(mock.Object);
            var control = (ViewResult)controller.Index();
            var actual = (List<Entity.Person>)control.Model;
            Assert.IsInstanceOfType( actual , typeof(List<Entity.Person>) );
        }

        [TestMethod]
        public void PersonController_Edit_Returns_A_Person_Model()
        {
            Mock<IPerson> mock = new Mock<IPerson>();
            var expectedPerson = new Entity.Person { ID = 1, Name = "ddayan" };

            mock.Setup(x => x.GetPersonById( It.IsAny<int>() )).Returns( expectedPerson );
            

            PersonController controller = new PersonController(mock.Object);
            var control = (ViewResult)controller.Edit(1);
            var actual = (Entity.Person)control.ViewData.Model;

            Assert.AreEqual(expectedPerson.ID , actual.ID);
            Assert.AreEqual(expectedPerson.Name , actual.Name);
        }
        //[TestMethod]
        //public void PersonController_Edit_Modify_The_Person_Model()
        //{
        //    Mock<IPerson> mock = new Mock<IPerson>();
        //    var expectedPerson = new Entity.Person { ID = 1, Name = "ddayan" };

        //    mock.Setup(x => x.Update( expectedPerson )).Returns(  );


        //    PersonController controller = new PersonController(mock.Object);
        //    var control = (ViewResult)controller.Edit( expectedPerson );
        //    var actual = (Entity.Person)control.ViewData.Model;

        //    Assert.AreEqual(true , actual);
            
        //}
        
        //[TestMethod]
        //public void PersonController_Details_Returns_A_Person_Model()
        //{
        //    Mock<IPerson> mock = new Mock<IPerson>();
        //    var expectedPerson = new Entity.Person { ID = 1, Name = "Dayan" };

        //    mock.Setup(x => x.GetPersonById(It.IsAny<int>())).Returns(expectedPerson);

        //    PersonController controller = new PersonController();
        //    var control = (ViewResult)controller.Details(1);
        //    var actual = (Entity.Person)control.ViewData.Model;

        //    Assert.AreEqual(expectedPerson.ID , actual.ID);
        //    Assert.AreEqual(expectedPerson.Name, actual.Name);
        //}
        [TestMethod]
        public void PersonController_Delete_Redirects_To_The_Index()
        {
            Mock<IPerson> mock = new Mock<IPerson>();
            var expectedPerson = new Entity.Person { ID = 1, Name = "Dayan" };

            mock.Setup(x => x.GetPersonById(It.IsAny<int>()));

            PersonController controller = new PersonController();
            var result = (RedirectToRouteResult)controller.Delete(1);

            Assert.AreEqual("Index", result.RouteValues["action"]);
            Assert.AreEqual("Person", result.RouteValues["controller"]);
        }

    }
}
