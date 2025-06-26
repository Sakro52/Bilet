using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class GoodPupil : Pupil// Класс GoodPupil наследуется от абстрактного класса Pupil и реализует его методы.
    {
        public GoodPupil(string surname) : base(surname) { }// Конструктор GoodPupil принимает фамилию и передает ее в базовый класс Pupil.

        public override void Study()// Переопределяем метод Study для GoodPupil.
        {
            Console.WriteLine(surname + " учится хорошо!");
        }

        public override void Read()  // Переопределяем метод Read для GoodPupil.
        {
            Console.WriteLine(surname + " читает в хорошем темпе!");
        }

        public override void Write()// Переопределяем метод Write для GoodPupil.
        {
            Console.WriteLine(surname + " пишет правильно!");
        }

        public override void Relax()// Переопределяем метод Relax для GoodPupil.
        {
            Console.WriteLine(surname + " отдыхает, занимаясь спортом!");
        }
    }
}
