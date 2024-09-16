using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlocks_and_Variable_scope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool flag = true;
            //int value = 0; 

            //if (flag)
            //{
            //    //int value = 10;
            //    Console.WriteLine($"Inside the code block: {value}");

            //}

            //value = 10;
            //Console.WriteLine($"Inside the code block: {value}");
            //Console.ReadLine();



            //int val1 = 5;

            //if (val1 > 0)
            //{
            //    int val2 = 6;
            //    val1 = val1 + val2;
            //}

            //Console.WriteLine(val1);
            //Console.ReadLine();




            //bool flag = true;
            //if (flag) Console.WriteLine(flag);

            /*Variable scope challenge
             *fix the poorly written code sample provided            
             */
            int[] numbers = { 4, 8, 15, 16, 23, 42 };
            int total = 0;
            bool found = false;
            

            foreach (int number in numbers)
            {
                
                total += number;

                if (number == 42)
                {
                    found = true;
                    Console.WriteLine("Set contains 42");
                }
                
                    Console.WriteLine($"Total: {total}");
                

            }         



            Console.ReadLine();
        }
    }
}
