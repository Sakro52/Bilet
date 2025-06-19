using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILET14
{
    internal class Program
    {
        static void Main(string[] args) // Это точка входа в программу
        {
            Player player = new Player(); // Это создает новый объект Player для использования его методов

            // Давайте проиграем медиа
            player.Play(); // Это начинает проигрывание медиа
            player.Pause(); // Это ставит проигрывание на паузу
            player.Stop(); // Это полностью останавливает медиа
            Console.WriteLine("\n"); // Это добавляет пустую строку для лучшей читаемости вывода
            // Теперь давайте запишем что-то
            player.Record(); // Это начинает запись
            player.Pause(); // Это ставит запись на паузу
            player.Stop(); // Это останавливает запись
            Console.ReadKey(); // Это удерживает консоль открытой, чтобы увидеть результаты
        }
    }
}