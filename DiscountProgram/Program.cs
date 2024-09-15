using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*you need to quickly determine whether a customer's purchase is eligible for a promotional discount.
             * The details for the promotion indicate that when a purchase value is greater than 1000, the purchase 
             * is eligible for a  100 discount. If the purchase amount is 1000 or less, the purchase is eligible for
             * a 50 discount  */

            /*int saleAmount = Convert.ToInt16(Console.ReadLine());
            int discount = saleAmount > 1000 ? 100 : 50;
            Console.WriteLine($"Discount: {discount}");

            Console.ReadLine();*/


            //CODE TO SIMULATE A COIN FLIP
            /*implement a conditional operator to simulate a "coin flip". The resulting decision logic will display either 
             * heads or tails.*/

            Random rnd = new Random();
            int coinFlip = rnd.Next(0, 2);

            Console.WriteLine(coinFlip < 1 ? "heads" : "tails");
            Console.ReadLine();

        }
    }
}
