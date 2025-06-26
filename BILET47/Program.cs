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
                while (true)
                {
                    Console.Write("Введите фамилию (или 'Q' для выхода): ");
                    string fam = Console.ReadLine();
                    if (fam.ToUpper() == "Q")
                        break;

                    Console.Write("Введите количество мест: ");
                    int size = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите комфортность: ");
                    string comfort = Console.ReadLine();

                    Zakaz zakaz = new Zakaz(fam, size, comfort);
                    Console.WriteLine("\nСоздан заказ:");
                    zakaz.Show();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: количество мест должно быть числом!");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
