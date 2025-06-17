using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILET_5_
{
    internal class Program
    {
        static void Main() // Главная функция, точка входа в программу, с которой начинается выполнение.
        {
            Converter conv = new Converter(3.2, 3.5, 0.035); // Создаем объект класса Converter, задаем курсы валют: 1 USD = 3.2 BYN, 1 EUR = 3.5 BYN, 1 RUB = 0.035 BYN.
            bool flag = true; // Логическая переменная (флаг): true — программа продолжает работать, false — завершает выполнение.

            while (flag) // Цикл while: повторяет меню и обработку выбора, пока flag не станет false.
            {
                Console.WriteLine("1. Конвертировать из BYN в другую валюту"); // Выводим первый пункт меню: конвертация из белорусских рублей.
                Console.WriteLine("2. Конвертировать из другой валюты в BYN"); // Второй пункт: конвертация в белорусские рубли.
                Console.WriteLine("3. Выйти"); // Третий пункт: выход из программы.
                Console.Write("Введите номер (1-3): "); // Просим пользователя ввести номер действия (1, 2 или 3).
                string choice = Console.ReadLine(); // Считываем введенный пользователем текст (например, "1") и сохраняем в переменную choice.

                switch (choice) // Оператор switch: проверяет значение choice и выполняет соответствующий блок кода.
                {
                    case "1": // Если пользователь ввел "1" — конвертация из BYN в USD, EUR или RUB.
                        try // Начинаем блок try, чтобы поймать возможные ошибки (например, ввод букв вместо числа).
                        {
                            Console.Clear(); // Очищаем консоль, чтобы экран был чистым перед вводом данных.
                            Console.Write("BYN: "); // Выводим запрос на ввод суммы в белорусских рублях.
                            double amount = Convert.ToDouble(Console.ReadLine()); // Считываем введенный текст и преобразуем в число типа double (для дробных чисел).
                            Console.Write("Валюта (USD, EUR, RUB): "); // Просим указать валюту для конвертации (USD, EUR или RUB).
                            string currency = Console.ReadLine(); // Считываем введенную валюту (например, "USD") и сохраняем в переменную currency.
                            Console.ForegroundColor = ConsoleColor.Green; // Устанавливаем зеленый цвет текста для вывода успешного результата.
                            Console.WriteLine($"{conv.ConvertFromBYN(amount, currency):F2} {currency.ToUpper()}"); // Выводим результат: вызываем метод ConvertFromBYN, округляем до двух знаков после запятой (:F2), показываем валюту большими буквами (ToUpper).
                            Console.ResetColor(); // Сбрасываем цвет текста обратно на стандартный (обычно белый или серый).
                        }
                        catch (Exception ex) // Если произошла ошибка (например, ввели "abc" вместо числа или неверную валюту).
                        {
                            Console.ForegroundColor = ConsoleColor.Red; // Устанавливаем красный цвет для сообщения об ошибке.
                            Console.WriteLine(ex.Message); // Выводим текст ошибки, который содержит описание проблемы (например, "Ошибка! Введите USD, EUR или RUB").
                            Console.ResetColor(); // Возвращаем стандартный цвет текста.
                        }
                        Console.Write("Продолжить? (Да/Нет): "); // Спрашиваем, хочет ли пользователь вернуться к меню или завершить программу.
                        if (Console.ReadLine().ToLower() == "нет") flag = false; // Считываем ответ, приводим к нижнему регистру (ToLower), если "нет" — устанавливаем flag = false, чтобы выйти из цикла.
                        break; // Завершаем выполнение case "1" и возвращаемся к началу цикла while.

                    case "2": // Если ввели "2" — конвертация из USD, EUR или RUB в BYN.
                        try // Блок try для обработки ошибок.
                        {
                            Console.Clear(); // Очищаем консоль для чистого ввода.
                            Console.Write("Сумма: "); // Просим ввести сумму в выбранной валюте.
                            double amount = Convert.ToDouble(Console.ReadLine()); // Считываем сумму и преобразуем в число (double).
                            Console.Write("Валюта (USD, EUR, RUB): "); // Запрашиваем валюту, из которой конвертируем.
                            string currency = Console.ReadLine(); // Считываем валюту (например, "EUR").
                            Console.ForegroundColor = ConsoleColor.Green; // Зеленый цвет для успешного результата.
                            Console.WriteLine($"{conv.ConvertToBYN(amount, currency):F2} BYN"); // Выводим результат: вызываем метод ConvertToBYN, округляем до двух знаков, добавляем "BYN".
                            Console.ResetColor(); // Сбрасываем цвет текста.
                        }
                        catch (Exception ex) // Ловим ошибки (например, неверный формат числа или валюты).
                        {
                            Console.ForegroundColor = ConsoleColor.Red; // Красный цвет для ошибки.
                            Console.WriteLine(ex.Message); // Выводим сообщение об ошибке.
                            Console.ResetColor(); // Сбрасываем цвет.
                        }
                        Console.Write("Продолжить? (Да/Нет): "); // Спрашиваем, продолжить ли работу.
                        if (Console.ReadLine().ToLower() == "нет") flag = false; // Если ответ "нет", выходим из цикла.
                        break; // Завершаем case "2".

                    case "3": // Если ввели "3" — завершение программы.
                        Console.Clear(); // Очищаем консоль перед выводом финального сообщения.
                        Console.ForegroundColor = ConsoleColor.Green; // Зеленый цвет для сообщения о завершении.
                        Console.WriteLine("Конец."); // Выводим сообщение "Конец.".
                        Console.ResetColor(); // Сбрасываем цвет текста.
                        Console.ReadKey(); // Ждем, пока пользователь нажмет любую клавишу, чтобы консоль не закрылась сразу.
                        flag = false; // Устанавливаем flag = false, чтобы выйти из цикла while и завершить программу.
                        break; // Завершаем case "3".

                    default: // Если ввели что-то неверное (например, "4", "abc" или ничего).
                        Console.Clear(); // Очищаем консоль.
                        Console.ForegroundColor = ConsoleColor.Red; // Красный цвет для сообщения об ошибке.
                        Console.WriteLine("Введи 1, 2 или 3!"); // Сообщаем, что нужно выбрать правильный номер (1, 2 или 3).
                        Console.ResetColor(); // Сбрасываем цвет.
                        Console.Write("Продолжить? (Да/Нет): "); // Спрашиваем, продолжить ли.
                        if (Console.ReadLine().ToLower() == "нет") flag = false; // Если "нет", выходим из цикла.
                        break; // Завершаем default и возвращаемся к началу цикла.
                }
            }
        }
    }
}                                