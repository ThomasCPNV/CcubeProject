using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using model;

namespace view
{
    public class TryCatch
    {

        // Email verification.
        public bool IsValidEmail(string email)
        {
            // Quotes verifier.
            if(email.Contains("'") || email.Contains('"'))
            {
                MessageBox.Show("Error : You cannot have quote in your email");
                return false;
            }
            else
            {
                // Email format verifier.
                try
                {
                    var addr = new System.Net.Mail.MailAddress(email);
                    return addr.Address == email;
                }
                catch
                {
                    MessageBox.Show("Error : This isn't an email !");
                    return false;
                }
            }
        }

        // Password verification.
        public bool IsGoodPassword(string password)
        {
            // Password length verifier.
            if(password.Length >= 8)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Error : The password must be at least eight characters long !");
                return false;
            }
        }

        // Login or Register window verifiction.
        public bool LoginOrRegisterView(bool registerView)
        {
            // Login or Register window verifier.
            try
            {
                return registerView == false;
            }
            catch
            {
                MessageBox.Show("Error : An error has occurred !");
                return false;
            }
        }
    }      
}
