using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILET12
{
    internal class Printer
    {
        public virtual void Print(string value) // Виртуальный метод для вывода строки.
        {
            Console.ForegroundColor = ConsoleColor.White; // Устанавливаем белый цвет текста (стандартный).
            Console.WriteLine(value); // Выводим переданную строку.
            Console.ResetColor(); // Сбрасываем цвет на стандартный.
        }
    }

    class ColorPrinter : Printer // Производный класс для цветного вывода.
    {
        public override void Print(string value) // Переопределяем метод Print.
        {
            Console.ForegroundColor = ConsoleColor.Green; // Устанавливаем зеленый цвет текста.
            Console.WriteLine(value); // Выводим строку.
            Console.ResetColor(); // Сбрасываем цвет.
        }
    }

    class BrightPrinter : Printer // Производный класс для яркого вывода.
    {
        public override void Print(string value) // Переопределяем метод Print.
        {
            Console.ForegroundColor = ConsoleColor.Yellow; // Устанавливаем желтый цвет текста.
            Console.WriteLine(value); // Выводим строку.
            Console.ResetColor(); // Сбрасываем цвет.
        }
    }
}

