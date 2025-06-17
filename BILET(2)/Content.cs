using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILET_2_
{
    internal class Content
    {
        private string content;

        public Content(string content) // Конструктор, чтобы задать содержание.
        {
            this.content = content; // Сохраняем переданное содержание в переменную content.
        }

        public void Show() // Метод для показа содержания книги.
        {
            Console.ForegroundColor = ConsoleColor.Red; // Устанавливаем красный цвет текста.
            Console.WriteLine($"Содержание книги: {content}"); // Выводим содержание.
            Console.ResetColor(); // Сбрасываем цвет на стандартный.
        }
    }
}
