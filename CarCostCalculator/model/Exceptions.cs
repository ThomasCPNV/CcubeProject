using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Exceptions
    {
        public partial class ConnetionDB : Exception
        {
            public string messageError = "Connexion à la base de données impossible !";
        }

        public class EmailAlreadyTaken : Exception
        {
            public string messageError = "Cet email est déjà utilisé !";
        }

        public class PasswordNotLikeConfirmPassword : Exception
        {
            public string messageError = "La confirmation de mot de passe n'est pas égal au mot de passe !";
        }

        public class FormatEmail : Exception
        {
            public string messageError = "Le format de l'email n'est pas respecté !";
        }

        public class WeakPassword : Exception
        {
            public string messageError = "Votre mot de passe est trop faible !";
        }

        public class WrongPassword : Exception
        {
            public string messageError = "Mauvais mot de passe !";
        }
        public class UnknowEmail : Exception
        {
            public string messageError = "Email inconnu !";
        }

    }
}
