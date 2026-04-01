using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class Trainer
    {
        public string UserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string DOB { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public string Module { get; set; }
        public string Level { get; set; }

        public Trainer(string id, string name, string email, string dob, string contact, string address, string module, string level)
        {
            UserID = id;
            Name = name;
            Email = email;
            DOB = dob;
            ContactNumber = contact;
            Address = address;
            Module = module;
            Level = level;
        }
    }
}
