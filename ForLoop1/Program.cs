﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int e = 1;
            while (e <= 5)
            {
                Console.WriteLine(e);
                e++;
            }
            Console.WriteLine();

            //forloop for looping through an array
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }

            Console.ReadLine();
        }
    }
}
