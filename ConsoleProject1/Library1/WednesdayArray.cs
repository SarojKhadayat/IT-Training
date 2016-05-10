using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1
{
    public class WednesdayArray
    {
        // ArrayList myArrayList = new ArrayList();
        public int GetSum(ArrayList arraylist)
        {
            int length = arraylist.Count;
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                sum = sum + Convert.ToInt32(arraylist[i]);
            }
            return sum;
        }
    }

    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string HOD { get; set; }

        public List<Department> InsertAndReturnDepartments(Department department)
        {
            List<Department> Departments = new List<Department>();
            Department obj1 = new Department
            {
                Id = 1,
                Name = "Civil",
                HOD = "Sujan"
            };
            Department obj2 = new Department
            {
                Id = 2,
                Name = "computer",
                HOD = "Rabindra"
            };
            Departments.Add(obj1);
            Departments.Add(obj2);
            Departments.Add(department);
            return Departments;
        }

    }

    public class DictionaryExample
    {      
        public Dictionary<string, int> getStudentsAge()
        {
            Dictionary<string, int> StudentsAge = new Dictionary<string, int>();
            StudentsAge.Add("Bikash", 28);
            StudentsAge.Add("Bharat", 25);
            StudentsAge.Add("sanjay", 20);
            return StudentsAge;
        }
    }
}
