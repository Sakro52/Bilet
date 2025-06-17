using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILET_3_
{
    class Figure // Класс Figure — это многоугольник, состоящий из 3–5 точек.
    {
        private Point[] points; // Массив точек, из которых состоит многоугольник.
        private string figureName; // Название многоугольника (например, "Треугольник").

        // Конструктор для 3 точек (например, треугольник).
        public Figure(Point p1, Point p2, Point p3)
        {
            points = new Point[] { p1, p2, p3 }; // Создаем массив из 3 точек.
            figureName = "Треугольник"; // Задаем название фигуры.
        }

        // Конструктор для 4 точек (например, четырехугольник).
        public Figure(Point p1, Point p2, Point p3, Point p4)
        {
            points = new Point[] { p1, p2, p3, p4 }; // Создаем массив из 4 точек.
            figureName = "Четырехугольник"; // Задаем название фигуры.
        }

        // Конструктор для 5 точек (например, пятиугольник).
        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            points = new Point[] { p1, p2, p3, p4, p5 }; // Создаем массив из 5 точек.
            figureName = "Пятиугольник"; // Задаем название фигуры.
        }

        public double LengthSide(Point A, Point B) // Метод для подсчета длины стороны между двумя точками.
        {
            // Формула длины: sqrt((x2 - x1)^2 + (y2 - y1)^2).
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }

        public void PerimeterCalculator() // Метод для подсчета и вывода периметра.
        {
            double perimeter = 0; // Переменная для хранения периметра.
            for (int i = 0; i < points.Length; i++) // Проходим по всем точкам.
            {
                // Берем текущую точку и следующую. Для последней точки следующая — первая.
                Point current = points[i];
                Point next = points[(i + 1) % points.Length]; // % помогает вернуться к началу массива.
                perimeter += LengthSide(current, next); // Добавляем длину стороны к периметру.
            }
            // Выводим название фигуры и периметр.
            Console.WriteLine($"Название фигуры: {figureName}");
            Console.WriteLine($"Периметр фигуры: {perimeter:F2}"); // F2 округляет до двух знаков после запятой.
        }
    }
}
