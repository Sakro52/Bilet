using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILET14
{
    interface IPlayable // Интерфейс для функций проигрывания.
    {
        void Play(); // Метод для начала проигрывания.
        void Pause(); // Метод для паузы проигрывания.
        void Stop(); // Метод для остановки проигрывания.
    }

    interface IRecodable // Интерфейс для функций записи.
    {
        void Record(); // Метод для начала записи.
        void Pause(); // Метод для паузы записи.
        void Stop(); // Метод для остановки записи.
    }

    class Player : IPlayable, IRecodable // Класс Player, реализующий оба интерфейса.
    {
        public void Play() // Реализация метода Play из IPlayable.
        {
            Console.WriteLine("Playing ..."); // Выводим сообщение о проигрывании.
        }

        public void Pause() // Реализация метода Pause из IPlayable и IRecodable.
        {
            Console.WriteLine("Paused ..."); // Выводим сообщение о паузе.
        }

        public void Stop() // Реализация метода Stop из IPlayable и IRecodable.
        {
            Console.WriteLine("Stopped ..."); // Выводим сообщение об остановке.
        }

        public void Record() // Реализация метода Record из IRecodable.
        {
            Console.WriteLine("Recording ..."); // Выводим сообщение о записи.
        }
    }
}
