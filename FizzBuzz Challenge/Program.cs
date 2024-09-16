using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*FizzBuzz is a popular coding challenge and interview question. It exercises your underestanding 
             of the for statement, the if statement and the %remainder operator and your command of basic logic
            The rules
                1. Output values form 1 to 100, one number per line inside the code block of an iteration statement
                2. When the current value is divisible by 3, print the term Fizz next to the number
                3. When the current value is divisible by 5, print the term Buzz next to the number
                4. When the current value is divisible by both 3 and 5 print the term FizzBuzz next to the number
            */

            for (int i = 0; i <= 100; i++)
            {
                if (i == 0)
                {
                    continue;
                }
                else if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine($"{i} - FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine($"{i} - Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine($"{i} - Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }

               
            }

            Console.ReadLine();


        }
    }
}
