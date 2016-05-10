using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1.ListExample
{
    public class Client
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string ExamCentre { get; set; }
        public DateTime ExamDate { get; set; }
        public List<QuestionAnswer> questionAnswer { get; set; }
    }
    public class QuestionAnswer
    {
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}
