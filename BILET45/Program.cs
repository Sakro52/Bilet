using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    internal class Program
    {
        static void ShowShapeInfo(IShape shape)
        {
            Console.WriteLine($"Фигура: {shape}");
            Console.WriteLine($"Периметр: {shape.Perimeter():F2}");
            Console.WriteLine($"Площадь: {shape.Area():F2}");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            try
            {
                Triangle triangle = new Triangle(3, 4, 5);
                Disk disk = new Disk(2.5);

                ShowShapeInfo(triangle);
                ShowShapeInfo(disk);
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
