using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class User // Класс User для хранения данных о пользователе.
    {
        private string login; // Приватное поле для хранения логина пользователя.
        private string name; // Приватное поле для хранения имени пользователя.
        private string surname; // Приватное поле для хранения фамилии пользователя.
        private int age; // Приватное поле для хранения возраста пользователя.
        private readonly DateTime dateFilled; // Приватное поле для даты заполнения, доступное только для чтения (устанавливается при создании).

        public User(string login, string name, string surname, int age) // Конструктор класса, принимает логин, имя, фамилию и возраст.
        {
            this.login = login; // Присваиваем переданный логин полю login.
            this.name = name; // Присваиваем переданное имя полю name.
            this.surname = surname; // Присваиваем переданную фамилию полю surname.
            this.age = age; // Присваиваем переданный возраст полю age.
            this.dateFilled = DateTime.Now; // Устанавливаем текущую дату и время в поле dateFilled (не изменяется после создания).
        }

        public void ShowInfo() // Метод для отображения информации о пользователе.
        {
            Console.WriteLine($"Логин: {login}"); // Выводим логин пользователя.
            Console.WriteLine($"Имя: {name}"); // Выводим имя пользователя.
            Console.WriteLine($"Фамилия: {surname}"); // Выводим фамилию пользователя.
            Console.WriteLine($"Возраст: {age}"); // Выводим возраст пользователя.
            Console.WriteLine($"Дата заполнения: {dateFilled:dd.MM.yyyy}"); // Выводим дату заполнения в формате день.месяц.год.
        }
    }
}