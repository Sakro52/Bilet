using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILET_1_
{
        class Rectangle // Создаем класс Rectangle — это как чертеж для прямоугольника, где мы храним его данные и функции.
        {
            private double side1; // Переменная для хранения длины первой стороны. Private значит, что её нельзя менять напрямую снаружи класса.
            private double side2; // Переменная для хранения длины второй стороны. Double — это тип для чисел с дробной частью (например, 5.5).

            public Rectangle(double side1, double side2) // Это конструктор — специальная функция, которая запускается, когда создаем прямоугольник.
            {
                this.side1 = side1; // Сохраняем первую сторону в переменную side1. "this" помогает отличить переменную класса от параметра.
                this.side2 = side2; // Сохраняем вторую сторону в переменную side2.
            }
        public double AreaCalculator() // Функция для подсчета площади прямоугольника.
        {
            return side1 * side2; // Площадь = длина * ширина, поэтому умножаем side1 на side2 и возвращаем результат.
        }

        public double PerimeterCalculator() // Функция для подсчета периметра прямоугольника.
        {
            return 2 * (side1 + side2); // Периметр = 2 * (длина + ширина), поэтому складываем стороны, умножаем на 2 и возвращаем.
        }

        public double Area // Это свойство, чтобы получить площадь без возможности её изменить.
        {
            get { return AreaCalculator(); } // Возвращает результат функции AreaCalculator, чтобы узнать площадь.
        }

        public double Perimeter // Это свойство, чтобы получить периметр без возможности его изменить.
        {
            get { return PerimeterCalculator(); } // Возвращает результат функции PerimeterCalculator, чтобы узнать периметр.
        }
    }

}
    
