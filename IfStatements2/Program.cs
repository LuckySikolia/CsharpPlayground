using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatements2
{
    internal class Program
    {
        //The detective examined the crime scene meticulously.If the glass was shattered from the inside, it indicated a 
        //forced entry.However, if the glass was unbroken but the door was ajar, it suggested a possible insider job. The 
        //position of the furniture and the absence of valuable items would further solidify the theory.
        static void Main(string[] args)
        {
            Console.WriteLine("Help the detective to solve a mystery");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
            Console.WriteLine("The detective examined the crime scene meticulously and discovered that.....  ");

            string result = SolveMystery(true, false);
            Console.Write(result);
            Console.WriteLine("The position of the furniture and the absence of valuable items would further solidify the theory.");

            Console.ReadLine();
        }

        static string SolveMystery (bool isGlassShattered, bool isSuspectMale )
        {
            //bool isGlassShattered = true;
            //bool isSuspectMale = true;

            if (isGlassShattered && isSuspectMale)
            {
                return "The glass was shattered from the inside, this indicated a forced entry. Judging by the foot steps the suspect is male. ";
            }
            //else if(isGlassShattered || isSuspectMale)
            //{
            //    return "The glass may have broken but the door was ajar, it suggested a possible insider job. Judging by the foot steps the suspect may be male. ";
            //}
            else if (isGlassShattered && !isSuspectMale)
            {
                return "The glass was shattered from the inside, this indicated a forced entry. Judging by the foot steps the suspect is female. ";
            }
            else if (!isGlassShattered && !isSuspectMale)
            {
                return "The glass was not broken but the door was ajar, it suggested a possible insider job. Judging by the foot steps the suspect is female. ";
            }
            else
            {
                return "We need to search the other rooms for more clues";
            }

        }
    }
}
