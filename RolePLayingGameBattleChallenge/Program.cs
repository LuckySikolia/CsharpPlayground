using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePLayingGameBattleChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*In this challenge, we boil down that interaction to its essence. A hero and a monster 
             * start with the same health score. During the hero's turn, they generate a random value 
             * that is subtracted from the monster's health. If the monster's health is greater than 
             * zero, they take their turn and attack the hero. As long as both the hero and the monster 
             * have health greater than zero, the battle resumes.
             * 
             * RULES
             *  1.You must use either the do-while statement or the while statement as an outer game loop.
                2.The hero and the monster start with 10 health points.
                3.All attacks are a value between 1 and 10.
                4.The hero attacks first.
                5.Print the amount of health the monster lost and their remaining health.
                6.If the monster's health is greater than 0, it can attack the hero.
                7.Print the amount of health the hero lost and their remaining health.
                8.Continue this sequence of attacking until either the monster's health or hero's health is zero or less
                9.Print the winner
             */

            int heroHealthXP = 10;
            int monsterHealthXP = 10;

            Random rnd = new Random();
            //int attackImpact = rnd.Next(1, 11);

            do
            {
                int heroattackImpact = rnd.Next(1, 11);

                monsterHealthXP -= heroattackImpact;
                if (monsterHealthXP < 0) monsterHealthXP = 0; //prevent negative
                //int heroAttack = monsterHealthXP - attackImpact;
                Console.WriteLine($"Monster lost: {heroattackImpact}XP \t Current monster health: {monsterHealthXP}XP");

                

                if(monsterHealthXP > 0)
                {
                    int monsterattackImpact = rnd.Next(1, 11);
                    heroHealthXP -= monsterattackImpact;
                    if (heroHealthXP < 0) heroHealthXP = 0;
                    Console.WriteLine($"Hero lost: {monsterattackImpact}XP \t Current hero health: {heroHealthXP}XP");
                }

            } while (monsterHealthXP > 0 && heroHealthXP > 0);

            Console.WriteLine(heroHealthXP > monsterHealthXP ? "Hero you are the winner": "Monster is the winner");

          

            Console.ReadLine();


        }
    }
}
