using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MyLibrary;
namespace Training_Day_07
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Training day Array Test
            Factory factory = new Factory();
            int[] arr = new int[5];
            int length=arr.Length;
             //Loop to input array items from user
            for(int i=0;i<length;i++)
            {
                Console.WriteLine("Insert integer Array[" + i + "]");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum=factory.GetSum(arr);
            Console.WriteLine("Sum of array is:{0}",sum);
            Console.ReadKey();
            #endregion






        }
    }
}
