using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILET11
{
    internal class Program
    {
        static void Main() // Главная функция, с которой начинается программа.
        {
            Console.Write("Введите ключ доступа (pro, exp или ничего): "); // Просим ввести ключ доступа.
            string key = Console.ReadLine().ToLower(); // Считываем ключ, приводим к нижнему регистру для удобства.

            DocumentWorker worker; // Объявляем переменную типа DocumentWorker для хранения экземпляра класса.

            switch (key) // Проверяем введенный ключ и создаем нужный экземпляр.
            {
                case "pro": // Если ключ "pro".
                    worker = new ProDocumentWorker(); // Создаем экземпляр ProDocumentWorker, приводим к DocumentWorker.
                    break;

                case "exp": // Если ключ "exp".
                    worker = new ExpertDocumentWorker(); // Создаем экземпляр ExpertDocumentWorker, приводим к DocumentWorker.
                    break;

                default: // Если ключ пустой или неверный.
                    worker = new DocumentWorker(); // Создаем экземпляр базового DocumentWorker (бесплатная версия).
                    break;
            }

            // Вызываем все методы для демонстрации работы.
            worker.OpenDocument(); // Вызываем метод открытия документа.
            worker.EditDocument(); // Вызываем метод редактирования.
            worker.SaveDocument(); // Вызываем метод сохранения.

            Console.ReadKey(); // Ждем нажатия клавиши, чтобы консоль не закрылась.
        }
    }
}