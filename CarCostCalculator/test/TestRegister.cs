using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using model;

namespace test
{
    /// <summary>
    /// This class contain all the register tests
    /// </summary>
    [TestClass]
    public class TestRegister
    {
        /// <summary>
        /// Test correct register request
        /// </summary>
        [TestMethod]
        public void TestRegisterCorrect()
        {
            Register register = new Register();
            Random random = new Random();

            int randomNumber = random.Next();

            bool registerVerify = register.RegisterNewAccount($"test_{randomNumber}", "Pa$$W0rd", "Pa$$W0rd");

            Assert.AreEqual(registerVerify, true);
        }

        /// <summary>
        /// Test register with an email already existed in the DB
        /// </summary>
        [TestMethod]
        public void TestRegisterUserAlreadyExist()
        {
            Register register = new Register();

            bool registerVerify = register.RegisterNewAccount($"Thomas.Huguet@cpnv.ch", "Pa$$w0rd", "Pa$$w0rd");

            Assert.AreEqual(registerVerify, false);
        }

        /// <summary>
        /// Test register two password who aren't the same
        /// </summary>
        [TestMethod]
        public void TestRegisterPasswordNotLikeConfirmPassword()
        {
            Register register = new Register();

            bool registerVerify = register.RegisterNewAccount($"Thomas.Huguet@cpnv.ch", "Password", "Pa$$w0rd");

            Assert.AreEqual(registerVerify, false);
        }

    }
}
