using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT4 {
    internal class Program {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.DisplayInfo();
            Book book1 = new Book("Книга 1", "Автор1");
            book1.DisplayInfo();
            Book book2 = new Book("Книга2", "Автор2", 2023);
            book2.DisplayInfo();
        }
    }

    public class Book
    {
        public string Title;
        public string Author;
        public int Year;

        public Book()
        {
            Title = "Неизвестно";
            Author = "Неизвестно";
            Year = 2025;
        }

        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            Year = 2024;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, Year: {Year}");
        }

    }
}
