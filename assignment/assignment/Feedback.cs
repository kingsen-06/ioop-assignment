using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class Feedback
    {
        public string Name { get; set; }
        public string Message { get; set; }
        public DateTime SubmittedAt { get; set; }

        public Feedback(string name, string message, DateTime submittedAt)
        {
            Name = name;
            Message = message;
            SubmittedAt = submittedAt;
        }
    }
}
