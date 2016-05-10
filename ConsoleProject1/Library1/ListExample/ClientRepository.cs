using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1.ListExample
{
    public class ClientRepository
    {
        public List<Client> GetAllClientDetails()
        {
            List<Client> AllClients = new List<Client>();
            //Client 1
            List<QuestionAnswer> allquestionAns1 = new List<QuestionAnswer>();
            Client client1 = new Client();
            client1.Name = "Shyam";
            client1.Address = "Kathmandu";
            client1.ExamCentre = "British college";
            client1.ExamDate = DateTime.Now;
            QuestionAnswer quesAns1 = new QuestionAnswer();
            quesAns1.Question = "What is .Net?";
            quesAns1.Answer = ".net is a framework";
            QuestionAnswer quesAns2 = new QuestionAnswer();
            quesAns2.Question = "Full form of MVC?";
            quesAns2.Answer = "Model View Controller";
            allquestionAns1.Add(quesAns1);
            allquestionAns1.Add(quesAns2);

           client1.questionAnswer = new List<QuestionAnswer>();
            client1.questionAnswer=allquestionAns1;
            AllClients.Add(client1);

            //client 2
            Client client2 = new Client();
            List<QuestionAnswer> allquestionAns2 = new List<QuestionAnswer>();
            client2.Address = "Butwal";
            client2.Name = "Ram";
            client2.ExamCentre = "British college";
            client2.ExamDate = DateTime.Now;
            QuestionAnswer quesAns21 = new QuestionAnswer();
            quesAns21.Question = "What is C#?";
            quesAns21.Answer = "C# is a programming Language";
            QuestionAnswer quesAns22 = new QuestionAnswer();
            quesAns22.Question = "Full form Of ORM?";
            quesAns22.Answer = "Object Relational Mapping";
            allquestionAns2.Add(quesAns21);
            allquestionAns2.Add(quesAns22);
            //added
            client2.questionAnswer = new List<QuestionAnswer>();
            client2.questionAnswer = allquestionAns2;
            AllClients.Add(client2);
            return AllClients;
        }
    }
}
