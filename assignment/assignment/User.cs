using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class User
    {
        public string UserID { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Name { get; set; }
        public string TPNumber { get; set; }
        public static User CurrentUser { get; set; }

        public User(string id, string email, string role)
        {
            UserID = id;
            Email = email;
            Role = role;
        }
    }
}
