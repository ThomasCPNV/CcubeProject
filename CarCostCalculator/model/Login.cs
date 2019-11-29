using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using CryptSharp;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Login
    {
        private DBConnect dBConnect = new DBConnect();

        public bool IsLoginCorrect(string email, string password)
        {
            bool isLoginCorrect = false;

            string passwordUser = dBConnect.GetPasswordUser(email);

            bool passwordVerify = Crypter.CheckPassword(password, passwordUser);

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
