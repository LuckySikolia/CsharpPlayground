using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {




            //string secretWord = "Giraffes";
            //string guess = "";

            ////prompt the user to guess the word until it is correct
            //while (guess != secretWord)
            //{
            //    Console.WriteLine("Opps try again");
            //    Console.WriteLine("Enter guess: ");
            //    guess = Console.ReadLine();
            //}
            //Console.WriteLine("You Win!");

            ////game to make user guess the secret word using do while loop
            string result = SecretWrd();
            Console.WriteLine(result);

            Console.ReadLine();
        }

        //game to make user guess the secret word using do while loop
        static string SecretWrd ()
        {
            string guess2 = "";
            string secret2Word = "Mangoes";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;


            do
            {
                if (guessCount < guessLimit)
                {
                    Console.WriteLine("Guess a random word to win a car: ");
                    guess2 = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                    Console.WriteLine("You are out of guesses");
                }
                

            } while (guess2 != secret2Word && !outOfGuesses);

            if (guess2 == secret2Word)
            {
                return $"You Won! The correct answer is {secret2Word}";
            }else
            {
                return "You lost! Better luck next time.";
            }

        }

    }
}
