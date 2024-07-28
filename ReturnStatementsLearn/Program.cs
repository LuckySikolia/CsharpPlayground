using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnStatementsLearn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            //the void keyword in all examples, which indicates that the method should not return a value.
            //If you want the method to return a value, you can use a primitive data type(such as int or double)
            //instead of void, and use the return keyword inside the method

            CubeNumber();
            Console.WriteLine(cube(45));

            int num1 = cubeM(4);
            decimal num2 = cubeM(9.5m);

            Console.WriteLine($"Int: " + num1);
            Console.WriteLine($"Decimal: " + num2);
            Console.ReadLine();
            

        }

        //method to cube a number
        static decimal CubeNumber()
        {
            Console.Write("Enter a number: ");
            string myNumber = Console.ReadLine();
            decimal myNum = Convert.ToDecimal(myNumber);
            

            decimal cubed = myNum * myNum * myNum;
            Console.WriteLine($"The Cubed number is: {cubed}");

            return cubed;
        }

        

        static int cube (int num)
        {
            int result = num * num * num;
            return result;
        }

        //method overloading for cubeM

        static int cubeM (int n)
        {
            return n * n * n;
        }

        static decimal cubeM(decimal n)
        {
            return n * n * n;
        }

    }
}
