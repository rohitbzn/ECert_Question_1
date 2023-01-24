using ECert_Question_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class TestGetCitizenship
    {
        [TestMethod]
        public void TestCitizenship()
        {
            Logic logic = new Logic();
            var result = logic.GetCitizenship("8804055205089");
            Assert.AreEqual("This is a South African citizen.", result);
        }
    }
}
