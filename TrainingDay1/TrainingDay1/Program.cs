using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using customerModel;

namespace TrainingDay1

{
    class Program
    {
        static void Main(string[] args)
        {
        //    Customer customer1 = new Customer();
        //    Console.WriteLine("Enter First Name:");
        //   // Console.WriteLine("Enter customer Name:");
        //      string name=  Console.ReadLine();
        //      customer1.FirstName = name;
        //      Console.WriteLine("Enter last Name :");
        //      customer1.LastName = Console.ReadLine();
        //   string fullName= customer1.getFullName(customer1.FirstName, customer1.LastName);
        //      Console.WriteLine("The name is: " +fullName);
        //      Console.ReadKey();
            CustomerFromLibrary test = new CustomerFromLibrary{
            CustomerId=1,
            FirstName="hey"
            };
             
        }
    }
}
