using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptionRenewalRandomNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int daysUntilExpiration = random.Next(12);
            int discountPercentage = 0;

            Console.WriteLine(daysUntilExpiration);
            //int totalCost;

            //totalCost = (totalCost - (totalCost * discountPercentage));

            // Your code goes here
            //if (daysUntilExpiration <= 10)
            //{
            //    Console.WriteLine("Your subsciption will expire soon. Renew now!");
            //}
            //else if(daysUntilExpiration <= 5)
            //{
            //    discountPercentage = 10;
            //    Console.WriteLine($"Your subsciption will expire in {daysUntilExpiration} days. \n Renew now! and save {discountPercentage}%");
            //}
            //else if(daysUntilExpiration <= 1)
            //{
            //    Console.WriteLine($"Your subsciption will expires within a day. \n Renew now! and save {discountPercentage}%");
            //}
            //else if (daysUntilExpiration == 0)
            //{
            //    Console.WriteLine("Your subsciption has expired.");
            //}



            if (daysUntilExpiration == 0)
            {
                Console.WriteLine("Your subsciption has expired.");
            }
            else if (daysUntilExpiration <= 1)
            {
                discountPercentage = 20;
                Console.WriteLine($"Your subsciption will expires within a day. \nRenew now! and save {discountPercentage}%");
            }
            else if (daysUntilExpiration <= 5)
            {
                discountPercentage = 10;
                Console.WriteLine($"Your subsciption will expire in {daysUntilExpiration} days. \n Renew now! and save {discountPercentage}%");
            }
            else if (daysUntilExpiration <= 10)
            {
                Console.WriteLine("Your subsciption will expire soon. Renew now!");
            }


            Console.ReadLine();
        }
    }
}
