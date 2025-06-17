using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILET_2_
{
    internal class Title
    {
        private string title;

        public Title(string title) // Конструктор, чтобы задать название при создании объекта.
        {
            this.title = title; // Сохраняем переданное название в переменную title.
        }

        public void Show() // Метод для показа названия книги.
        {
            Console.ForegroundColor = ConsoleColor.Green; // Устанавливаем зеленый цвет текста.
            Console.WriteLine($"Название книги: {title}"); // Выводим название книги.
            Console.ResetColor(); // Сбрасываем цвет обратно на стандартный.
        }
    }
}
