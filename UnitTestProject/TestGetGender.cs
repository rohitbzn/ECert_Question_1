using ECert_Question_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class TestGetGender
    {
        [TestMethod]
        public void TestGender()
        {
            Logic logic = new Logic();
            var result = logic.GetGender("8804055205089");
            Assert.AreEqual("The gender is: male", result);
        }
    }
}
