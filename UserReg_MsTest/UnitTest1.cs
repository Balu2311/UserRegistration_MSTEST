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
            string name = "Vallem";
            bool result = program.FirstNameVal(name);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void LastNameTest()
        {
            string name = "Balu";
            bool result = program.LastNameVal(name);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void EmailTest()
        {
            string email = "vbn.reddy@gmail.com.in";
            bool result = program.EmailValidation(email);
            Assert.AreEqual(true, result);
        }
    }
}
