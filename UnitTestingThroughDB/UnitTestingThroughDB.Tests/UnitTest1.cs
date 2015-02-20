using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business;

namespace UnitTestingThroughDB.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddMethod_Check()
        {
            Repository repo = new Repository();
            Doctor doctor = new Doctor { ID = 3 , Name = "Yohan" };
            repo.Add(doctor);
        }
    }
}
