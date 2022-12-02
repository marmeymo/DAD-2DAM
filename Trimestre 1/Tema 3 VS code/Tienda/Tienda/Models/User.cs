using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class User
    {
        public int id { get; set; }
        public string password { get; set; }
        public string role { get; set; }

        public User(int id, string password, string role)
        {
            this.id = id;
            this.password = password;
            this.role = role;
        }
    }
}
