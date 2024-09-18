using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Intatke_Automation_Form
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* //CODE 1 WORKS
             //instantiate the array
             //string[] values = {"12.3", "45", "ABC", "11", "DEF" };
             //string message = ""; //to store the concatenated message
             //double total = 0;

             //for (int i = 0; i < values.Length; i++)
             //{
             //    if (values[i].All(char.IsLetter)) //checks of the string contains only letters
             //    {
             //        message += values[i]; //concatenate the alphabetic value
             //    }
             //    else if (values[i].All(char.IsDigit) || values[i].Contains('.'))
             //    {
             //        total += Convert.ToDouble(values[i]);
             //    }
             //}
             //Console.WriteLine($"Message: {message}");
             //Console.WriteLine($"Total: {total}");*/


            //CODE 2:PRACTICE

            //initialize
            int value1 = 11;
            decimal value2 = 6.2m;
            float value3 = 4.3f;


            // Your code here to set result1
            // Hint: You need to round the result to nearest integer (don't just truncate)
            int result1 = 0;
            decimal resultd1 = value1 / value2;
            result1 = (int)Math.Round(resultd1);

            Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

            // Your code here to set result2
            decimal result2 = 0;
            result2 = value2 / Convert.ToDecimal(value3);
            Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

            // Your code here to set result3
            float result3 = 0;
            result3 = value3 / Convert.ToSingle(value1);  
            Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");





            Console.ReadLine();

        }
    }
}
