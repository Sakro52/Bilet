using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILET15
{
    internal class Program
    {
        static void Main(string[] args) // Это точка входа в программу
        {
            MyClass myClassOb = new MyClass(); // Это создает новый объект MyClass для использования его методов

            myClassOb.ShowInterfaceA(); // Это вызывает метод для вывода текста из InterfaceA
            myClassOb.ShowInterfaceB(); // Это вызывает метод для вывода текста из InterfaceB
            myClassOb.ShowInterfaceC(); // Это вызывает метод для вывода текста из InterfaceC
        }
    }
}
