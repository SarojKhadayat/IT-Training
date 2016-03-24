using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customerModel
{
    public class CustomerFromLibrary
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        public string getFullName(string fname, string lname)
        {
            string fullname = fname + " " + lname;
            return fullname;
        }
    }
}
