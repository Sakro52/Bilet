using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILET11
{
    class DocumentWorker // Базовый класс для работы с документами (бесплатная версия).
    {
        public virtual void OpenDocument() // Виртуальный метод для открытия документа.
        {
            Console.WriteLine("Документ открыт"); // Выводим сообщение о том, что документ открыт.
        }

        public virtual void EditDocument() // Виртуальный метод для редактирования документа.
        {
            Console.WriteLine("Редактирование документа доступно в версии Про"); // Сообщаем, что редактирование только в Pro.
        }

        public virtual void SaveDocument() // Виртуальный метод для сохранения документа.
        {
            Console.WriteLine("Сохранение документа доступно в версии Про"); // Сообщаем, что сохранение только в Pro.
        }
    }

    class ProDocumentWorker : DocumentWorker // Производный класс для Pro-версии, наследуется от DocumentWorker.
    {
        public override void OpenDocument() // Переопределяем метод открытия документа.
        {
            base.OpenDocument(); // Вызываем метод базового класса (выводит "Документ открыт").
        }

        public override void EditDocument() // Переопределяем метод редактирования.
        {
            Console.WriteLine("Документ отредактирован"); // Выводим сообщение об успешном редактировании.
        }

        public override void SaveDocument() // Переопределяем метод сохранения.
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт"); // Сообщаем о сохранении в старом формате.
        }
    }

    class ExpertDocumentWorker : ProDocumentWorker // Производный класс для Expert-версии, наследуется от ProDocumentWorker.
    {
        public override void SaveDocument() // Переопределяем только метод сохранения.
        {
            Console.WriteLine("Документ сохранен в новом формате"); // Выводим сообщение о сохранении в новом формате.
        }
    }
}
