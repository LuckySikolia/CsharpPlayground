using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validate_user_input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Here are the conditions that your first coding project must implement:
                1.Your solution must include either a do-while or while iteration.
                2.Before the iteration block: your solution must use a Console.WriteLine() statement 
                  to prompt the user for an integer value between 5 and 10.
                3.Inside the iteration block:
                     > Your solution must use a Console.ReadLine() statement to obtain input from the user.
                     > Your solution must ensure that the input is a valid representation of an integer.
                     > If the integer value isn't between 5 and 10, your code must use a Console.WriteLine() 
                        statement to prompt the user for an integer value between 5 and 10. 
                     > Your solution must ensure that the integer value is between 5 and 10 before exiting 
                        the iteration.
                 4.Below (after) the iteration code block: your solution must use a Console.WriteLine() statement 
                        to inform the user that their input value has been accepted
            */

            //initialization
            int num;
            //string userInput = Console.ReadLine();

            while (true)
            {
                
                //Get user input
                Console.WriteLine("Enter a number between 5 and 10");
                string userInput = Console.ReadLine();
                if(int.TryParse(userInput, out num) && num >= 5 && num <= 10)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("!ERROR: Ensure the number is between 5 and 10 (inclusive)\n");
                }
                
            }
            Console.WriteLine($"Your number:{num} has been accepted");


            Console.ReadLine();
        }
    }
}
