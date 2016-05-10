using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1
{
    public class Student:properties
    {
        public Student()
        {
            Console.WriteLine("I am cunstructor from derived class without parameters");
        }
        public Student(string firstName,string lastName):base(firstName,lastName)
        {
            FullName = firstName + " " + lastName;      
       }
        public Student(string street,string city,string country):base(street,city,country)
        { }
        public int Id { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }

        public string FullName { get; set; }
        public string Address { get; set; }
        public float Amount { get; set; }
        public float FeePaidAmount(Student student)
        {
            return student.Amount;
        }

    }
    public class properties
    {
        public properties()
        {
            Console.WriteLine("I am constructor from base class without params.");
        }
        public properties(string fname,string lname)
        {
            FirstName = fname;
            LastName = lname;
        }
        public properties(string street, string city, string country)
        {
            Street = street;
            City = city;
            Country = country;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string City { get; set; }
        public string Street { get; set; }
        public string Country { get; set; }
    }
}
