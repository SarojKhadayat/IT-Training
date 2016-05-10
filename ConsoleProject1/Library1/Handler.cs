using System;

namespace Library1
{
    public class Handler
    {
       // int[] array = new int[5];

        public int GetSum(int[] array)
        {
            int sum = 0;
            try
            {
                int length = array.Length;
               
                for (int i = 0; i < length; i++)
                {
                    sum = sum + array[i];
                }
                int a = -2;
                if (a < 0)
                {
                    throw new NegativeNumberException("Negative value" + a);
                }
                // int val=(sum/a);
              
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error Occurred:{0}", ex);
                throw ex;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error Occurred:{0}", ex);
                throw ex;
            }
            catch (NegativeNumberException ex)
            {
                Console.WriteLine("Negative number");
                
            }
            finally
            {
                Console.WriteLine("I am finally something else");
            }
            return sum;
        }
       public void Finalize()
      {

      }
    }
}
