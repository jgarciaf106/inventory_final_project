using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecto_final_Andres_Garcia.Classes
{
    internal class User
    {
        public string username, name, password;

        public User(string in_username, string in_name, string in_password)
        {
            this.username = in_username;
            this.name = in_name;
            this.password = in_password;
        }
    }
}
