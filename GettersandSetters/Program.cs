using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettersandSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Movies avengers = new Movies("The Avengers", "Joss Whedon", "PG-13");
            Movies shrek = new Movies("Shrek", "Adam Adamson", "Dog");

            //ratings G, PG, PG-13, R, NR

            Console.WriteLine(avengers.Rating);
            Console.WriteLine(shrek.Rating);  //prints out NR because it is invalid

            Console.ReadLine();
        }
    }
}
