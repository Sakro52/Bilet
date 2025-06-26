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
                Tour tour = new Tour();

                tour.TourCalc();

                Console.Write("\nВведите страну: ");
                string country = Console.ReadLine();
                tour.TourCalc(country);

                Console.Write("\nВведите страну: ");
                string country2 = Console.ReadLine();
                Console.Write("Введите количество дней: ");
                int days = Convert.ToInt32(Console.ReadLine());
                tour.TourCalc(country2, days);
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: дни должны быть числом!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
        }
    }
}
