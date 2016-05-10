using System;
using Library1;
using System.Collections;
using System.Collections.Generic;
using Library1.InterfaceExample;
using System.Configuration;
using Library1.ListExample;
namespace ConsoleProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Abstract class example
            //Student student = new Student();
            //Console.WriteLine("Enter Your ID:");
            //   student.Id=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter your Name:");
            //student.Name= Console.ReadLine();
            //student.Create();
            //Console.WriteLine("Your Name is:" + student.Name);
            //Console.ReadKey();
            #endregion
            #region Function Overloading
            //Input to add two integers
            //Console.WriteLine("Enter two integers:");
            //int Fint = Convert.ToInt32(Console.ReadLine());
            //int Sint = Convert.ToInt32(Console.ReadLine());

            ////input to increment on integer
            //Console.WriteLine("Enter One Integer");
            //int Tint = Convert.ToInt32(Console.ReadLine());

            ////Input to concatenate Two strings
            //Console.WriteLine("Enter Two Strings To Concatenate");
            //string str1 = Console.ReadLine();
            //string str2 = Console.ReadLine();
            //Factory factory = new Factory();
            //int first = factory.Add(Fint, Sint);
            //int second = factory.Add(Tint);
            //string third = factory.Add(str1, str2);

            //Console.WriteLine("From First Function:{0}", first);
            //Console.WriteLine("From second Function:{0}", second);
            //Console.WriteLine("From third function:{0}", third);
            //Console.ReadKey();
            #endregion
            #region function overriding
            //Triangle triangle=new Triangle();
            //float area = triangle.Area(2, 10);

            ////reference type object
            //BaseClass bclass = new Triangle();
            //float baseArea = bclass.Area(2, 10);


            //Console.WriteLine("Area of triangle:{0}", area);
            //Console.WriteLine("Area from BaseClass:{0}", baseArea);
            //Console.ReadKey();

            #endregion
            #region Partial Class Example

            // Customer customer = new Customer();
            //customer.
            #endregion
            #region Constructor Example
            //Student student = new Student("Bijay", "pandey");
            //student.Address = "Kathmandu";
            //student.Amount = 10000;
            //float amount = student.FeePaidAmount(student);
            //Console.WriteLine("Name {0}:", student.FullName);
            //Console.WriteLine("Fee Amount {0}:", amount);
            //Console.ReadKey();
            #endregion
            #region  base class cunstructor
            //Student student = new Student("saroj","Khadayat");
            //Console.ReadKey();
            #endregion

            #region Exception Handling
            //Handler handler = new Handler();
            //int[] array = { 1, 2, 4, 5, 6 };
            //int sum = handler.GetSum(array);
            //Console.WriteLine("The sum is:{0}", sum);
          
            //Console.ReadKey();
            #endregion
            #region Array,arraylist,list,dictionary
            //int[] arr=new int[5];

            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(1);
            //arrayList.Add(10);
            //arrayList.Add(9);
            //WednesdayArray wedArray = new WednesdayArray();
            //int sum = wedArray.GetSum(arrayList);
            //Console.WriteLine("The sum is:{0}", sum);

            ////List Example

           // WednesdayArray wedArray = new WednesdayArray();
           // Department department = new Department();
           // List<Department> allDepartments = new List<Department>();
           // department.Id = 3;
           // department.Name = "Electronics";
           // department.HOD = "Saroj";
           //allDepartments= department.InsertAndReturnDepartments(department);          
           //foreach (Department dep in allDepartments)
           //{
           //    Console.WriteLine("Id:{0} Name:{1} HOD:{2}", dep.Id, dep.Name, dep.HOD);
           //   // Console.ReadKey();
           //}


            ////Dictionary Example
            //try
            //{
            //    Dictionary<string, int> AllStudents = new Dictionary<string, int>();
            //    DictionaryExample dictionary = new DictionaryExample();
            //    AllStudents = dictionary.getStudentsAge();
            //    foreach (KeyValuePair<string, int> pair in AllStudents)
            //    {
            //        Console.WriteLine("Name:{0} and Age:{1}", pair.Key, pair.Value);
            //    }
            //    Console.WriteLine("Give me a name");
            //    string name = Console.ReadLine();            
            //    int age = AllStudents[name];
            //    Console.WriteLine("Age:{0}", age);

            //   // Console.ReadKey();
            //}
            //catch (KeyNotFoundException ex)
            //{
            //    Console.WriteLine("name not found in dictionary");
            //}
         //   Console.ReadKey();
            #endregion
         

            #region Interface Example
            //IStudentRepository _StudentRepository = new StudentRepository();
            //_StudentRepository.GetAllStudent();
            #endregion
           
           
            #region Example Static Class
            //try
            //{
            //    int value = StaticExample.Increment(10);
            //    Console.WriteLine("Value {0}", value);
            //    int value2 = StaticExample.Increment(10);

            //    Console.WriteLine("Value {0}", value2);
            //    Console.ReadKey();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            #endregion

            #region List Example
            ClientRepository clientRepository = new ClientRepository();
            List<Client> Clients =new List<Client>();
            Clients = clientRepository.GetAllClientDetails();

            foreach (Client client in Clients)
            {
                Console.WriteLine("Name:{0} Address:{1} ExamCentre:{2}  ExamDate {3} ", client.Name, client.Address, client.ExamCentre, client.ExamDate);
               // Console.ReadKey();
                foreach (QuestionAnswer questionAnswer in client.questionAnswer)
                {
                    Console.WriteLine("Question:{0} Answer:{1}", questionAnswer.Question, questionAnswer.Answer);
                }
            }
            Console.ReadKey();
            #endregion

        }
    }
}
