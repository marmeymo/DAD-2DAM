using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class User
    {
        public string username { get; set; }
        public string password { get; set; }
        public string rol { get; set; }

        public User() { }

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public User(string username, string password, string rol)
        {
            this.username = username;
            this.password = password;
            this.rol = rol;
        }
    }
}
