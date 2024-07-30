using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IfStatementPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trial();
            Console.WriteLine();
            PetsToys();
            Console.ReadLine();
        }

        static bool Trial()
        {
            bool isMale = true;
            bool isTall = true;

            //Determine their gender
            if (isMale)
            {
                Console.WriteLine("I am the essence of a man");
            }
            else
            {
                Console.WriteLine("I am the essence of a woman");
            }

            //Determine game to play
            if (isTall)
            {
                Console.WriteLine("Sign up for basketball");
            }
            else if (isMale)
            {
                Console.WriteLine("Sign up for male Swmming team");
            }
            else
            {
                Console.WriteLine("Sign up for the female Volleyball team");
            }

            return isMale;
        }

        //method to check pets and their toy suggestions
        static bool PetsToys()
        {
            bool isPetMale = false;
            bool isLikeBird = true;

            if (isPetMale)
            {
                Console.WriteLine("This is a male cat");
            }
            else
            {
                Console.WriteLine("This is a female cat");
            }

            if (isLikeBird)
            {
                Console.WriteLine("Get the magic wand toy");
            }
            else
            {
                Console.WriteLine("Get the moving rat toy");
            }

            return isLikeBird;
        }

    }
}
