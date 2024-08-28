using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClassMethodChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //In this challenge, you'll use either Intellisense or learn.microsoft.com to find and call a method that returns the larger of two numbers.
            /* Code challenge: Implement a method of the Math class that returns 
             the larger of two numbers*/

            int firstValue = 500;
            int secondValue = 600;
            int largerValue;

            largerValue = Math.Max(firstValue, secondValue);
            Console.WriteLine(largerValue);
             
            Console.ReadLine();
        }
    }
}
