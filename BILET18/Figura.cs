using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Figura
    {
        public void ShowArea(double a)
        {
            double area = a * a;
            Console.WriteLine("Фигура: Квадрат");
            Console.WriteLine("Площадь: " + String.Format("{0:F2}", area));
        }

        public void ShowArea(double a, double b)
        {
            double area = a * b;
            Console.WriteLine("Фигура: Прямоугольник");
            Console.WriteLine("Площадь: " + String.Format("{0:F2}", area));
        }

        public void ShowArea(double a, double b, double h)
        {
            double area = (a + b) * h / 2;
            Console.WriteLine("Фигура: Трапеция");
            Console.WriteLine("Площадь: " + String.Format("{0:F2}", area));
        }
    }
}
