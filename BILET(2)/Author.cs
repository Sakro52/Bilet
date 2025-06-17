using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILET_2_
{
    internal class Author
    {
        private string author;

        public Author(string author) // Конструктор, чтобы задать имя автора.
        {
            this.author = author; // Сохраняем переданное имя в переменную author.
        }

        public void Show() // Метод для показа имени автора.
        {
            Console.ForegroundColor = ConsoleColor.Blue; // Устанавливаем синий цвет текста.
            Console.WriteLine($"Автор книги: {author}"); // Выводим имя автора.
            Console.ResetColor(); // Возвращаем стандартный цвет текста.
        }
    }
}
