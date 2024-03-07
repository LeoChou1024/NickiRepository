using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitProject
{
    internal class Account
    {
        public string Name { get; set; }
        public int Password { get; set; }

        public string Email { get; set; }

        public Account(string name, int password, string email) 
        {
            this.Name = name;
            this.Password = password;
            this.Email = email;

        }
    }
}
