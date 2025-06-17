using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILET_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем точки для треугольника (можно изменить на 4 или 5 точек).
            Point p1 = new Point(0, 0, "A"); // Точка A с координатами (0,0).
            Point p2 = new Point(3, 0, "B"); // Точка B с координатами (3,0).
            Point p3 = new Point(0, 4, "C"); // Точка C с координатами (0,4).

            // Создаем фигуру (треугольник) из трех точек.
            Figure figure = new Figure(p1, p2, p3);

            // Выводим название и периметр фигуры.
            figure.PerimeterCalculator();

            Console.ReadKey(); // Ждем нажатия клавиши, чтобы консоль не закрылась.

        }
    }
}
