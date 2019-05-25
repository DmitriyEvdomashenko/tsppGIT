using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library
{
    public class Book
    {
        [Required]
        [Range(1700, 2019)]
        public int year { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string nameAuthor { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 3)]
        public string title { get; set; }
        public string state = "Свободная";/*{ get { return ""; } set { this.state = "Свободна"; } }*/
        ~Book()
        { }
        //func class
        public int SetInfBook()
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(this);
            while (true)
            {
                Console.Write("Введите название книги: "); title = Console.ReadLine();
                Console.Write("Введите имя автора: "); nameAuthor = Console.ReadLine();
                Console.Write("Введите год издания книги: "); year = Convert.ToInt16(Console.ReadLine());
                if (!Validator.TryValidateObject(this, context, results, true))
                {
                    foreach (var error in results)
                    {
                        Console.WriteLine(error.ErrorMessage);

                    }
                    Console.WriteLine("\nВведите данные снова");
                }
                else break;
            }
            Console.WriteLine("Нажмите на любую клавишу...");
            Console.Clear();
            return 0;
        }
        public void ShowInfBook(bool table = true)
        {
            if (table == true)
            {
                Console.WriteLine("________________________________________________");
                Console.WriteLine("|Название  | Имя автора  |  Год  |  Состоние   |");
                Console.WriteLine("________________________________________________");
            }
            Console.WriteLine($"| {title}   |{nameAuthor}       |{year}   |{state}    |");
            return;
        }
    }
}
