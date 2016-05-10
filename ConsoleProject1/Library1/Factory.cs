using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1
{
    public class Factory
    {
        //function to add two integer
        public int Add(int a , int b)
        {
            return (a + b);
        }

        public int Add(int a)
        {
            return a + 10;
        }
        public string Add(string a, string b)
        {
            return (a + b);
        }
    }
}
