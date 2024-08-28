using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This code simulates a dice roll using the Random.Next()
            //method to generate a number, and the Console.WriteLine()
            //method to display the value.

            Random dices = new Random(); //Random in an instance of a class (object)
            int roll = dices.Next(1, 7);
            Console.WriteLine(roll);

            //notes
            // the Random.Next() method uses parameters to configure the upper
            // and lower boundaries of the return value. However, the
            // Console.WriteLine() uses the parameter directly by printing
            // the value to the console.


            //practice on overloaded methods
            //In this example, you're invoking three separate overloaded versions of the WriteLine() method.
            int number = 21;
            string text = "twenty one";
            Console.WriteLine(text);
            Console.WriteLine(number);
            Console.WriteLine();

            Random dice = new Random();
            int roll1 = dice.Next();
            int roll2 = dice.Next(101);
            int roll3 = dice.Next(50, 101);

            Console.WriteLine($"First roll: {roll1}");
            Console.WriteLine($"Second roll: {roll2}");
            Console.WriteLine($"Third roll: {roll3}");


            Console.ReadLine();
        }
    }
}
