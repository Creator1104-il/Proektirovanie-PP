using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomer5
{
    //Номер 1
    internal class Book
    {
        public string title = "Неизвестно";
        public int pages;

        public Book() { }
        public Book(string title, int pages) { 
            this.title = title;
            this.pages = pages;
        }

        public void getInfo() {
            Console.WriteLine($"Название: {title}, Страниц: {pages}");
        }
    }
}
