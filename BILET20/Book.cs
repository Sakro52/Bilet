using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    struct Book
    {
        private string title;
        private string author;
        private int year;
        private int pages;

        public Book(string title, string author, int year, int pages)
        {
            this.title = title;
            this.author = author;
            this.year = year;
            this.pages = pages;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Название: " + title);
            Console.WriteLine("Автор: " + author);
            Console.WriteLine("Год издания: " + year);
            Console.WriteLine("Количество страниц: " + pages);
            Console.WriteLine();
        }
    }
}
