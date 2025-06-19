using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILET13
{
    abstract class AbstractHandler // Абстрактный базовый класс для обработки документов.
    {
        public abstract void Open(); // Абстрактный метод для открытия документа.
        public abstract void Create(); // Абстрактный метод для создания документа.
        public abstract void Change(); // Абстрактный метод для редактирования документа.
        public abstract void Save(); // Абстрактный метод для сохранения документа.
    }

    class XMLHandler : AbstractHandler // Производный класс для работы с XML-документами.
    {
        public override void Open() // Переопределяем метод открытия.
        {
            Console.WriteLine("XML документ открыт"); // Выводим сообщение.
        }

        public override void Create() // Переопределяем метод создания.
        {
            Console.WriteLine("XML документ создан"); // Выводим сообщение.
        }

        public override void Change() // Переопределяем метод редактирования.
        {
            Console.WriteLine("XML документ отредактирован"); // Выводим сообщение.
        }

        public override void Save() // Переопределяем метод сохранения.
        {
            Console.WriteLine("XML документ сохранен"); // Выводим сообщение.
        }
    }

    class TXTHandler : AbstractHandler // Производный класс для работы с TXT-документами.
    {
        public override void Open() // Переопределяем метод открытия.
        {
            Console.WriteLine("TXT документ открыт"); // Выводим сообщение.
        }

        public override void Create() // Переопределяем метод создания.
        {
            Console.WriteLine("TXT документ создан"); // Выводим сообщение.
        }

        public override void Change() // Переопределяем метод редактирования.
        {
            Console.WriteLine("TXT документ отредактирован"); // Выводим сообщение.
        }

        public override void Save() // Переопределяем метод сохранения.
        {
            Console.WriteLine("TXT документ сохранен"); // Выводим сообщение.
        }
    }

    class DOCHandler : AbstractHandler // Производный класс для работы с DOC-документами.
    {
        public override void Open() // Переопределяем метод открытия.
        {
            Console.WriteLine("DOC документ открыт"); // Выводим сообщение.
        }

        public override void Create() // Переопределяем метод создания.
        {
            Console.WriteLine("DOC документ создан"); // Выводим сообщение.
        }

        public override void Change() // Переопределяем метод редактирования.
        {
            Console.WriteLine("DOC документ отредактирован"); // Выводим сообщение.
        }

        public override void Save() // Переопределяем метод сохранения.
        {
            Console.WriteLine("DOC документ сохранен"); // Выводим сообщение.
        }
    }
}
