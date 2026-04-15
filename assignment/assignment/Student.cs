using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class Student
    {
        public string StuID { get; set; }
        public string UserID { get; set; }
        public string Name { get; set; }
        public string TPNumber { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }

        public Student(string name, string tpNumber, string email, string contactNumber, string address)
        {
            Name = name;
            TPNumber = tpNumber;
            Email = email;
            ContactNumber = contactNumber;
            Address = address;
        }
    }
}
