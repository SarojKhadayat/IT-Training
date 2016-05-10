using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject1
{
    public abstract class Common
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public abstract void Create();

    }
    public class Student : Common
    {
        public string FatherName { get; set; }
        public string DOB { get; set; }
        public bool IsPresent(string Name)
        {
            return true;
        }
        public override void Create()
        {
           //Add student to database
        }
    }
    public class Teacher:Common
    {
        public bool IsClassTeacher { get; set; }
        public string Department { get; set; }
        public override void Create()
        {
            //Add teacher to database
        }

    }
}
