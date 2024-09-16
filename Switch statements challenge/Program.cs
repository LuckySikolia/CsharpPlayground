using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_statements_challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*ewrite an if-elseif-else construct as a switch statement. This challenge should help you see 
             * the strengths/weaknesses of the switch statement when compared to an if-elseif-else 
             * construct.*/

            //SKU = Stock Keeping Unit
            //SKU value format:  <product #>-<2-letter color code>-<size code>

            string sku = "01-MN-L";

            string[] product = sku.Split('-');

            string type = "";
            string colour = "";
            string size = "";

            switch (product[0])
            {
                case "01":
                    type = "Sweat shirt";
                    break;
                case "02":
                    type = "T-Shirt";
                    break;
                case "03":
                    type = "Sweat Pant";
                    break;
                default:
                    type = "Other";
                    break;
            }

            switch (product[1])
            {
                case "BL":
                    colour = "Black";
                    break;
                case "MN":
                    colour = "Maroon";
                    break;
                default:
                    colour = "White";
                    break;
            }

            switch (product[2])
            {
                case "S":
                    size = "Small";
                    break;
                case "M":
                    size = "Medium";
                    break;
                case "L":
                    size = "Large";
                    break;
                default:
                    size = "One Size fits All";
                    break;
            }


            Console.WriteLine($"Product: {size}, {colour}, {type}");
            Console.ReadLine();

        }
    }
}
