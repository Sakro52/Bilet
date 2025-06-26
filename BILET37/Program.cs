using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    delegate double TriangleAreaDelegate(double a, double b, double c);
    internal class Program
    {
        static double S(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0 || (a + b <= c) || (b + c <= a) || (a + c <= b))
            {
                throw new ArgumentException("Невозможно построить треугольник!");
            }
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        static void Main(string[] args)
        {
            TriangleAreaDelegate areaDelegate = new TriangleAreaDelegate(S);

            try
            {
                Console.WriteLine("Треугольник 1:");
                Console.Write("Введите a: ");
                double a1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите b: ");
                double b1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите c: ");
                double c1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Площадь: " + String.Format("{0:F2}", areaDelegate(a1, b1, c1)));

                Console.WriteLine("\nТреугольник 2:");
                Console.Write("Введите a: ");
                double a2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите b: ");
                double b2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите c: ");
                double c2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Площадь: " + String.Format("{0:F2}", areaDelegate(a2, b2, c2)));

                Console.WriteLine("\nТреугольник 3:");
                Console.Write("Введите a: ");
                double a3 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите b: ");
                double b3 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите c: ");
                double c3 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Площадь: " + String.Format("{0:F2}", areaDelegate(a3, b3, c3)));
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введено не число!");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
        }
    }
}
