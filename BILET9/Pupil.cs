using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    abstract class Pupil// Абстрактный класс Pupil, который будет служить базовым классом для учеников.
    {
        public string surname;// Поле для хранения фамилии ученика.

        public Pupil(string surname)// Конструктор класса Pupil, который принимает фамилию ученика и инициализирует поле surname.
        {
            this.surname = surname;// Присваиваем значение параметра surname полю класса.
        }

        public abstract void Study();// Абстрактные методы, которые должны быть реализованы в наследуемых классах.
        public abstract void Read(); 
        public abstract void Write();
        public abstract void Relax(); // Метод Relax, который будет реализован в наследуемых классах.
    }
}
