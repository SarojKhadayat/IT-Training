using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class InValidIntegerException:Exception
    {
        public InValidIntegerException()
            : base()
        { }
        public InValidIntegerException(int value)
            : base(string.Format("Invalid Integer:{0}", value))
        { }
    }
}
