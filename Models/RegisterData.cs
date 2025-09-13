using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatacomTest.Models
{
    public class RegisterData
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string Country { get; set; }

        public string EmailAddress { get; set; }

        public string Password { get; set; }

        public bool Agree { get; set; }
    }
}
