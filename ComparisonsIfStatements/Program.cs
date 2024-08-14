using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparisonsIfStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(GetMax(22, 9, 1));
            //Console.WriteLine(GetMax(22, 129, 1));
            Console.WriteLine(GetMax(22, 9, 481));


            Console.ReadLine();
        }
        //build a method to get max 

        static int GetMax(int num1, int num2, int num3)
        {
            int result;

            if (num1 > num2 && num1 > num3)
            {
                result = num1;
            } else if (num1 > num2 && num1 < num3)
            {
                result = num3;
            }
            else
            {
                result = num2;
            }
            

            return result;
        }
    }
}
