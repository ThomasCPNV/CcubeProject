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
        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                MessageBox.Show("This isn't an email !");
                return false;
            }
        }

        public bool IsGoodPassword(string password)
        {
            try
            {
                if(password.Length >= 8)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("The password must be at least eight characters long !");
                    return false;
                }
            }
        }

        public bool LoginOrRegisterView(bool registerView)
        {
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
