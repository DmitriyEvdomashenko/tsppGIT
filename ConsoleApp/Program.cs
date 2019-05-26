using System;
using Library;

namespace ConsoleApp
{
    class Program
    {
        public int total = 0;
        static void Main(string[] args)
        {
            string input = null;
            BookCatalog _bookObj = new BookCatalog();
            IssueList _issueList = new IssueList();
            Customer customer = new Customer();
            Worker worker = new Worker();
            while (true)
            {
                Console.WriteLine("Выберите: ");
                Console.WriteLine("1 - Работник");
                Console.WriteLine("2 - Клиент");
                Console.WriteLine("0 - Выход из программы");
                Console.WriteLine("_________________________");
                var chooseKey = ((input = Console.ReadLine()) != null && input.Length > 0) ? input[0] : ' ';

                switch (chooseKey)
                {
                    case '1':
                        {
                            Console.Clear();
                            Console.WriteLine("Выберите функцию для работника: ");
                            Console.WriteLine("1 - Просмотреть каталог");
                            Console.WriteLine("2 - Добавить в каталог книгу");
                            Console.WriteLine("3 - Посмотреть список выдач");
                            Console.WriteLine("0 - Выйти в главное меню");
                            var chooseKey1 = ((input = Console.ReadLine()) != null && input.Length > 0) ? input[0] : ' ';
                            switch (chooseKey1)
                            {
                                case '1': worker.ViewCatalog(ref _bookObj); break;
                                case '2': _bookObj.AddBook(); break;
                                case '3': _issueList.ShowList(); break;
                                case '0':
                                    Console.Clear();
                                    break;
                                default:
                                    Console.WriteLine("Не корректный ввод, повторите снова...");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                            }
                        }
                        break;
                    case '2':
                        {
                            Console.Clear();
                            Console.WriteLine("Выберите функцию для клиента:");
                            Console.WriteLine("1 - Просмотреть каталог библиотеки");
                            Console.WriteLine("2 - Просмотреть список взятых книг");
                            Console.WriteLine("3 - Взять книгу");
                            Console.WriteLine("4 - Вернуть книгу");
                            Console.WriteLine("0 - Выйти в главное меню");
                            var chooseKey2 = ((input = Console.ReadLine()) != null && input.Length > 0) ? input[0] : ' ';
                            switch (chooseKey2)
                            {
                                case '1': customer.ViewCatalog(ref _bookObj); break;
                                case '2': customer._books.ShowListBook(); break;
                                case '3': customer.TakeBook(ref _bookObj, ref worker, ref _issueList); break;
                                case '4': customer.ReturnBook(ref worker, ref _bookObj); break;
                                case '0': {
                                        Console.Clear();
                                        break;
                                          }
                                default:
                                    Console.WriteLine("Не корректный ввод, повторите снова...");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                            }
                        }
                        break;
                    case '0':
                        {
                            Console.Clear();
                            return;
                        }
                    default: Console.WriteLine("Не корректный ввод, повторите снова...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
