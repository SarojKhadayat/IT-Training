using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1
{
    public class NegativeNumberException:Exception
    {
       // public NegativeNumberException()
        public NegativeNumberException(string msg):base(msg)
        {

        }
    }
}
