using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass_OOP03.Q2P02
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        private Dictionary<string, string> users = new Dictionary<string, string>
    {
        {"admin", "admin123"},
        {"user1", "password1"},
        {"user2", "password2"}
    };


        private Dictionary<string, string> userRoles = new Dictionary<string, string>
    {
        {"admin", "Administrator"},
        {"user1", "User"},
        {"user2", "User"}
    };

        public bool AuthenticateUser(string username, string password)
        {
            if (users.ContainsKey(username))
            {
                return users[username] == password;
            }
            return false;
        }

        public bool AuthorizeUser(string username, string role)
        {
            if (userRoles.ContainsKey(username))
            {
                return userRoles[username] == role;
            }
            return false;
        }

    }
}
