using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILET_1_
{
    class Program // Это главный класс, где начинается наша программа.
    {
        static void Main(string[] args) // Это главная функция, с которой программа стартует.
        {
            Console.WriteLine("Введите длину первой стороны прямоугольника:"); // Пишем в консоль, чтобы пользователь ввел первую сторону.
            double side1 = Convert.ToDouble(Console.ReadLine()); // Считываем, что ввел пользователь, и превращаем текст в число.

            Console.WriteLine("Введите длину второй стороны прямоугольника:"); // Просим ввести вторую сторону.
            double side2 = Convert.ToDouble(Console.ReadLine()); // Считываем вторую сторону и превращаем в число.

            Rectangle rectangle = new Rectangle(side1, side2); // Создаем прямоугольник, используя введенные стороны.

            Console.WriteLine($"Площадь прямоугольника: {rectangle.Area}"); // Выводим площадь, используя свойство Area.
            Console.WriteLine($"Периметр прямоугольника: {rectangle.Perimeter}"); // Выводим периметр, используя свойство Perimeter.

            Console.ReadKey(); // Ждем, пока пользователь нажмет клавишу, чтобы окно консоли не закрылось сразу.
        }
    }
}