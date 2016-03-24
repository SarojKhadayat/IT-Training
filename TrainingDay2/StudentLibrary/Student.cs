using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary
{
   public class Student
    {
       public Student()
       {
           StudentName = "Ram";
           Level = "Management";
       }
       public Student(string name,string level)
       {
           StudentName = name;
           Level = level;
       }
       public Student(Student obj)
       {
         this.StudentName = obj.StudentName;
         this.Level = obj.Level;
           
       }

       public Student test(string nam, string level)
       {
           this.StudentName = nam;
           this.Level = level;
       }
        public string StudentName { get; set; }
        public string Course { get; set; }
        public string Level { get; set; }
        public bool PaidFee { get; set; }

        public string CheckIfFeePaid(bool isPaid)
        {
            if (isPaid==true)
            {
                return ("Fee  is Paid");
            }
            else 
                return ("Fee not paid");
        }
    }
}
