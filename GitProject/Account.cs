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

        public Account(string name, int password) 
        {
            this.Name = name;
            this.Password = password;
        }
    }
}
