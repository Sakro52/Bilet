using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    abstract class Vehicle// Абстрактный класс Vehicle, который будет базовым для всех транспортных средств.
    {
        protected int x, y;// Координаты транспортного средства.
        protected double price;// Цена транспортного средства.
        protected int speed;// Скорость транспортного средства в км/ч.
        protected int year;// Год выпуска транспортного средства.

        public Vehicle(int x, int y, double price, int speed, int year)// Конструктор класса Vehicle, принимающий координаты, цену, скорость и год выпуска.
        {
            this.x = x;// Инициализация координаты x.
            this.y = y;// Инициализация координаты y.
            this.price = price;
            this.speed = speed;
            this.year = year;
        }

        public virtual void ShowInfo()// Виртуальный метод ShowInfo для отображения информации о транспортном средстве.
        {
            Console.WriteLine("Тип: " + GetType().Name);// Выводим тип транспортного средства (название класса).
            Console.WriteLine("Координаты: (" + x + ", " + y + ")");// Выводим координаты транспортного средства.
            Console.WriteLine($"Цена: {price:F2}");// Выводим цену транспортного средства с двумя знаками после запятой.
            Console.WriteLine("Скорость: " + speed + " км/ч");// Выводим скорость транспортного средства в км/ч.
            Console.WriteLine("Год выпуска: " + year);// Выводим год выпуска транспортного средства.
        }
    }

}
