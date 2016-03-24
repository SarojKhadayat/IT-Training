using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentLibrary;

namespace TrainingDay2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("ed", "science");
            Student stud = new Student();
            Student newObject = new Student(student);
            string fee = student.CheckIfFeePaid(student.PaidFee);
            Console.WriteLine("Student Objects Value:: Name="+student.StudentName+" Level="+student.Level);
            Console.WriteLine("Stud Objects value:: Name=" + stud.StudentName + " level=" + stud.Level);
            Console.WriteLine("Stud New Object value:: Name=" + newObject.StudentName + " level=" + newObject.Level);
            Console.ReadKey();
           
        }
    }
}
