using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_and_return_values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Use methods to calculate the total purchase price
             * The Contoso Shopping Center is having a super sale! Many items have discounted price. You're given a list of item prices and 
             * a list of corresponding discounts.
             * 
             * The discounts are represented by percentages, for example 50% = 0.5
             * If a customer spends more than 30.00 they receive 5.00 of their total purchase (essentislly they receiva a discount of 16.67% or 16.7%)
             * In this task, you'll write code to calculate the customer's total.
             *  
            */

            //initializations
            double total = 0;
            double minimumSpent = 30.00;

            double[] items = { 15.97, 3.50, 12.25, 22.99, 10.98 };
            double[] discounts = { 0.30, 0.00, 0.10, 0.20, 0.50 };


            int itemIndex = 0;
            double input = 0;

            Console.WriteLine($"Total: ${total}");

            //calculate the total discounted price
            total = GetDiscountedPrice(itemIndex, items, discounts);

            //check if the total amount meets the  minimum spending requirement
            total =  TotalMeetsMinimum(total, minimumSpent);
            
            //FormatDecimal(input);


            Console.ReadLine();
        }

        static double GetDiscountedPrice(int itemIndex, double[] items, double[] discounts)
        {
            double discountPrice = 0;
            double total = 0;

            //calculate the discounted price of the item (Discount amount = listed price - selling price)  (Discount % = (discount amount / list price) * 100)
            for (itemIndex = 0; itemIndex < items.Length; itemIndex++)
            {
                //apply the corresponding discount
                double discount = (items[itemIndex] * discounts[itemIndex]);
                discountPrice = items[itemIndex] - discount;
                //double discountPrice = items[itemIndex] - (items[itemIndex] * discounts[itemIndex]);

                //display the discount and the discounted price
                Console.WriteLine($"Item {itemIndex + 1}: Your discount is: ${discount} \t Your item price after the discount is: ${discountPrice} ");
                
                //Console.WriteLine($"Your item price after the discount is: ${discountPrice}");

                //add the discounted price to the total
                total += discountPrice;
                                
            }
            return total;
        }

        static double TotalMeetsMinimum(double total, double minimumSpent)
        {
            //check if the total meets the minimum
            if (total > minimumSpent)
            {
                double spendingDiscount = 5.00;  //flat discount for meeting the minimum shopping requirement
                total -= spendingDiscount;

                Console.WriteLine();
                Console.WriteLine($"You qualified for a spending discount of: ${spendingDiscount}");
                
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("You did not qualify for the spending discount.");
            }
            return total;
        }

        //static string FormatDecimal(double input)
        //{
        //    //Format the double so only 2 deciam places are displayed
        //    //return input.ToString().Substring(0, 5);
        //    return;
        //}
    }
}
