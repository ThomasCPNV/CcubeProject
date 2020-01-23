/*
 * Developer : Thomas Huguet
 * Project : CarCostCalculator
 * Version : 1.0
 * Creation date : 5.12.2019 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web.Helpers;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    /// <summary>
    /// This class is used to manage the register
    /// </summary>
    public class Register
    {
        private DBConnect dbConnect = new DBConnect();

        /// <summary>
        /// Verify if the register request went well
        /// </summary>
        /// <param name="email">contain the email filled by the user</param>
        /// <param name="password">contain the password filled by the user</param>
        /// <param name="passwordConfirmation">contain the confirmation password filled by the user</param>
        /// <returns></returns>
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

    /// <summary>
    /// This class is used to manage the login
    /// </summary>
    public class Login
    {
        private DBConnect dBConnect = new DBConnect();

        /// <summary>
        /// Verify if the login request went well
        /// </summary>
        /// <param name="email">contain the email filled by the user</param>
        /// <param name="password">contain the password filled by the user</param>
        /// <returns></returns>
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