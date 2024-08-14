using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_methods_and_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Sqrt(144));

            UsefulTools.SayHi("mIKE");

            Console.ReadLine();
        }
    }
}
