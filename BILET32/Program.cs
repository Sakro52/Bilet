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
            Tovar[] tovars = new Tovar[3];
            tovars[0] = new Obuv("Кроссовки", 5000, 42, 2);
            tovars[1] = new Odejda("Футболка", 1000, "Синий", 5);
            tovars[2] = new Posuda("Тарелка", 200, 0.5, 10);

            int i;
            for (i = 0; i < tovars.Length; i++)
            {
                Console.WriteLine("Товар " + (i + 1) + ":");
                tovars[i].Print();
            }
        }
    }
}
