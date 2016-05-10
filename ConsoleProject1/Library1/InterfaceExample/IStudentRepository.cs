using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1.InterfaceExample
{
    public interface IStudentRepository
    {
        void Save(Student student);
        List<Student> GetAllStudent();
        List<Student> SearchByName(string name);
    }
}
