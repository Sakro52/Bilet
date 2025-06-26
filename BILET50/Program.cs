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
            try
            {
                Console.Write("Введите год: ");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите месяц: ");
                int month = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите день: ");
                int day = Convert.ToInt32(Console.ReadLine());

                DateClass date = new DateClass(year, month, day);
                Console.WriteLine($"Текущая дата: {date.Data:dd.MM.yyyy}");
                Console.WriteLine($"Предыдущий день: {date.PreviousDay():dd.MM.yyyy}");
                Console.WriteLine($"Следующий день: {date.NextDay():dd.MM.yyyy}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введено не число!");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Ошибка: недопустимая дата!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
