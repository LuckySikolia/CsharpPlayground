﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExponenetMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetPow(3, 2));
            Console.ReadLine();
        }

        static int GetPow(int baseNum, int powNum)
        {
            //what we want to do base num ^ pow num

            int result = 1;
            for (int i = 0; i < powNum; i++)
            {
                result = result * baseNum;
            }


            return result;
        }
    }
}
