using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using model;

namespace test
{
    /// <summary>
    /// This class contain all the tests
    /// </summary>
    [TestClass]
    public class TestLogin
    {
        /// <summary>
        /// Test correct login request
        /// </summary>
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

        /// <summary>
        /// Test login with incorrect email
        /// </summary>
        [TestMethod]
        public void TestLoginEmailIncorrect()
        {
            Login login = new Login();

            bool loginVerify = login.IsLoginCorrect("Thomas.Huget@cpnv.ch", "Pa$$w0rd");

            Assert.AreEqual(loginVerify, false);
        }

        /// <summary>
        /// Test login with incorrect password
        /// </summary>
        [TestMethod]
        public void TestLoginPasswordIncorrect()
        {
            Login login = new Login();

            bool loginVerify = login.IsLoginCorrect("Thomas.Huguet@cpnv.ch", "Password");

            Assert.AreEqual(loginVerify, false);
        }

    }
}
