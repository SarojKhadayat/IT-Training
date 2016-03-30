using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace TrainingDay3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student();
            stud.test = "My world";

            BC b;
            b = new BC();
            b.Display();

            b = new DC();
            b.Display();

            b = new TC();
            b.Display();   
           

          
            //DerivedClass derivedclass = new DerivedClass();
            //string str = derivedclass.add("i ", " am");
            TestClass tclass = new TestClass();
            tclass.getResult();
            //Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
