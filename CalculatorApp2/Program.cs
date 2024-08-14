using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //get information from the user
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter a number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            
            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            }else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }else
            {
                Console.WriteLine("invalid operator!");
            }

            Console.ReadLine();
        }

        //Build a flour function calculator
    }
}
