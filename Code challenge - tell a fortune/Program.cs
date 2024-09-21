using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_challenge___tell_a_fortune
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* You're helping to develop a massive multiplayer role-playing game. Each player has a luck stat that can affect their odds of finding 
             * rare treasure. Each day, a player can speak to an in-game fortune teller that reveals whether their luck stat is high, low, or neutral.
             * The game currently has code to generate a player's fortune, but it isn't reusable. Your task is to create a tellFortune method that can 
             * be called at any time, and replace the existing logic with a call to your method.
             * 
             * In this challenge, you're given some starting code. You must decide how to create and call the tellFortune method.
             * 
             */


            //starter code
            Random random = new Random();
            int luck = random.Next(100);  //generate a random no between 0 and 99

            string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };
            string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
            string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
            string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };

            Console.WriteLine("A fortune teller whispers the following words:");
            string[] fortune = Fortune(luck, good, bad, neutral);

            for (int i = 0; i < 4; i++)
            {
                Console.Write($"{text[i]} {fortune[i]} ");
            }






            Console.ReadLine();
        }

        static string[] Fortune(int luck, string[] good, string[] bad, string[] neutral)
        {
            string[] fortune;
            if (luck > 75)
            {
                fortune = good;
            }
            else if (luck < 25)
            {
                fortune = bad;
            }
            else
            {
                fortune = neutral;
            }

            return fortune;
        }
    }
}
