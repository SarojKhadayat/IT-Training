using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    public class Student:IStudent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address  { get; set; }


        public string SearchById(int id)
        {
            return "Data found";
        }
    }
}
