using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                return password.Length >= 8;
            }
            catch
            {
                MessageBox.Show("The password must be at least eight characters long !");
                return false;
            }
        }
    }
}
