using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class ClassRoom // Класс ClassRoom для управления списком учеников в классе.
    {
        private Pupil[] pupils; // Приватный массив для хранения объектов класса Pupil (учеников), размером до 4.

        public ClassRoom(Pupil p1, Pupil p2) // Конструктор для создания класса с двумя учениками.
        {
            pupils = new Pupil[4]; // Создаем массив из 4 мест для учеников.
            pupils[0] = p1; // Помещаем первого ученика в ячейку 0.
            pupils[1] = p2; // Помещаем второго ученика в ячейку 1.
            pupils[2] = null; // Оставляем ячейку 2 пустой (null).
            pupils[3] = null; // Оставляем ячейку 3 пустой (null).
        }

        public ClassRoom(Pupil p1, Pupil p2, Pupil p3) // Конструктор для создания класса с тремя учениками.
        {
            pupils = new Pupil[4]; // Создаем массив из 4 мест для учеников.
            pupils[0] = p1; // Помещаем первого ученика в ячейку 0.
            pupils[1] = p2; // Помещаем второго ученика в ячейку 1.
            pupils[2] = p3; // Помещаем третьего ученика в ячейку 2.
            pupils[3] = null; // Оставляем ячейку 3 пустой (null).
        }

        public ClassRoom(Pupil p1, Pupil p2, Pupil p3, Pupil p4) // Конструктор для создания класса с четырьмя учениками.
        {
            pupils = new Pupil[4]; // Создаем массив из 4 мест для учеников.
            pupils[0] = p1; // Помещаем первого ученика в ячейку 0.
            pupils[1] = p2; // Помещаем второго ученика в ячейку 1.
            pupils[2] = p3; // Помещаем третьего ученика в ячейку 2.
            pupils[3] = p4; // Помещаем четвертого ученика в ячейку 3.
        }

        public void ShowPupils() // Метод для отображения информации о всех учениках в классе.
        {
            int i; // Переменная для счетчика цикла.
            for (i = 0; i < pupils.Length; i++) // Цикл по всем элементам массива (0 до 3).
            {
                if (pupils[i] != null) // Проверяем, что в ячейке есть ученик (не null).
                {
                    Console.WriteLine($"\nУченик:{pupils[i].surname}"); // Выводим фамилию текущего ученика с новой строки.
                    pupils[i].Study(); // Вызываем метод Study для текущего ученика.
                    pupils[i].Read(); // Вызываем метод Read для текущего ученика.
                    pupils[i].Write(); // Вызываем метод Write для текущего ученика.
                    pupils[i].Relax(); // Вызываем метод Relax для текущего ученика.
                }
            }
        }
    }
}