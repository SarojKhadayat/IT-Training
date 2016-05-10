using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1
{
    public static class StaticExample
    {
        public static int Count = 0;
        public const string Name = "Administrator";
        //public const string Sp_InsertIntoStudent = "SpInsertIntoStudent";
        //public const string Name = "@Name";
        public static int Increment(int value)
        {
            Count = Count+value + 1;
            return Count;
        }

    }
}
