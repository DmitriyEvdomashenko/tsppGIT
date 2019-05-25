using System;
namespace Library
{

    public class Customer
    {
        public static string title2;
        public int num { get; set; }
        public BookCatalog _books = new BookCatalog();
        public string name;
        public void ViewCatalog(ref BookCatalog obj) => obj.ShowListBook();
        public Customer()
        {
            this.name = "Клиент_1";
        }
        public int TakeBook(ref BookCatalog _books, ref Worker _worker, ref IssueList _issueList)
        {
            if (_books.book.Count == 0)
            {
                Console.WriteLine("Каталог пуст!");
                Console.ReadKey();
                Console.Clear();
                return 0;
            }
            Book newBook = new Book();
            Console.WriteLine("Введите пожалуйста информацию о книге: ");
            newBook.SetInfBook();
            for (int i = 0; i < _books.book.Count; i++)
            {
                if (string.Compare(newBook.title, _books.book[i].title) == 0)
                {
                    _books.book[i].state = "Занята";
                    this._books.book.Add(_books.book[i]);
                    _issueList.AddListIssue(new Issue(_books.book[i].title, this.name, this.num, DateTime.Now, _worker.name));
                }
            }
            return 0;
        }
        public int ReturnBook(ref Worker _worker, ref BookCatalog _bc)
        {
            if (_books.book.Count == 0)
            {
                Console.WriteLine("Каталог пуст!");
                Console.ReadKey();
                Console.Clear();
                return 0;
            }
            Console.WriteLine("Введите название книги которую хотите вернуть:");
            title2 = Console.ReadLine();
            for (int i = 0; i < _books.book.Count; i++)
            {
                if (string.Compare(title2, _books.book[i].title) == 0)
                {
                    _books.book.Remove(_books.book[i]);
                    _worker.RetBook(ref _bc);
                }
                else
                {
                    Console.WriteLine("Книга не найдена, нажмите любую клавишу...");
                    Console.ReadKey();
                    Console.Clear();
                    return 0;
                }
            }
            Console.WriteLine("Книга успешно возвращена, нажмите любую клавишу...");
            Console.ReadKey();
            Console.Clear();
            return 0;
        }
        public void ShowInfCustomer() { return; }
        public void SetInfCustomer()
        {
            return;
        }
    }
}