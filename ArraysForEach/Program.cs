using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ArraysForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Suppose you work for a manufacturing company.The company needs you to 
            complete an inventory of your warehouse to determine the number of products 
            that are ready to ship.In addition to the total number of finished products, 
            you need to report the number of finished products stored in each individual 
            bin in your warehouse, along with a running total.This running total will be 
            used to create an audit trail so you can double - check your work and identify 
            "shrinkage".*/

            int[] inventory = { 200, 450, 175, 250 };
            int sum = 0;

            int currentBinNo = 0;


            //iterate though the for each statement
            foreach (int items in inventory)
            {
                sum += items;
                currentBinNo++;
                Console.WriteLine($"Bin {currentBinNo} = {items} items (Running total: {sum})");
            }

            Console.WriteLine($"The total number of products is: {sum}");
            Console.WriteLine();
            
            //current bin number for inventory being processed

            
            


            Console.ReadLine();

        }
    }
}
