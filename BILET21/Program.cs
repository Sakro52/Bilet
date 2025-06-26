using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    internal class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";
        }

        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.change = "изменено";
        }

        static void Main(string[] args)
        {
            try
            {
                MyClass myClass = new MyClass();
                myClass.change = "не изменено";
                MyStruct myStruct = new MyStruct();
                myStruct.change = "не изменено";

                Console.WriteLine("До вызова методов:");
                Console.WriteLine("Класс: " + myClass.change);
                Console.WriteLine("Структура: " + myStruct.change);

                ClassTaker(myClass);
                StruktTaker(myStruct);

                Console.WriteLine("\nПосле вызова методов:");
                Console.WriteLine("Класс: " + myClass.change); // Изменится
                Console.WriteLine("Структура: " + myStruct.change); // Не изменится
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
        }
    }
}
