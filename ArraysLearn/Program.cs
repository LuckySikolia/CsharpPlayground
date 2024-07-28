using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysLearn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //arrays allowa us to hold multiple pieces of information in one container.

            //creating an array
            //method 1
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };

            //update element 8
            luckyNumbers[1] = 900;

            //method 2
            string[] friends = new string[3];
            friends[0] = "gin";
            friends[1] = "kelly";
            friends[2] = "kim";
            

            Console.WriteLine(friends[1]);

            //accessing arrays
            Console.WriteLine(luckyNumbers[1]);

            Console.ReadLine();
        }
    }
}
