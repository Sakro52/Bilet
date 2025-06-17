using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILET_4_
{
    class Address // Класс Address — это как карточка с информацией об адресе.
    {
        private string index; // Поле для почтового индекса (например, "123456"). Приватное, чтобы защитить данные.
        private string country; // Поле для страны (например, "Россия").
        private string city; // Поле для города (например, "Москва").
        private string street; // Поле для улицы (например, "Ленина").
        private int house; // Поле для номера дома (например, 25). Int, так как это целое число.
        private int apartment; // Поле для номера квартиры (например, 12). Int, так как это целое число.

        // Свойство для индекса: можно получить и изменить значение.
        public string Index
        {
            get { return index; } // Возвращает значение индекса.
            set { index = value; } // Устанавливает новое значение для индекса (value — это то, что передали).
        }

        // Свойство для страны: можно получить и изменить.
        public string Country
        {
            get { return country; } // Возвращает название страны.
            set { country = value; } // Устанавливает новое значение для страны.
        }

        // Свойство для города: можно получить и изменить.
        public string City
        {
            get { return city; } // Возвращает название города.
            set { city = value; } // Устанавливает новое значение для города.
        }

        // Свойство для улицы: можно получить и изменить.
        public string Street
        {
            get { return street; } // Возвращает название улицы.
            set { street = value; } // Устанавливает новое значение для улицы.
        }

        // Свойство для номера дома: можно получить и изменить.
        public int House
        {
            get { return house; } // Возвращает номер дома.
            set { house = value; } // Устанавливает новое значение для номера дома.
        }

        // Свойство для номера квартиры: можно получить и изменить.
        public int Apartment
        {
            get { return apartment; } // Возвращает номер квартиры.
            set { apartment = value; } // Устанавливает новое значение для номера квартиры.
        }
    }
}
