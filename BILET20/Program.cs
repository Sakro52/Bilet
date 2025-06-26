using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество книг: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Book[] books = new Book[n];
            int i;
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("\nВведите данные для книги " + (i + 1) + ":");
                Console.Write("Название: ");
                string title = Console.ReadLine();
                Console.Write("Автор: ");
                string author = Console.ReadLine();
                Console.Write("Год издания: ");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.Write("Количество страниц: ");
                int pages = Convert.ToInt32(Console.ReadLine());

                books[i] = new Book(title, author, year, pages);
            }

            Console.WriteLine("\nИнформация о книгах:");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Книга " + (i + 1) + ":");
                books[i].ShowInfo();
            }
        }
    }
}
