using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day_07
{
   public class CustomException:Exception
    {
       public CustomException():base()
       { }
       public CustomException(int value)
           : base(string.Format("INVALID NO. ERROR:{0}", value))
       { }
    }
}
