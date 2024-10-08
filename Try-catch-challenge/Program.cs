﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_catch_challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Process1();
            }
            catch
            {
                Console.WriteLine("An exception has occurred");
            }

            Console.WriteLine("Exit program");

            Console.ReadLine();
        }

        static void Process1()
        {
            try
            {
                WriteMessage();
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine($"Exception caught in Process1: {ex.Message}");
            }
            
        }

        static void WriteMessage()
        {
            double float1 = 3000.0;
            double float2 = 0.0;
            int number1 = 3000;
            int number2 = 0;
            byte smallNumber;

            Console.WriteLine(float1 / float2);
            Console.WriteLine(number1 / number2);
            checked
            {
                try
                {
                    smallNumber = (byte)number1;
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine($"Exception caught in Process1: {ex.Message}");
                }
            }

        }
    }
}
