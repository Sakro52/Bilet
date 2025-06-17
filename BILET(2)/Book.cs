using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILET_2_
{
    internal class Book
    {
        private Title title; // Переменная для хранения объекта  Title title
        private Author author; // Переменная для хранения объекта Author author
        private Content content; // Переменная для хранения объекта Content content

        public void SetTitle(Title title) // Метод для добавления названия книги.
        {
            this.title = title; // Сохраняем объект Title в переменную title.
        }

        public void SetAuthor(Author author) // Метод для добавления автора.
        {
            this.author = author; // Сохраняем объект Author в переменную author.
        }

        public void SetContent(Content content) // Метод для добавления содержания.
        {
            this.content = content; // Сохраняем объект Content в переменную content.
        }

        public void Show() // Метод для показа всей информации о книге.
        {
            if (title != null) title.Show(); // Если название задано, показываем его.
            if (author != null) author.Show(); // Если автор задан, показываем его.
            if (content != null) content.Show(); // Если содержание задано, показываем его.
        }
    }
}
