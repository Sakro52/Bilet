using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class ExcellentPupil : Pupil// Класс ExcellentPupil наследуется от абстрактного класса Pupil и реализует его методы.
    {
        public ExcellentPupil(string surname) : base(surname) { }// Конструктор ExcellentPupil принимает фамилию и передает ее в базовый класс Pupil.

        public override void Study()//  Переопределяем метод Study для ExcellentPupil.
        {
            Console.WriteLine(surname + " учится отлично!");
        }

        public override void Read()// Переопределяем метод Read для ExcellentPupil.
        {
            Console.WriteLine(surname + " читает быстро и всё понимает!");
        }

        public override void Write()//  Переопределяем метод Write для ExcellentPupil.
        {
            Console.WriteLine(surname + " пишет аккуратно и точно!");
        }

        public override void Relax()// Переопределяем метод Relax для ExcellentPupil.
        {
            Console.WriteLine(surname + " отдыхает, решая головоломки!");
        }
    }
}
