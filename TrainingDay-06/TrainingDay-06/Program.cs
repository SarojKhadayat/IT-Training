using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceTest;

namespace TrainingDay_06
{
    class Program
    {
        static void Main(string[] args)
        {
            IStudent _student = new Student();
           string status= _student.SearchById(5);
           Console.WriteLine(status);
           Console.ReadKey();
        }
    }
}
