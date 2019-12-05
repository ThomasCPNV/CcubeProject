using System;
using System.Collections.Generic;
using System.Linq;
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
}
