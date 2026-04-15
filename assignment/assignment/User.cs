using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace assignment
{
    internal class User
    {
        public string UserID { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Name { get; set; }

        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public string DOB { get; set; }

        public static User CurrentUser { get; set; }

        public User(string id, string email, string role)
        {
            UserID = id;
            Email = email;
            Role = role;
        }

        public User(string name, string email, string contact, string address, string dob)
        {
            Name = name;
            Email = email;
            ContactNumber = contact;
            Address = address;
            DOB = dob;
        }
    }
}
