using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using model;

namespace test
{
    [TestClass]
    public class TestLogin
    {
        [TestMethod]
        public void TestLoginCorrect()
        {
            Login login = new Login();
            Register register = new Register();

            try
            {
                register.RegisterNewAccount("Thomas.Huguet@cpnv.ch", "Pa$$w0rd", "Pa$$w0rd");
            }
            catch
            {
                
            }

            bool loginVerify = login.IsLoginCorrect("Thomas.Huguet@cpnv.ch", "Pa$$w0rd");

            Assert.AreEqual(loginVerify, true);
        }

        [TestMethod]
        public void TestLoginEmailIncorrect()
        {
            Login login = new Login();

            bool loginVerify = login.IsLoginCorrect("Thomas.Huget@cpnv.ch", "Pa$$w0rd");

            Assert.AreEqual(loginVerify, false);
        }

        [TestMethod]
        public void TestLoginPasswordIncorrect()
        {
            Login login = new Login();

            bool loginVerify = login.IsLoginCorrect("Thomas.Huguet@cpnv.ch", "Password");

            Assert.AreEqual(loginVerify, false);
        }

    }
}
