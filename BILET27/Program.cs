using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    internal class Program
    {
        static void PrintList(List<string> list)
        {
            Console.WriteLine("Список цветов:");
            int i;
            for (i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            try
            {
                List<string> colors = new List<string>();

                // 1. Добавление строчными буквами
                colors.Add("красный");
                colors.Add("синий");
                colors.Add("зелёный");
                Console.WriteLine("После добавления:");
                PrintList(colors);

                // 2. Преобразование в прописные
                int i;
                for (i = 0; i < colors.Count; i++)
                {
                    colors[i] = colors[i].ToUpper();
                }
                Console.WriteLine("После преобразования в прописные:");
                PrintList(colors);

                // 3. Количество элементов
                Console.WriteLine("Текущее количество элементов: " + colors.Count);

                // 4. Добавление в конец
                colors.Add("жёлтый");
                Console.WriteLine("После добавления в конец:");
                PrintList(colors);

                // 5. Добавление в начало
                colors.Insert(0, "белый");
                Console.WriteLine("После добавления в начало:");
                PrintList(colors);

                // 6. Удаление третьего элемента
                if (colors.Count >= 3)
                {
                    colors.RemoveAt(2);
                }
                Console.WriteLine("После удаления третьего элемента:");
                PrintList(colors);

                // 7. Реверс
                colors.Reverse();
                Console.WriteLine("После реверса:");
                PrintList(colors);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
        }
    }
}
