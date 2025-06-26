using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            try
            {
                Console.Write("Введите первое число: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите второе число: ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Выберите операцию (+, -, *, /): ");
                char operation = Console.ReadKey().KeyChar;
                Console.WriteLine();

                double result;
                if (operation == '+')
                {
                    result = calc.Add(a, b);
                }
                else if (operation == '-')
                {
                    result = calc.Sub(a, b);
                }
                else if (operation == '*')
                {
                    result = calc.Mul(a, b);
                }
                else if (operation == '/')
                {
                    result = calc.Div(a, b);
                }
                else
                {
                    throw new InvalidOperationException("Недопустимая операция!");
                }

                Console.WriteLine("Результат: " + String.Format("{0:F2}", result));
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введено не число!");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            catch (InvalidOperationException ex)
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
