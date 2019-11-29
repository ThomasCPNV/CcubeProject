﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Helpers;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    class Register
    {
        private DBConnect dbConnect = new DBConnect();

        public bool RegisterNewAccount(string email, string password, string passwordConfirmation)
        {
            bool isRegisterOK = false;

            string passwordHashed = Crypto.HashPassword(password);

            if (passwordConfirmation == password)
            {
                dbConnect.InsertUser(email, passwordHashed);
                isRegisterOK = true;
            }

            return isRegisterOK;
        }
    }
}
