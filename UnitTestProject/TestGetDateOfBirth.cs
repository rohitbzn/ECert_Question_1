using ECert_Question_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class TestGetDateOfBirth
    {
        [TestMethod]
        public void TestGetDateOfBirthMethod()
        {
            Logic logic = new Logic();
            var result = logic.GetDateOfBirth("8804055205089");
            Assert.AreEqual("The date of birth is: 880405", result);
        }
    }
}
