using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //calculator app that accepts user input and calculates the sum of the numbers
            //converting a string into a number
            Console.Write("Enter number: ");
            string num1 = Console.ReadLine();
            int numm1 = int.Parse(num1);

           
            Console.Write("Enter second number: ");
            string num2 = Console.ReadLine();
            double numm2 = double.Parse(num2);

                    
            Console.WriteLine();
            //calculate the sum
            double numSum = numm1 + numm2;
            Console.WriteLine($"If it works the sum is: {numSum}");


            Console.ReadLine();

        }
    }
}
