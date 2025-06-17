using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILET_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название книги:"); // Просим ввести название книги.
            string titleInput = Console.ReadLine(); // Считываем введенный текст.
            Title bookTitle = new Title(titleInput); // Создаем объект Title с введенным названием.

            Console.WriteLine("Введите имя автора:"); // Просим ввести имя автора.
            string authorInput = Console.ReadLine(); // Считываем введенный текст.
            Author bookAuthor = new Author(authorInput); // Создаем объект Author с введенным именем.

            Console.WriteLine("Введите краткое содержание книги:"); // Просим ввести содержание.
            string contentInput = Console.ReadLine(); // Считываем введенный текст.
            Content bookContent = new Content(contentInput); // Создаем объект Content с введенным содержанием.

            Book book = new Book(); // Создаем объект Book.
            book.SetTitle(bookTitle); // Добавляем название в книгу.
            book.SetAuthor(bookAuthor); // Добавляем автора в книгу.
            book.SetContent(bookContent); // Добавляем содержание в книгу.

            Console.WriteLine("\nИнформация о книге:"); // Выводим заголовок.
            book.Show(); // Показываем информацию о книге (название, автор, содержание) разными цветами.

            Console.ReadKey(); // Ждем нажатия клавиши, чтобы консоль не закрылась.
        }
    }
}
    
