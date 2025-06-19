using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILET12
{
    internal class Program
    {
        static void Main() // Главная функция, с которой начинается программа.
        {
            while (true) // Бесконечный цикл для меню.
            {
                Console.WriteLine("Выберите тип принтера:");
                Console.WriteLine("1. Обычный принтер (белый текст)");
                Console.WriteLine("2. Цветной принтер (зеленый текст)");
                Console.WriteLine("3. Яркий принтер (желтый текст)");
                Console.WriteLine("4. Выйти");
                Console.Write("Введите номер (1-4): "); // Просим выбрать тип принтера.
                string choice = Console.ReadLine(); // Считываем выбор пользователя.

                switch (choice) // Обрабатываем выбор.
                {
                    case "1": // Обычный принтер.
                        Printer basicPrinter = new Printer(); // Создаем экземпляр Printer, приведенный к Printer.
                        basicPrinter.Print("Тестовый текст для обычного принтера"); // Вызываем Print (белый текст).
                        break;

                    case "2": // Цветной принтер.
                        Printer colorPrinter = new ColorPrinter(); // Создаем ColorPrinter, приводим к Printer.
                        colorPrinter.Print("Тестовый текст для цветного принтера"); // Вызываем Print (зеленый текст).
                        break;

                    case "3": // Яркий принтер.
                        Printer brightPrinter = new BrightPrinter(); // Создаем BrightPrinter, приводим к Printer.
                        brightPrinter.Print("Тестовый текст для яркого принтера"); // Вызываем Print (желтый текст).
                        break;

                    case "4": // Выход.
                        Console.WriteLine("Программа завершена.");
                        Console.ReadKey(); // Ждем нажатия клавиши.
                        return; // Завершаем программу.

                    default: // Неверный выбор.
                        Console.WriteLine("Ошибка! Введите 1, 2, 3 или 4.");
                        break;
                }
            }
        }
    }
}