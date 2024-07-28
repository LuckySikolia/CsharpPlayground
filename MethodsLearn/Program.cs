using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MethodsLearn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayHi();
            foodName("fries", 34);
            foodName("Chips", 90);
            Console.ReadLine();
        }

        //create a method that says hey to the user
        static void SayHi()
        {
            Console.Write("What is your name? ");
            string myName;
            myName = Console.ReadLine();
            Console.WriteLine($"Hello, and welcome back {myName}");
            
        }

        static void foodName(string food, int amount)
        {
            Console.WriteLine("Input a complementary snack: " + food + amount);
        }
    }
}
