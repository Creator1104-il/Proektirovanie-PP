using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nomer6
{
    internal class Book
    {
        public string title = "Неизвестно";
        public string author;
        public int year;

        public void DisplayInfo()
        {
            Console.WriteLine($"Название: {title}, Автор: {author}, Год: {year}");
        }
    }
}
