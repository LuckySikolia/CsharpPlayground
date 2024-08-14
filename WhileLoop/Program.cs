using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int index = 1;

            while (index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }

            Console.ReadLine();
        }
    }
}
