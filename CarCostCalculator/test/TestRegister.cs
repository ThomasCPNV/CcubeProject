using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using model;

namespace test
{
    [TestClass]
    public class TestRegister
    {
        [TestMethod]
        public void TestRegisterCorrect()
        {
            Register register = new Register();
            Random random = new Random();

            int randomNumber = random.Next();

            bool registerVerify = register.RegisterNewAccount($"test_{randomNumber}", "Pa$$W0rd", "Pa$$W0rd");

            Assert.AreEqual(registerVerify, true);
        }

        [TestMethod]
        public void TestRegisterUserAlreadyExist()
        {
            Register register = new Register();

            bool registerVerify = register.RegisterNewAccount($"Thomas.Huguet@cpnv.ch", "Pa$$w0rd", "Pa$$w0rd");

            Assert.AreEqual(registerVerify, false);
        }

        [TestMethod]
        public void TestRegisterPasswordNotLikeConfirmPassword()
        {
            Register register = new Register();

            bool registerVerify = register.RegisterNewAccount($"Thomas.Huguet@cpnv.ch", "Password", "Pa$$w0rd");

            Assert.AreEqual(registerVerify, false);
        }

    }
}
