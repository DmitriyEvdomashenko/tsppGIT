using System;
using System.Collections.Generic;

namespace Library
{
    public class IssueList
    {
        public List<Issue> stat = new List<Issue>();
        public void ShowList()
        {
            if (stat.Count == 0)
            {
                Console.WriteLine("Выдач нету, нажмите, чтобы продолжить...");
                Console.ReadKey();
                Console.Clear();
                return;
            }
            for (int i = 0; i < stat.Count; i++)
            {
                Console.WriteLine("_______________________________________________________________________________");
                Console.WriteLine("|      Работник      |      Клиент      |        Дата          |    Книга     |");
                Console.WriteLine($"|    {stat[i].ObjWorker.name}      | {stat[i].objCustomer.name}         | {stat[i].date}    |  {stat[i].objBook.title}|");
            }
            Console.WriteLine("________________________________________________________________________________");
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
            Console.Clear();
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
