using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BILET13
{
    internal class Program
    {
        static void Main() // Главная функция, с которой начинается программа.
        {
            AbstractHandler handler = null; // Переменная для хранения обработчика документа.

            while (true) // Бесконечный цикл для главного меню.
            {
                Console.WriteLine("Выберите формат документа:");
                Console.WriteLine("1. XML");
                Console.WriteLine("2. TXT");
                Console.WriteLine("3. DOC");
                Console.WriteLine("4. Выйти");
                Console.Write("Введите номер (1-4): "); // Просим выбрать формат.
                string formatChoice = Console.ReadLine(); // Считываем выбор формата.

                if (formatChoice == "4") // Если выбрали выход, завершаем программу.
                {
                    Console.WriteLine("Программа завершена.");
                    Console.ReadKey(); // Ждем нажатия клавиши.
                    return; // Выходим из Main.
                }

                // Создаем обработчик в зависимости от выбора.
                switch (formatChoice)
                {
                    case "1": // XML формат.
                        handler = new XMLHandler(); // Создаем обработчик для XML.
                        break;
                    case "2": // TXT формат.
                        handler = new TXTHandler(); // Создаем обработчик для TXT.
                        break;
                    case "3": // DOC формат.
                        handler = new DOCHandler(); // Создаем обработчик для DOC.
                        break;
                    default: // Неверный выбор.
                        Console.WriteLine("Ошибка! Введите 1, 2, 3 или 4.");
                        continue; // Возвращаемся к началу цикла.
                }

                // Меню для выбора действия с документом.
                Console.Clear(); // Очищаем консоль для нового меню.
                Console.WriteLine($"Работа с {(formatChoice == "1" ? "XML" : formatChoice == "2" ? "TXT" : "DOC")} документом:");
                Console.WriteLine("1. Открыть");
                Console.WriteLine("2. Создать");
                Console.WriteLine("3. Редактировать");
                Console.WriteLine("4. Сохранить");
                Console.WriteLine("5. Назад в выбор формата");
                Console.Write("Введите номер (1-5): "); // Просим выбрать действие.
                string actionChoice = Console.ReadLine(); // Считываем выбор действия.

                // Выполняем действие в зависимости от выбора.
                switch (actionChoice)
                {
                    case "1": // Открыть документ.
                        handler.Open(); // Вызываем метод Open.
                        break;
                    case "2": // Создать документ.
                        handler.Create(); // Вызываем метод Create.
                        break;
                    case "3": // Редактировать документ.
                        handler.Change(); // Вызываем метод Change.
                        break;
                    case "4": // Сохранить документ.
                        handler.Save(); // Вызываем метод Save.
                        break;
                    case "5": // Вернуться в меню выбора формата.
                        break; // Ничего не делаем, цикл вернет к главному меню.
                    default: // Неверный выбор.
                        Console.WriteLine("Ошибка! Введите 1, 2, 3, 4 или 5.");
                        break;
                }

                Console.WriteLine("Нажмите любую клавишу для продолжения..."); // Пауза для просмотра результата.
                Console.ReadKey(); // Ждем нажатия клавиши.
                Console.Clear(); // Очищаем консоль перед возвратом к меню.
            }
        }
    }
}

