using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_a_string_manually
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Suppose you're a candidate in a coding interview. The interviewer asks you to write a method to 
             * reverse a string without using string.Reverse
             * 
             */
            //char[] bookName;


            //initialize string as a sentence input by the user
            Console.WriteLine("Enter a book title");
            string bookTitle = Console.ReadLine();
            
            //print out the reversed string
            string reversedBookTitle = ReverseString(bookTitle);
            Console.WriteLine(reversedBookTitle);
            Console.WriteLine();


            //print out the reversed words in strings
            Console.WriteLine("Enter a short quote");
            string wordQuote = Console.ReadLine();
            string reveresdQuoteWord = ReverseWordsInString(wordQuote);
            Console.WriteLine(reveresdQuoteWord);
            Console.WriteLine();


            //print out the reversed words in strings
            Console.WriteLine("Enter a short quote");
            wordQuote = Console.ReadLine();
            string reversedQuoteWord = ReverseTextString(wordQuote);
            Console.WriteLine(reversedQuoteWord);
            Console.WriteLine();


            Console.ReadLine();
        }

        //method to reverse a string.
        static string ReverseString(string bookTitle)
        {
            //convert user input string to array
            char[] bookName = bookTitle.ToCharArray();
            string reversedBookTitle = "";


            for (int i = bookName.Length - 1; i >= 0; i--) 
            {
                //append each character in reverse order
                reversedBookTitle += bookName[i];
                //Console.WriteLine(reversedBookTitle);
            }

            return reversedBookTitle;
        }

        //method to reverse words in strings
        static string ReverseWordsInString(string wordQuote)
        {
            //loop throught the words in the string
            string[] words = wordQuote.Split(new char[] {' '});
            string reveresedQuoteWord = "";

            for (int i = words.Length - 1; i >= 0; i--)
            {
                //append each word in reverse order
                reveresedQuoteWord += words[i];
                //Console.WriteLine(reversedBookTitle);

                //add a space if it's not the last word
                if (i > 0)
                {
                    reveresedQuoteWord += " ";
                }
            }

            return reveresedQuoteWord;
        }

        //method to reverse individual characters in words in a string but the words maintain their position 
        static string ReverseTextString(string wordQuote)
        {

            string reversedQuoteWord = "";

            string[] words = wordQuote.Split(new char[] { ' ' });
            for (int i = 0; i < words.Length; i++)
            {
                //reverse the characters in the current word
                string reveresedWord = "";
                for(int j = words[i].Length - 1; j >= 0; j--)
                {
                    reveresedWord += words[i][j]; //append characters inreverse order
                }

                //append the reveresd word to the result
                reversedQuoteWord += reveresedWord;
                
                //add a space if it's not the last word
                if(i < words.Length - 1)
                {
                    reversedQuoteWord += " ";
                }
            }
            
            return reversedQuoteWord;
        }
    }
}
