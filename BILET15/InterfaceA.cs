using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILET15
{
    // Этот интерфейс определяет метод для InterfaceA
    interface InterfaceA // Это интерфейс A
    {
        void ShowInterfaceA(); // Этот метод будет выводить текст для InterfaceA
    }

    // Этот интерфейс определяет метод для InterfaceB
    interface InterfaceB // Это интерфейс B
    {
        void ShowInterfaceB(); // Этот метод будет выводить текст для InterfaceB
    }

    // Этот интерфейс объединяет InterfaceA и InterfaceB через множественное наследование
    interface InterfaceC : InterfaceA, InterfaceB // Это интерфейс C, который наследует оба интерфейса
    {
    }
}
