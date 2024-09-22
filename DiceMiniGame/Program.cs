using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceMiniGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Dice mini-game challenge
             * 
             * Your challenge is to design a mini-game. The game should select a target number that is a random number between one and five (inclusive). 
             * The player must roll a six-sided dice. To win, the player must roll a number greater than the target number. At the end of each round, 
             * the player should be asked if they would like to play again, and the game should continue or terminate accordingly.
             * 
             * In this challenge, you're given some starting code. You must determine what methods to create, their parameters, and their return types.
             * 
             * In the code that you start with, there are two unavailable methods referenced:
             *  1.ShouldPlay: This method should retrieve user input and determine if the user wants to play again 
             *  2.WinOrLose: This method should determine if the player has won or lost
             * 
             * There are also two uninitialized variables:
             *  1.target: The random target number between 1 and 5 
             *  2.roll: The result of a random six-sided die roll
             * 
             */

          

            int target = 2;
            


            Console.WriteLine("Would you like to play (Y/N)");
            if (ShouldPlay())
            {
                PlayGame(target);
            }



            Console.ReadLine();
        }

        static bool ShouldPlay()
        {
            bool userState = false;
            string userInput = Console.ReadLine();
            if (string.Equals(userInput, "Y", StringComparison.OrdinalIgnoreCase))
            {
                userState = true;
                Console.WriteLine("\n Game starting \n");
            }
            else if (string.Equals(userInput, "N", StringComparison.OrdinalIgnoreCase))
            {
                userState = false;
                Console.WriteLine("Exit Game");
                

            }

            return userState;
        }

        static void PlayGame(int target)
        {
            Random random = new Random();
            var play = true;
            while (play)
            {                
                int roll = random.Next(0, 6); //the result of the random six-sided die roll

                Console.WriteLine($"Roll a number greater than {target} to win!");

                Console.WriteLine($"You rolled a {roll}");
                Console.WriteLine(WinOrLose(target, roll));
                Console.WriteLine("\nPlay again? (Y/N)");

                play = ShouldPlay();
            }
            return;
        }


        static string WinOrLose(int target, int roll)
        {
            if(roll > target)
            {
                return "You Won";
                
            }
            else
            {
                return "Try Again";
           
            }
        }
    }
}
