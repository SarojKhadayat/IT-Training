﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingDay1
{
    public class Customer
    {
        public int CustomerId { get; set; }
         public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        public string getFullName(string fname,string lname)
        {
            string fullname = fname + " " + lname;
            return fullname;     
        }

    }
}