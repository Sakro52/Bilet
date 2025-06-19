using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILET15
{
    // Этот класс реализует интерфейс InterfaceC
    class MyClass : InterfaceC // Этот класс наследует и реализует интерфейс InterfaceC
    {
        // Реализация метода ShowInterfaceA из InterfaceA
        public void ShowInterfaceA() // Этот метод выводит текст для InterfaceA
        {
            Console.WriteLine("ShowInterfaceA() is completed."); // Это показывает "ShowInterfaceA() is completed." на экране
        }

        // Реализация метода ShowInterfaceB из InterfaceB
        public void ShowInterfaceB() // Этот метод выводит текст для InterfaceB
        {
            Console.WriteLine("ShowInterfaceB() is completed."); // Это показывает "ShowInterfaceB() is completed." на экране
        }
        public void ShowInterfaceC() // Этот метод выводит текст для InterfaceB
        {
            Console.WriteLine("ShowInterfaceC() is completed."); // Это показывает "ShowInterfaceC() is completed." на экране
        }
    }
}