using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class BaseClass
    {
        public void getString()
        {
            System.Console.WriteLine("from base");      
        }

    }

    public class DerivedClass:BaseClass
    {
        public void getString()
        {
            System.Console.WriteLine("from Derived");
        }
    }

    public class TestClass
    {
        public void getResult()
        {
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.getString();
           // return str;
        }
    }
   public class BC
    {
        public void Display()
        {
            System.Console.WriteLine("BC::Display");
        }
    }

   public class DC : BC
    {
         public void Display()
        {
            System.Console.WriteLine("DC::Display");
        }
    }

   public class TC : BC
    {
         public void Display()
        {
            System.Console.WriteLine("DC::Display");
        }
    }

}
