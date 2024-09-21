using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_currency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Suppose you're visiting Vietnam and want to create a brief program that converts currency. 
             * You can assume the current exchange rate is 1 USD = 23500 VND. 
             * In this task, you'll write a method that converts USD to VND.
             * 
             */
            double usd = 23.73;
            int vnd = UsdToVnd(usd);


            Console.ReadLine();
        }

        
        static int UsdToVnd(double usd)
        {
            //convert the usd to vnd
            double vnd = 0;
            int exchangeRate = 23500;
            vnd = usd * exchangeRate;
            

            Console.WriteLine($"The exchange rate: {exchangeRate}. \t you converted {usd}USD to {vnd}VND");
            


            return Convert.ToInt32(vnd);
        }
    }
}
