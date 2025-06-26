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
                Computer[] computers = new Computer[]
                {
                    new Computer("Model1", 8, 500),
                    new Computer("Model2", 16, 1000),
                    new Computer("Model3", 32, 2000)
                };

                double totalCost = 0;
                int i;
                for (i = 0; i < computers.Length; i++)
                {
                    double cost = computers[i].CalculateCost();
                    totalCost += cost;
                    Console.WriteLine("Модель: " + computers[i].Model);
                    Console.WriteLine("ОЗУ: " + computers[i].Ram + " ГБ");
                    Console.WriteLine("HDD: " + computers[i].Hdd + " ГБ");
                    Console.WriteLine("Стоимость: " + String.Format("{0:F2}", cost));
                    Console.WriteLine();
                }
                Console.WriteLine("Общая стоимость: " + String.Format("{0:F2}", totalCost));
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
