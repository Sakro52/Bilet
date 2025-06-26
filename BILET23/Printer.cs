using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    enum Colors
    {
        Красный,
        Синий,
        Зелёный
    }
    static class Printer
    {
        public static void Print(string stroka, int color)
        {
            if (color < 0 || color > 2)
            {
                throw new ArgumentException("Недопустимый номер цвета!");
            }

            if (color == (int)Colors.Красный)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (color == (int)Colors.Синий)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (color == (int)Colors.Зелёный)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }

            Console.WriteLine(stroka);
            Console.ResetColor();
        }
    }
}
