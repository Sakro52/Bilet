using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    delegate int SumDelegate(int m, int n);

    internal class Program
    {
        static int Sum(int m, int n)
        {
            if (m > n)
            {
                int temp = m;
                m = n;
                n = temp;
            }
            int sum = 0;
            for (int i = m; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            SumDelegate sumDelegate = new SumDelegate(Sum);

            try
            {
                for (int i = 1; i <= 3; i++)
                {
                    Console.WriteLine($"Вычисление {i}:");
                    Console.Write("Введите m: ");
                    int m = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите n: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Сумма от {m} до {n}: {sumDelegate(m, n)}");
                    Console.WriteLine();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введено не целое число!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
