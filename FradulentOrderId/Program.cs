using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FradulentOrderId
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Code challenge -Report the Order IDs that need further investigation. Your team has 
            found a pattern. Orders that start with the letter "B" encounter fraud at a rate 
            25 times greater than the normal rate. You write new code that outputs the 
            Order ID of new orders where the Order ID starts with the letter "B".This will 
            be used by the fraud team to investigate further.*/

            string[] orderId = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
            //char lookup = 'B';

            foreach (string order in orderId)
            {
                if (order.StartsWith("B"))
                {
                    Console.WriteLine(order);
                }
            }



            Console.ReadLine();
        }
    }
}
