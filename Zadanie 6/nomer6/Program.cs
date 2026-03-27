using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nomer6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1");
            Book book = new Book();
            book.title = "Мастер и Маргарита";
            book.author = "Михаил Булгаков";
            book.year = 1967;

            book.DisplayInfo();
            Console.WriteLine($"Название: {book.title}");
            Console.WriteLine($"Автор: {book.author}");
            Console.WriteLine($"Год: {book.year}");

            Console.WriteLine("\n2");
            BankAccaunt account = new BankAccaunt();
            account.accountNumber = "12345";
            account.Deposit(500);  
            account.Withdraw(200);  
            account.Withdraw(400);

            Console.WriteLine("\n3");
            Point p1 = new Point();  

            p1.X = 10; p1.Y = 20;
            p1.PrintCoordinates();
            Point p2;
            
            p2.X = 5; p2.Y = -3; 
            
            p2.PrintCoordinates();  

            p1.Move(5, -3);
            p1.PrintCoordinates();  
        }

       
    }
}
