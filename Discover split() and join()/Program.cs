using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discover_split___and_join__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string value = "abc123";
            char[] valueArray = value.ToCharArray();
            Array.Reverse(valueArray);
            // string result = new string(valueArray);
            //Combine all of the chars into a new comma-separated-value string using Join()
            string result = String.Join(",", valueArray);
            Console.WriteLine(result);
            Console.WriteLine();

            string[] items = result.Split(',');
            foreach (string item in items)
            {
                Console.WriteLine(item);
            }*/


            /* ////challenge 1:Complete a challenge to reverse words in a sentence

             //string pangram = "The quick brown fox jumps over the lazy dog";
             //string reversedPanagram = new string(pangram.Reverse().ToArray());

             //Console.WriteLine(reversedPanagram);
            */



            /*//CHALLENGE 2
            //Complete a challenge to parse a string of orders, sort the orders and tag possible errors

            string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
            string[] orderStreamArray = orderStream.Split(',');
            //string[] result = new string[orderStream.Sort()];
            Console.WriteLine(orderStream);
            Console.WriteLine();

            //sort the array in ascending order
            Array.Sort(orderStreamArray);

            foreach (string item in orderStreamArray)
            {
                Console.WriteLine(item);

                if (item.ToCharArray().Length != 4)
                {
                    Console.WriteLine($"{item} - Error");*//*


                }
            }*/


            string message = "Find what is (inside the parentheses)";

            int openingPosition = message.IndexOf('(');
            int closingPosition = message.IndexOf(')');

            // Console.WriteLine(openingPosition);
            // Console.WriteLine(closingPosition);

            openingPosition += 1;

            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));




            Console.ReadLine();
        }
    }
}
