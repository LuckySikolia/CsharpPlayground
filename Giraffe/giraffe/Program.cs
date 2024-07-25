using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            //code on how to create a shape
            Console.WriteLine("      /\\");
            Console.WriteLine("     /  \\");
            Console.WriteLine("    /    \\");
            Console.WriteLine("   /      \\");
            Console.WriteLine("  /  0   o \\");
            Console.WriteLine(" /     3    \\");
            Console.WriteLine("/_ _ _ _ _ _ \\");

            //add a blank line
            Console.WriteLine();

            //code on variables using a story
            string firstName = "Johnson";
            int characterAge;
            characterAge= 45;
            Console.WriteLine("There once was a man named " + firstName);
            Console.WriteLine("He was " + characterAge + " years old");
            firstName = "Kaleb";
            Console.WriteLine("He really liked the name " + firstName);
            Console.WriteLine("But he didn't like being " + characterAge);

            //add a blank line
            Console.WriteLine();

            //code on working with strings
            Console.WriteLine("giraffe \n Academy");
            Console.WriteLine("giraffe Academy" + " is cool");

            string phrase = "Sun goes down, stars come up";
            Console.WriteLine(phrase.Length);
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.Contains("up"));
            Console.WriteLine(phrase.Contains("UP"));
            Console.WriteLine(phrase[0]);
            Console.WriteLine(phrase[5]);
            Console.WriteLine(phrase.IndexOf("goes"));
            Console.WriteLine(phrase.IndexOf("down"));
            Console.WriteLine(phrase.IndexOf("stars"));
            Console.WriteLine(phrase.Substring(8, 4));


            //add a blank line
            Console.WriteLine();
            Console.WriteLine();


            //code on working with numbers
            Console.WriteLine();
            Console.WriteLine( 5 + 5);
            Console.WriteLine(5%2);
            Console.WriteLine(5 / 2);
            Console.WriteLine(4 + 2 * 3);
            Console.WriteLine((4 + 2) * 3);
            Console.WriteLine(5.0 + 8.1);
            int num = 6;
            num++;
            Console.WriteLine(num);
            num--;
            Console.WriteLine(num);

            Console.WriteLine();
            Console.WriteLine(Math.Abs(-40));
            Console.WriteLine(Math.Pow(3, 2));

            //add a blank line
            Console.WriteLine();
            Console.WriteLine();
            //add a blank line
            Console.WriteLine();
            Console.WriteLine();

            //CODE FOR GETTING USER INPUT
            //Console.WriteLine("Hello");
            Console.WriteLine(5 / 10);
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello and welcome Mrs " + name);

            Console.WriteLine("windows " + 7 + 4);
            Console.WriteLine($"Windows {1 + 1}");
            Console.WriteLine("Windows " + 1 + 1);

            int result = 3 + 1 * 5 / 2;
            Console.WriteLine(result);


            Console.ReadLine();
        }
    }
}
