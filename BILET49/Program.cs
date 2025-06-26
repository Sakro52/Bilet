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
                Point[] points = new Point[]
                {
                    new Point(1, 2),
                    new Point(-1, 3),
                    new Point(-2, -4),
                    new Point(3, -5)
                };

                Console.WriteLine("Созданные точки:");
                foreach (Point p in points)
                {
                    p.ShowInfo();
                }

                Console.WriteLine();
                Point.ShowQuadrantCounts();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
