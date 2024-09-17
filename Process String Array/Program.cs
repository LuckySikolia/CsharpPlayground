using System;

namespace Process_String_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Code that processes the contents of a string array
             * Code conditions:
             * 1. Declare an integer variable named periodLocation to hold the location of the period character.
             * 2. Use an outer loop to process each string element in the array.
             * 3. Use IndexOf() method to get the location of the first period character in the string.
             * 4. Use an inner loop to process the string and extract sentences.
             * 5. Display each sentence (without period) to the console.
             * 6. Use Remove(), Substring(), and TrimStart() to process the string.
             */

            // String array
            string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
           
                        
            for (int i = 0; i < myStrings.Length; i++)
            {
                string myString = myStrings[i];
                int periodLocation = myString.IndexOf(".");

                string mySentence;

                // extract sentences from each string and display them one at a time
                while (periodLocation != -1)
                {

                    // first sentence is the string value to the left of the period location
                    mySentence = myString.Remove(periodLocation);

                    // the remainder of myString is the string value to the right of the location
                    myString = myString.Substring(periodLocation + 1);

                    // remove any leading white-space from myString
                    myString = myString.TrimStart();

                    // update the comma location and increment the counter
                    periodLocation = myString.IndexOf(".");

                    Console.WriteLine(mySentence);
                }

                mySentence = myString.Trim();
                Console.WriteLine(mySentence);
            }

            // Wait for input to close the console
            Console.ReadLine();
        }
    }
}
