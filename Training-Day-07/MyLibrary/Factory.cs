using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Factory
    {
        public int GetSum(int[] arry)
        {
            int sum = 0;
           // int var = 0;
            try
            {
                //int result = 5 / var;
                int len = arry.Length;
                for (int i = 0; i < len; i++)
                {
                    sum = sum + arry[i];
                }
                int res = 5;
                if (res == 5)
                {
                    throw new InValidIntegerException(5);
                }
            }
            catch (InValidIntegerException ex)
            {
                Console.WriteLine("Custom Error:" + ex);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error Occured:: " + ex);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex);
            }
            finally {
                Console.WriteLine("You made a mistake bro");
            }
            return sum;
        }
    }
}
