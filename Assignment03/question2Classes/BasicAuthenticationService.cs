using Assignment03.interfaces.question2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03.question2Classes
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        public bool AuthenticateUser(string username, string password)
        {
            if (username == "Admin" && password == "123456")
            {
                return true;
            }
            return false;
        }

        public bool AuthorizeUser(string username, string role)
        {
            if (username == "Ahmed" && role == "Customer")
            {
                return true;
            }
            return false;
        }
    }
}
