using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* The interviewer wants you to check if several words are a palindrome
             * A word is a palindrome if it reads the same backwards and forwards
             * 
             */

            string[] words = {"racecar", "talented", "deified", "tent", "tenet"};
            

            Console.WriteLine("Is it a palindrome?");
            foreach (string word in words)
            {
                Console.WriteLine($"The word: {word} \t is palindrome? {IsPalindrome(word)}");
            }



            Console.ReadLine();
        }

        //method to check if it is a palindrome
        static bool IsPalindrome(string word)
        {

            string reversed = new string(word.Reverse().ToArray());
            return word.Equals(reversed, StringComparison.OrdinalIgnoreCase);
        }
    }
}
