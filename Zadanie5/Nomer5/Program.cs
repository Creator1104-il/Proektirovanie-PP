using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomer5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Номер 1
            printLnBlue("1");
            Book book1 = new Book("Война и мир", 1200);
            Book book2 = new Book("1984", 300);
            Book book3 = new Book();
            book3.pages = 500;

            book1.getInfo();
            book2.getInfo();
            book3.getInfo();

            printLnBlue("2");
            Student s1 = new Student();           
            Student s2 = new Student("Мария");      
            Student s3 = new Student("Алексей", 22);

            s1.PrintInfo();
            s2.PrintInfo();
            s3.PrintInfo();

            printLnBlue("3");
            Car car1 = new Car
            {
                brand = "Toyota",
                model = "Camry",
                year = 2015
            };

            Car car2 = new Car
            {
                brand = "BMW",
                model = "X5",
                year = 2025
            };

            Car car3 = new Car
            {
                brand = "Lada",
                model = "Vesta"
            };

            car1.PrintInfo();
            car2.PrintInfo();
            car3.PrintInfo();

            printLnBlue("4");
            Triangle t1 = new Triangle(3, 4, 5);
            Triangle t2 = new Triangle(1, 2, 4);

            t1.PrintSides();
            Console.WriteLine($"Треугольник валиден? {t1.IsValid()}");

            t2.PrintSides();
            Console.WriteLine($"Треугольник валиден? {t2.IsValid()}");

            printLnBlue("5");
            Point p1 = new Point(10, 20);

            (int x1, int y1) = p1;
            Console.WriteLine($"Точка 1: X = {x1}, Y = {y1}");

            Point p2 = new Point(5, 7);

            (_, int y2) = p2;
            Console.WriteLine($"Точка 2: Игнорируем X, Y = {y2}");

        }

        static void printLnBlue(string s) { 
            ConsoleColor a = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(s);
            Console.ForegroundColor = a;

        }
    }
}
