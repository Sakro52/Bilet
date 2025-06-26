using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class BadPupil : Pupil// Класс BadPupil наследуется от абстрактного класса Pupil и реализует его методы.
    {
        public BadPupil(string surname) : base(surname) { }// Конструктор BadPupil принимает фамилию и передает ее в базовый класс Pupil.

        public override void Study()// Переопределяем метод Study для BadPupil.
        {
            Console.WriteLine(surname + " учится плохо!");
        }

        public override void Read()// Переопределяем метод Read для BadPupil.
        {
            Console.WriteLine(surname + " читает медленно!");
        }

        public override void Write()//  Переопределяем метод Write для BadPupil.
        {
            Console.WriteLine(surname + " пишет с ошибками!");
        }

        public override void Relax()// Переопределяем метод Relax для BadPupil.
        {
            Console.WriteLine(surname + " отдыхает, смотря телевизор!");
        }
    }
}
