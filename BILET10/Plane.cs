using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Plane : Vehicle// Наследуем класс Plane от Vehicle, что позволяет использовать все его свойства и методы.
    {
        private int altitude;// Высота полета в метрах.
        private int passengers;// Количество пассажиров.

        public Plane(int x, int y, double price, int speed, int year, int altitude, int passengers)
            : base(x, y, price, speed, year)// Вызываем конструктор базового класса Vehicle с параметрами x, y, price, speed и year.
        {
            this.altitude = altitude;// Инициализируем высоту полета.
            this.passengers = passengers;// Инициализируем количество пассажиров.
        }

        public override void ShowInfo()// Переопределяем метод ShowInfo для отображения информации о самолете.
        {
            base.ShowInfo();// Вызываем базовую реализацию ShowInfo из Vehicle, чтобы получить общую информацию.
            Console.WriteLine("Высота: " + altitude + " м");// Выводим высоту полета.
            Console.WriteLine("Пассажиры: " + passengers);// Выводим количество пассажиров.
        }
    }
}
