using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLbsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*building a madlib game*/

            //decalre variables

            string noun1, pluralNoun1, pluralNoun2, verbPT1, verbPT2, bodyPartPlural, adjective1, adjective2;

            Console.Write("Enter a noun: ");
            noun1 = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            pluralNoun1 = Console.ReadLine();

            Console.Write("Enter a verb (present tense): ");
            verbPT1 = Console.ReadLine();

            Console.Write("Enter another verb(present tense): ");
            verbPT2 = Console.ReadLine();

            Console.Write("Enter a part of a body (plural): ");
            bodyPartPlural = Console.ReadLine();

            Console.Write("Enter a adjective: ");
            adjective1 = Console.ReadLine();

            Console.Write("Enter another plural noun: ");
            pluralNoun2 = Console.ReadLine();

            Console.Write("Enter another adjective: ");
            adjective2 = Console.ReadLine();




            //The story outline
            Console.WriteLine();
            Console.Write($"Today, every student has a computer small enough to fit into his {noun1}. He can solve any math problem" +
                $" by simply pushing the computer's little {pluralNoun1}. Computer can add, multiply, divide and  {verbPT1}. They can also {verbPT2}" +
                $" better than a human. Some Computers are {bodyPartPlural}. Others have a/an {adjective1} screen that shows all kinds of {pluralNoun2} and {adjective2} " +
                $" figures.");

            Console.ReadLine();

        }
    }
}
