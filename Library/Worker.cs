using System;

namespace Library
{
    public class Worker
    {
        public BookCatalog _books = new BookCatalog();
        public string name { get { string _name = "Работник Работникович"; return _name; } set { } }
        public int ViewCatalog(ref BookCatalog _books) { _books.ShowListBook(); return 0; }
        public int WriteOffBook(ref Book _book)
        {
            _book.state = "Списана";
            return 0;
        }
        public int IssueBook(ref Book _book, Customer _person, ref IssueList _issueList)
        {
            _book.state = "Выдана";
            _issueList.AddListIssue(new Issue(this.name, _person.name, _person.num, DateTime.Now, _book.title));
            return 0;
        }
        // public int AddBook() => _books.AddBook();
        public void ChangeNameWorker() => name = Console.ReadLine();
        public void RetBook(ref BookCatalog _bc)
        {
            Console.WriteLine("Введите название книги которую хотите вернуть");
            string title = Console.ReadLine();
            int i = 0;
            for (i = 0; i < _bc.book.Count; i++)
            {
                if (string.Compare(title, _bc.book[i].title) == 0) _bc.book[i].state = "Свободная";
            }
            //_book.state = "Свободная";
            return;
        }
        //public void ShowInfWorker() { return ; }
    }
}
