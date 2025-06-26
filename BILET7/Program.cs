using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    internal class Program
    {
        static void Main(string[] args) // Главная функция, с которой начинается выполнение программы, принимает аргументы командной строки (не используются здесь).
        {
            Invoice invoice = new Invoice(123456, "Иван Иванов", "ООО Поставщик"); // Создаем объект класса Invoice с номером 123456, покупателем "Иван Иванов" и поставщиком "ООО Поставщик".

            invoice.SetOrder("Ноутбук", 5); // Устанавливаем заказ: товар "Ноутбук" в количестве 5 единиц.

            Console.Write("Введите цену за единицу: "); // Выводим запрос на ввод цены за одну единицу товара.
            double price = Convert.ToDouble(Console.ReadLine()); // Считываем введенный текст, преобразуем в число с плавающей точкой (double) и сохраняем в переменную price.

            var (withVAT, withoutVAT) = invoice.CalculateCost(price); // Вызываем метод CalculateCost, передаем цену, получаем кортеж с стоимостью с НДС (withVAT) и без НДС (withoutVAT).

            Console.WriteLine($"Стоимость без НДС: {withoutVAT:F2}"); // Выводим стоимость без НДС с двумя знаками после запятой (F2).
            Console.WriteLine($"Стоимость с НДС: {withVAT:F2}"); // Выводим стоимость с НДС с двумя знаками после запятой (F2).
        }
    }
}
