using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILET_4_
{
    internal class Program
    {
        static void Main(string[] args) // Главная функция, с которой начинается программа.
        {
            Address address = new Address(); // Создаем новый объект Address — это как пустая карточка адреса.

            while (true) // Бесконечный цикл, чтобы пользователь мог выбирать, что вводить.
            {
                // Показываем меню с вариантами.
                Console.WriteLine("Выберите, что хотите ввести:");
                Console.WriteLine("1. Почтовый индекс");
                Console.WriteLine("2. Страну");
                Console.WriteLine("3. Город");
                Console.WriteLine("4. Улицу");
                Console.WriteLine("5. Номер дома");
                Console.WriteLine("6. Номер квартиры");
                Console.WriteLine("7. Показать адрес и выйти");
                Console.Write("Введите номер (1-7): ");

                string choice = Console.ReadLine(); // Считываем выбор пользователя.

                switch (choice) // Используем switch-case для обработки выбора.
                {
                    case "1": // Если выбрали 1 — вводим индекс.
                        Console.Write("Введите почтовый индекс (например, 123456): ");
                        address.Index = Console.ReadLine(); // Сохраняем введенный текст.
                        Console.WriteLine("Индекс сохранен!");
                        Console.Clear();
                        break;

                    case "2": // Если выбрали 2 — вводим страну.
                        Console.Write("Введите страну (например, Россия): ");
                        address.Country = Console.ReadLine(); // Сохраняем введенный текст.
                        Console.WriteLine("Страна сохранена!");
                        Console.Clear();
                        break;

                    case "3": // Если выбрали 3 — вводим город.
                        Console.Write("Введите город (например, Москва): ");
                        address.City = Console.ReadLine(); // Сохраняем введенный текст.
                        Console.WriteLine("Город сохранен!");
                        Console.Clear();
                        break;

                    case "4": // Если выбрали 4 — вводим улицу.
                        Console.Write("Введите улицу (например, Ленина): ");
                        address.Street = Console.ReadLine(); // Сохраняем введенный текст.
                        Console.WriteLine("Улица сохранена!");
                        Console.Clear();
                        break;

                    case "5": // Если выбрали 5 — вводим номер дома.
                        while (true) // Цикл для проверки ввода числа.
                        {
                            Console.Write("Введите номер дома (например, 25): ");
                            string houseInput = Console.ReadLine();
                            if (int.TryParse(houseInput, out int house)) // Проверяем, является ли ввод числом.
                            {
                                address.House = house; // Сохраняем число.
                                Console.WriteLine("Номер дома сохранен!");
                                break; // Выходим из цикла проверки.
                            }
                            Console.WriteLine("Ошибка! Введите целое число для номера дома.");
                            Console.Clear();
                        }
                        break;

                    case "6": // Если выбрали 6 — вводим номер квартиры.
                        while (true) // Цикл для проверки ввода числа.
                        {
                            Console.Write("Введите номер квартиры (например, 12): ");
                            string apartmentInput = Console.ReadLine();
                            if (int.TryParse(apartmentInput, out int apartment)) // Проверяем, является ли ввод числом.
                            {
                                address.Apartment = apartment; // Сохраняем число.
                                Console.WriteLine("Номер квартиры сохранен!");
                                break; // Выходим из цикла проверки.
                            }
                            Console.WriteLine("Ошибка! Введите целое число для номера квартиры.");
                            Console.Clear();
                        }
                        break;

                    case "7": // Если выбрали 7 — показываем адрес и выходим.
                        Console.WriteLine("\nИнформация об адресе:");
                        Console.WriteLine($"Почтовый индекс: {address.Index ?? "не указано"}"); // Показываем индекс или "не указано", если null.
                        Console.WriteLine($"Страна: {address.Country ?? "не указано"}"); // Показываем страну.
                        Console.WriteLine($"Город: {address.City ?? "не указано"}"); // Показываем город.
                        Console.WriteLine($"Улица: {address.Street ?? "не указано"}"); // Показываем улицу.
                        Console.WriteLine($"Дом: {address.House}"); // Показываем номер дома (0, если не задано).
                        Console.WriteLine($"Квартира: {address.Apartment}"); // Показываем номер квартиры (0, если не задано).
                        Console.ReadKey(); // Ждем нажатия клавиши, чтобы консоль не закрылась.
                        return; // Завершаем программу.

                    default: // Если ввели что-то не из списка.
                        Console.WriteLine("Ошибка! Введите число от 1 до 7.");
                        Console.Clear();
                        break;
                }
            }
        }
    }
}