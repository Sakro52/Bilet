using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Car : Vehicle// Наследуем класс Car от Vehicle, что позволяет использовать все его свойства и методы.
    {
        public Car(int x, int y, double price, int speed, int year)
            : base(x, y, price, speed, year)// Вызываем конструктор базового класса Vehicle с параметрами x, y, price, speed и year.
        {
        }

        public override void ShowInfo()// Переопределяем метод ShowInfo для отображения информации об автомобиле.
        {
            base.ShowInfo();//  Вызываем базовую реализацию ShowInfo из Vehicle, чтобы получить общую информацию.
        }
    }
}
