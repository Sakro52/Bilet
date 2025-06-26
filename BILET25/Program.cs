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
                Console.Write("Введите количество клиентов: ");
                int n = Convert.ToInt32(Console.ReadLine());
                InsuranceClient[] clients = new InsuranceClient[n];

                int i;
                for (i = 0; i < n; i++)
                {
                    Console.WriteLine("\nКлиент " + (i + 1) + ":");
                    Console.Write("Имя: ");
                    string name = Console.ReadLine();
                    Console.Write("Вид страховки: ");
                    string type = Console.ReadLine();
                    Console.Write("Размер страховки: ");
                    double amount = Convert.ToDouble(Console.ReadLine());

                    clients[i] = new InsuranceClient(name, type, amount);
                }

                Console.WriteLine("\nКлиенты с автостраховкой на сумму > 2000 руб.:");
                int autoCount = 0;
                bool found = false;
                for (i = 0; i < clients.Length; i++)
                {
                    if (clients[i].InsuranceType.ToLower() == "автомобиль" && clients[i].InsuranceAmount > 2000)
                    {
                        clients[i].ShowInfo();
                        found = true;
                        autoCount++;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("Клиенты не найдены.");
                }

                Console.WriteLine("Количество клиентов с автостраховкой: " + autoCount);
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
