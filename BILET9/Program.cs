using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassRoom classRoom = new ClassRoom(// создание класса ClassRoom с учениками
                new ExcellentPupil("Иванов"),// создание класса ExcellentPupil
                new GoodPupil("Петров"),
                new BadPupil("Сидоров"),
                new GoodPupil("Козлов")
            );
            classRoom.ShowPupils();// вывод информации об учениках
        }
    }
}
