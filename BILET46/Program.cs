using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    internal class Program
    {
        static double Calculate(double number, ICalculation calc1, ICalculation calc2)
        {
            double result = calc1.Perform(number);
            return calc2.Perform(result);
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите число: ");
                double number = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите значение для сложения: ");
                double addValue = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите коэффициент для умножения: ");
                double multiplyFactor = Convert.ToDouble(Console.ReadLine());

                ICalculation add = new Add(addValue);
                ICalculation multiply = new Multiply(multiplyFactor);

                double result = Calculate(number, add, multiply);
                Console.WriteLine($"Результат: {result:F2}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введено не число!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
