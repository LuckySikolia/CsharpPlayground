using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i == 7) break;
            } 


            //Looping through each element of an array
            string[] names = { "Alex", "Eddie", "David", "Micheal" };
            for (int i = names.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine();


            for(int i  = 0; i < names.Length; i++)
            {
                if (names[i] == "David")
                {
                    names[i] = "Sammy";
                }
            }

            foreach(var name in names)
            {
                Console.WriteLine(name);
            }


            Console.ReadLine();
        }
    }
}
