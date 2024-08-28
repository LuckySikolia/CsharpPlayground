using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptionRenewal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* You've been asked to add a feature to your company's software. The feature 
             * is intended to improve the renewal rate of subscriptions to the software. 
             * Your task is to display a renewal message when a user logs into the 
             * software system and is notified their subscription will soon end. 
             * You'll need to add a couple of decision statements to properly add 
             * branching logic to the application to satisfy the requirements.*/

            bool isLogIn = true;

            

            //check is user subscription is about to expire notice is 5 days before expiry
            //set target date
            DateTime targetDate = new DateTime(2024, 9, 1);

            //set current date
            DateTime currentDate = DateTime.Now;

            //the days left
            TimeSpan timeLeft = targetDate - currentDate;


            //if user is online
            if (isLogIn == true && timeLeft <= TimeSpan.FromDays(5))
            {
                Console.WriteLine($"Subscription Expiring Soon!\r\n\r\nYour subscription will expire on {targetDate.Date} \r\nRenew now to continue enjoying all the benefits!");
            }

           

            Console.WriteLine();
            Console.Write("Viewing days left:  ");
            Console.WriteLine($"{timeLeft.Days} days.");



            Console.ReadLine();
        }
    }
}
