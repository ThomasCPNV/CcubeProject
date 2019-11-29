﻿using System;
using System.Collections.Generic;
using System.Linq;
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

            string passwordHashed = "";

            if (passwordConfirmation == password)
            {
                dbConnect.InsertUser(email, passwordHashed);
                isRegisterOK = true;
            }

            return isRegisterOK;
        }
    }
}
