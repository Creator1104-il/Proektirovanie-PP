using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomer5
{
    internal class Student
    {
        public string Name;
        public int Age;

        public Student() : this("Иван", 18)
        {
        }

        public Student(string name) : this(name, 18)
        {
          
        }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Имя: {Name}, Возраст: {Age}");
        }
    }
}
