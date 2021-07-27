using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration_MsTest;

namespace UserReg_MsTest
{
    [TestClass]
    public class UnitTest1
    {
        private readonly Program program;
        public UnitTest1()
        {
            program = new Program();
        }
        [TestMethod]
        public void FirstNameTest()
        {
            string name = "Vbnreddy";
            bool result = program.FirstNameVal(name);
            Assert.AreEqual(true, result);
        }
    }
}
