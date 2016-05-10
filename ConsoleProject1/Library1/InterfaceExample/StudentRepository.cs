using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1.InterfaceExample
{
    public class StudentRepository:IStudentRepository
    {
        public void Save(Student student)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAllStudent()
        {
            throw new NotImplementedException();
        }

        public List<Student> SearchByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
