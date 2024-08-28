using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Random
{

    class Program
    {
        static void Main()
        {
            // Example number of colors
            int numberOfColors = 5; // You can change this to test with different numbers of colors

            int minSocksToRemove = CalculateMinSocks(numberOfColors);

            Console.WriteLine($"Minimum number of socks needed to remove to guarantee a matching pair: {minSocksToRemove}");
            Console.ReadLine();
        }

        static int CalculateMinSocks(int colors)
        {
            return colors + 1;
        }
    }
}
    


