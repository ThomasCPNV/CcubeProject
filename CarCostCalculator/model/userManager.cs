using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web.Helpers;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Register
    {
        private DBConnect dbConnect = new DBConnect();

        public bool RegisterNewAccount(string email, string password, string passwordConfirmation)
        {
            bool isRegisterOK = false;

            bool verifyEmailAlreadyExist = dbConnect.VerifyEmailAlreadyExist(email);

            string passwordHashed = Crypto.HashPassword(password);

            if (passwordConfirmation == password && verifyEmailAlreadyExist == false)
            {
                dbConnect.InsertUser(email, passwordHashed);
                isRegisterOK = true;
            }
            return isRegisterOK;
        }
    }

    public class Login
    {
        private DBConnect dBConnect = new DBConnect();

        public bool IsLoginCorrect(string email, string password)
        {
            bool isLoginCorrect = false;

            string passwordUser = dBConnect.GetPasswordUser(email);

            bool passwordVerify = Crypto.VerifyHashedPassword(passwordUser, password);

            if (passwordVerify)
            {
                isLoginCorrect = true;
            }
            else
            {
                isLoginCorrect = false;
            }
            return isLoginCorrect;
        }
    }
}