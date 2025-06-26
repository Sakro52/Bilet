using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Point
    {
        private double x, y;
        private static int quadrant1Count, quadrant2Count, quadrant3Count, quadrant4Count, totalCount;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
            totalCount++;
            if (x > 0 && y > 0)
                quadrant1Count++;
            else if (x < 0 && y > 0)
                quadrant2Count++;
            else if (x < 0 && y < 0)
                quadrant3Count++;
            else if (x > 0 && y < 0)
                quadrant4Count++;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Точка: ({x:F2}, {y:F2})");
        }

        public static void ShowQuadrantCounts()
        {
            Console.WriteLine($"Точек в 1-й четверти: {quadrant1Count}");
            Console.WriteLine($"Точек во 2-й четверти: {quadrant2Count}");
            Console.WriteLine($"Точек в 3-й четверти: {quadrant3Count}");
            Console.WriteLine($"Точек в 4-й четверти: {quadrant4Count}");
            Console.WriteLine($"Общее количество точек: {totalCount}");
        }
    }
}
