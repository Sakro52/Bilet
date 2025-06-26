using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    internal class Program
    {
        static void Main(string[] args) // Главная функция, с которой начинается выполнение программы, принимает аргументы командной строки (не используются здесь).
        {
            Console.Write("Введите логин: "); // Выводим запрос на ввод логина.
            string login = Console.ReadLine(); // Считываем введенный логин и сохраняем в переменную login.

            Console.Write("Введите имя: "); // Выводим запрос на ввод имени.
            string name = Console.ReadLine(); // Считываем введенное имя и сохраняем в переменную name.

            Console.Write("Введите фамилию: "); // Выводим запрос на ввод фамилии.
            string surname = Console.ReadLine(); // Считываем введенную фамилию и сохраняем в переменную surname.

            Console.Write("Введите возраст: "); // Выводим запрос на ввод возраста.
            int age = Convert.ToInt32(Console.ReadLine()); // Считываем введенный текст, преобразуем в целое число (int) и сохраняем в переменную age.

            User user = new User(login, name, surname, age); // Создаем объект класса User, передаем логин, имя, фамилию и возраст в конструктор.

            user.ShowInfo(); // Вызываем метод ShowInfo для отображения информации о пользователе.
        }
    }
}
