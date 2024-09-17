using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int current = rnd.Next(1, 11);

            do
            {
                current = rnd.Next(1, 11);
                
                if(current >= 8)
                {
                    continue;
                }
                Console.WriteLine(current);
                //Console.ReadLine();
            } while (current != 7);

            //while(current >= 3)
            //{
            //    Console.WriteLine(current);
            //    current = rnd.Next(1, 11);
            //}
            //Console.WriteLine($"Last number: {current}");


            Console.ReadLine();
        }

       
    }
}
