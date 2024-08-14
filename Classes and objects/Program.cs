using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating an object - ie an instance of a class
            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            Book book2 = new Book();
            book2.title = "Lord of the Rings";
            book2.author = "Tolkein";
            book2.pages = 360;

            Console.WriteLine(book1.title);
            Console.WriteLine(book1.pages);
            Console.WriteLine(book1.author);
            Console.WriteLine();

            Console.WriteLine(book2.title);
            Console.WriteLine(book2.pages);
            Console.WriteLine(book2.author);

            Console.ReadLine();
        }
    }
}
