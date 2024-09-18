using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discoversort___reversesort__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] pallets = { "B14", "A11", "B12", "A13" };

            Console.WriteLine("Sorted...");
            Array.Sort(pallets);  //sort the array alphanumerically

            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }


            Console.WriteLine("");
            Console.WriteLine("Reversed...");
            Array.Reverse(pallets);
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

            /*The Array.Clear() method allows you to remove the contents of specific elements in your array and replace it with the array default value*/

            Array.Clear(pallets, 0, 2);
            Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }


            Console.WriteLine("");
            //In this case, you're resizing the pallets array from four elements to 6. The new elements are added at the end of the
            //current elements. The two new elements will be null until you assign a value to them.
            Array.Resize(ref pallets, 6); //the Resize() method passing in the pallets array by reference, using the ref keyword. 
            Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

            pallets[4] = "C01";
            pallets[5] = "C02";

            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

            Console.ReadLine();
        }
    }
}
