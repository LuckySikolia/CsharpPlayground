using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Dice_Role_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*You'll use the Random.Next() method to simulate rolling three six-sided dice. 
             * You'll evaluate the rolled values to calculate the score. If the score is greater 
             * than an arbitrary total, then you'll display a winning message to the user. If the 
             * score is below the cutoff, you'll display a losing message to the user. 
             * 
             * If any two dice you roll result in the same value, you get two bonus points for  
             * rolling doubles. If all three dice you roll result in the same value, you get 
             * six bonus points for rolling triples. If the sum of the three dice rolls, plus 
             * any point bonuses, is 15 or greater, you win the game. Otherwise, you lose. */


            Random dice1 = new Random();
            

            int roll1 = dice1.Next(1, 7);
            int roll2 = dice1.Next(1, 7);
            int roll3 = dice1.Next(1, 7);

            int totalScore = roll1 + roll2 + roll3;
            int bonusPoints = 0;

            Console.WriteLine($"your first draw is {roll1}");
            Console.WriteLine($"your second draw is {roll2}");
            Console.WriteLine($"your third draw is {roll3}");
            Console.WriteLine();
            Console.WriteLine();


            //calculat bonus points
            if(roll1 == roll2 && roll1 == roll3)
            {
                bonusPoints = 6;
                Console.WriteLine();
                Console.WriteLine("You got SIX BONUS POINTS for rolling tripples");
            }
            else if(roll1 == roll2 || roll1 == roll3 || roll2 == roll3)
            {

                bonusPoints = 2;
                Console.WriteLine();
                Console.WriteLine("You got TWO BONUS POINTS for rolling doubles");;
            }


            totalScore = totalScore + bonusPoints;
            //calculate win or lose
            if (totalScore >= 15)
            {
                Console.WriteLine($"Your total score is {totalScore}");
                Console.WriteLine("You are A WINNER!");
            }
            else 
            {
                Console.WriteLine("You LOST!");
                Console.WriteLine($"Your total score is {totalScore}");
                
            }


            //award prices
            /* To make the game more fun, you can change the game from "win-or-lose" to 
             * awarding fictitious prizes for each score. You can offer four prizes. 
             * However, the player should win only one prize:
                    If the player scores greater or equal to 16, they'll win a new car.
                    If the player scores greater or equal to 10, they'll win a new laptop.
                    If the player scores exactly 7, they'll win a trip.
                    Otherwise, the player wins a kitten. */

            if(totalScore >= 16)
            {
                Console.WriteLine("You win a car!");
            }
            else if(totalScore >= 10)
            {
                Console.WriteLine("You win a Laptop");
            }
            else if (totalScore == 7)
            {
                Console.WriteLine("You win a Trip");
            }
            else
            {
                Console.WriteLine("You win a kitten");
            }









                Console.ReadLine();
        }
    }
}
