using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    class Exceptions
    {
        public class EmailAlreadyTaken : Exception
        {
        }

        public class PasswordNotLikeConfirmPassword : Exception
        {
        }

        public class WrongPassword : Exception
        {
        }
        public class WrongEmail : Exception
        {
        }

    }
}
