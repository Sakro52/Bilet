using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    delegate double AverageDelegate(int m, int n);

    internal class Program
    {
        static double Average(int m, int n)
        {
            if (m > n)
            {
                int temp = m;
                m = n;
                n = temp;
            }
            int count = n - m + 1;
            double sum = 0;
            int i;
            for (i = m; i <= n; i++)
            {
                sum += i;
            }
            return sum / count;
        }

        static void Main(string[] args)
        {
            AverageDelegate avgDelegate = new AverageDelegate(Average);

            try
            {
                Console.WriteLine("Вычисление 1:");
                Console.Write("Введите m: ");
                int m1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите n: ");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Среднее арифметическое: " + String.Format("{0:F2}", avgDelegate(m1, n1)));

                Console.WriteLine("\nВычисление 2:");
                Console.Write("Введите m: ");
                int m2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите n: ");
                int n2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Среднее арифметическое: " + String.Format("{0:F2}", avgDelegate(m2, n2)));

                Console.WriteLine("\nВычисление 3:");
                Console.Write("Введите m: ");
                int m3 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите n: ");
                int n3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Среднее арифметическое: " + String.Format("{0:F2}", avgDelegate(m3, n3)));
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введено не число!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
        }
    }
}
