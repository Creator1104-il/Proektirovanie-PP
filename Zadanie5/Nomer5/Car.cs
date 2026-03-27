using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomer5
{
    internal class Car
    {
        public string brand = "Unknown";
        public string model = "Unknown";
        public int year = 2000;
        public Car()
        {
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Марка: {brand}, Модель: {model}, Год: {year}");
        }
    }
}
