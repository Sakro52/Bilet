using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILET_5_
{
    class Converter // Класс Converter — это как калькулятор для конвертации валют.
    {
        private double usd; // Поле для курса USD к BYN (например, 3.2 BYN за 1 USD).
        private double eur; // Поле для курса EUR к BYN (например, 3.5 BYN за 1 EUR).
        private double rub; // Поле для курса RUB к BYN (например, 0.035 BYN за 1 RUB).

        public Converter(double usd, double eur, double rub) // Конструктор, чтобы задать курсы валют.
        {
            this.usd = usd; // Сохраняем курс USD.
            this.eur = eur; // Сохраняем курс EUR.
            this.rub = rub; // Сохраняем курс RUB.
        }

        // Метод для конвертации из BYN в указанную валюту.
        public double ConvertFromBYN(double amount, string currency)
        {
            switch (currency.ToLower()) // Проверяем валюту, игнорируя регистр букв.
            {
                case "usd": // Если выбрали USD.
                    return amount / usd; // Делим сумму в BYN на курс USD, чтобы получить USD.
                case "eur": // Если выбрали EUR.
                    return amount / eur; // Делим сумму в BYN на курс EUR, чтобы получить EUR.
                case "rub": // Если выбрали RUB.
                    return amount / rub; // Делим сумму в BYN на курс RUB, чтобы получить RUB.
                default: // Если валюта не поддерживается.
                    Console.WriteLine("Ошибка! Выберите USD, EUR или RUB.");
                    return 0; // Возвращаем 0 при ошибке.
            }
        }

        // Метод для конвертации из указанной валюты в BYN.
        public double ConvertToBYN(double amount, string currency)
        {
            switch (currency.ToLower()) // Проверяем валюту, игнорируя регистр букв.
            {
                case "usd": // Если выбрали USD.
                    return amount * usd; // Умножаем сумму в USD на курс USD, чтобы получить BYN.
                case "eur": // Если выбрали EUR.
                    return amount * eur; // Умножаем сумму в EUR на курс EUR, чтобы получить BYN.
                case "rub": // Если выбрали RUB.
                    return amount * rub; // Умножаем сумму в RUB на курс RUB, чтобы получить BYN.
                default: // Если валюта не поддерживается.
                    Console.WriteLine("Ошибка! Выберите USD, EUR или RUB.");
                    return 0; // Возвращаем 0 при ошибке.
            }
        }
    }
}
