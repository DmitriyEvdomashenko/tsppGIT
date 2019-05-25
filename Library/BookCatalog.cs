using System;
using System.Collections.Generic;


namespace Library
{
    public class BookCatalog
    {
        public List<Book> book = new List<Book>();

        public int SearchBook(Book _book)
        {
            bool fl = false;
            Book itemSearch = new Book();
            Console.WriteLine("Введите характеристику книги");
            itemSearch.SetInfBook();
            foreach (Book i in book)
            {
                if (i == itemSearch)
                {
                    fl = true;
                    Console.WriteLine("Книга найдена: ");
                    i.ShowInfBook();
                }
            }
            if (fl == false) Console.WriteLine("Данной книги нет в каталоге");
            //book.Sort();book.BinarySearch(itemSearch);
            return 0;
        }
        public int Sort() { book.Sort(); Console.WriteLine("Список отсортирован"); return 0; }
        public int AddBook()
        {
            Book itemAdd = new Book();
            Console.WriteLine("Введите характеристику книги");
            itemAdd.SetInfBook();
            book.Add(itemAdd);
            return 0;
        }
        public void ShowListBook()
        {
            for (int i = 0; i < book.Count; i++)
            {
                if (i == 0) book[i].ShowInfBook(true);
                else book[i].ShowInfBook(false);
            }
            Console.WriteLine("______________________________________");
        }
        public int DeleteBook(Book _book) { return 0; }
    }
}
