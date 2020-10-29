using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get;  }
        public string Email { get; set; }

        public User () { }

        public User (string username, string password, string email)
        {
            Username = username;
            Password = password;
            Email = email;
        }
    }
}
