using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class IssueList
    {
        public List<Issue> stat = new List<Issue>();
        public void ShowList()
        {
            for (int i = 0; i < stat.Count; i++)
            {
                Console.WriteLine("_________________________________________________________");
                Console.WriteLine("+      Работник        |     Клиент/Номер     |        Дата          |       Книга        +");
                Console.WriteLine($"+{stat[i].ObjWorker.name}  {stat[i].objCustomer.name},{stat[i].objCustomer.num}   {stat[i].date}{stat[i].objBook.title}+");
            }
            Console.WriteLine("_________________________________________________________");
            return;
        }
        public int ChangeListIssue() { return 0; }
        public int AddListIssue(Issue _issue = null)
        {
            stat.Add(_issue);
            return 0;
        }
    }
}
