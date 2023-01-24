using ECert_Question_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class TestCheckValidation
    {
        [TestMethod]
        public void TestValidation()
        {
            Logic logic = new Logic();
            var result = logic.CheckValidation("8804055205089");
            Assert.AreEqual("The ID Number passes validation", result);
        }
    }
}
