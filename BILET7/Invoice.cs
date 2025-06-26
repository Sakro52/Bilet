using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Invoice // Класс Invoice для управления данными о счете-фактуре.
    {
        private readonly int account; // Приватное поле для номера счета, доступное только для чтения (не изменяется после создания).
        private readonly string customer; // Приватное поле для имени покупателя, доступное только для чтения.
        private readonly string provider; // Приватное поле для имени поставщика, доступное только для чтения.
        private string article; // Приватное поле для наименования товара, может изменяться.
        private int quantity; // Приватное поле для количества товара, может изменяться.

        public Invoice(int account, string customer, string provider) // Конструктор класса, принимает номер счета, имя покупателя и поставщика.
        {
            this.account = account; // Присваиваем переданный номер счета полю account.
            this.customer = customer; // Присваиваем переданное имя покупателя полю customer.
            this.provider = provider; // Присваиваем переданное имя поставщика полю provider.
        }

        public void SetOrder(string article, int quantity) // Метод для установки данных о заказе (наименование товара и количество).
        {
            this.article = article; // Присваиваем переданное наименование товара полю article.
            this.quantity = quantity; // Присваиваем переданное количество полю quantity.
        }

        public (double withVAT, double withoutVAT) CalculateCost(double pricePerUnit) // Метод для расчета стоимости с НДС и без НДС, возвращает кортеж.
        {
            double withoutVAT = pricePerUnit * quantity; // Рассчитываем общую стоимость без НДС, умножая цену за единицу на количество.
            double withVAT = withoutVAT * 1.20; // Рассчитываем стоимость с НДС, умножая стоимость без НДС на 1.20 (20% НДС).
            return (withVAT, withoutVAT); // Возвращаем кортеж с стоимостью с НДС и без НДС.
        }
    }
}