using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Ship : Vehicle// Наследуем класс Ship от Vehicle, что позволяет использовать все его свойства и методы.
    {
        private int passengers;// Количество пассажиров.
        private string port;// Порт приписки.

        public Ship(int x, int y, double price, int speed, int year, int passengers, string port)
            : base(x, y, price, speed, year)// Вызываем конструктор базового класса Vehicle с параметрами x, y, price, speed и year.
        {
            this.passengers = passengers;// Инициализируем количество пассажиров.
            this.port = port;// Инициализируем порт приписки.
        }

        public override void ShowInfo()// Переопределяем метод ShowInfo для отображения информации о корабле.
        {
            base.ShowInfo();// Вызываем базовую реализацию ShowInfo из Vehicle, чтобы получить общую информацию.
            Console.WriteLine("Пассажиры: " + passengers);// Выводим количество пассажиров.
            Console.WriteLine("Порт приписки: " + port);// Выводим порт приписки.
        }
    }
}
