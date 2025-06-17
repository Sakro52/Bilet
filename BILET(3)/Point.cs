using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILET_3_
{
     class Point // Класс Point — это точка на плоскости с координатами и названием.
     {
         private int x; // Переменная для координаты X. Приватная, чтобы никто не мог её случайно изменить.
         private int y; // Переменная для координаты Y. Тип int для целых чисел.
         private string name; // Переменная для названия точки (например, "A"). Приватная для защиты.

         public Point(int x, int y, string name) // Конструктор, чтобы создать точку с координатами и названием.
         {
            this.x = x; // Сохраняем координату X.
            this.y = y; // Сохраняем координату Y.
            this.name = name; // Сохраняем название точки.
         }

         public int X // Свойство, чтобы узнать координату X, но не менять её.
         {
            get { return x; } // Возвращает значение x.
         }

         public int Y // Свойство, чтобы узнать координату Y, но не менять её.
         {
            get { return y; } // Возвращает значение y.
         }

         public string Name // Свойство, чтобы узнать название точки, но не менять его.
         {
            get { return name; } // Возвращает значение name.
         }
     }
}

