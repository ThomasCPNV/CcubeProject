using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Login
    {
        private string email;
        private string password;
        private DBConnect dbconnect = new DBConnect();

        public bool isLoginCorrect(string email, string password)
        {
            bool isLoginCorrect = false;

            string checkLogin = dbconnect.CheckLogin(email, password);

            if (checkLogin == "")
            {
                isLoginCorrect = false;
            }
            else
            {
                isLoginCorrect = true;
            }

            return isLoginCorrect;
        }
    }
}
