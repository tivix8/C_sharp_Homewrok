using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Book__2 {
    internal class Program {
        static void Main(string[] args)
        {
            Book b = new Book();
            b.Title = "Преступление и наказание";
            b.Pages = 500;
            b.PrintInfo();
        }
    }
    public class Book {
        public string Title;
        private int _pages;
        public int Pages
        {
            get { return _pages; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Количество страниц должно быть не менее 1");
                }
                _pages = value;
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Книга: {Title}, страниц: {Pages}");
        }
    }
}
