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
                Banknote banknote1 = new Banknote("Ruble", 100, 5);
                Banknote banknote2 = new Banknote("Dollar", 1, 10);
                Banknote banknote3 = new Banknote();

                Console.WriteLine("Banknote Information:");
                banknote1.ShowInfo();
                banknote2.ShowInfo();
                banknote3.ShowInfo();

                banknote1.ChangeQuantity(3);
                Console.WriteLine("After adding 3 banknotes to the first:");
                banknote1.ShowInfo();

                double cost = 250;
                Console.WriteLine($"Can pay for a purchase of {cost:F2}? {banknote1.CanPay(cost)}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
