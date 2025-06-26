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
                Console.Write("Введите должность (0 - Менеджер, 1 - Разработчик, 2 - Тестировщик): ");
                int postIndex = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите количество отработанных часов: ");
                int hours = Convert.ToInt32(Console.ReadLine());

                if (postIndex < 0 || postIndex > 2)
                {
                    throw new ArgumentException("Недопустимая должность!");
                }

                Post worker = (Post)postIndex;
                Accauntant acc = new Accauntant();
                bool bonus = acc.AskForBonus(worker, hours);
                Console.WriteLine("Премия " + (bonus ? "положена" : "не положена"));
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
