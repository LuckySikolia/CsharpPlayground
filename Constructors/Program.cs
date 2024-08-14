using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Book books1 = new Book("Harry Poter", "JK Rowling", 400);
            

            Book books2 = new Book("Kidagaa Kimemwozea", "Ken Walibora", 360);
            books2.title = "The river and the source";

            Book books3 = new Book();
            
            Console.WriteLine();
            Console.WriteLine(books1.title);
            Console.WriteLine(books1.author);
            Console.WriteLine(books1.pages);
            Console.WriteLine();

            Console.WriteLine(books2.title);
            Console.WriteLine(books2.author);
            Console.WriteLine(books2.pages);
            Console.WriteLine();


            Console.ReadLine();
        }
    }
}
