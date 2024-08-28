using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOrderIdProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare array to hold three elements
            string[] fraudulentOrderIDs = new string[3];

            //assign values to the array
            fraudulentOrderIDs[0] = "A123";
            fraudulentOrderIDs[1] = "B456";
            fraudulentOrderIDs[2] = "C789";

            //reassign value of an array
            //fraudulentOrderIDs[0] = "F000";

            //retireve values from elements of an array
            Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
            Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
            Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

            //resign values of an array
            fraudulentOrderIDs[0] = "F000";

            Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

            //initialize an array
            string[] fraudulentOrderIDsss = { "A123", "B456", "C789" };

            //length property of an array
            Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

            Console.ReadLine();
        }
    }
}
