using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Methods_with_parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] corporate =
            {
                {"Robert", "Bavin"}, {"Simon", "Bright"},
                {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
                {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
            };

            string[,] external =
            {
                {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
                {"Shay", "Lawrence"}, {"Daren", "Valdes"}
            };

            string externalDomain = "hayworth.com";

            for (int i = 0; i < corporate.GetLength(0); i++)
            {
                DisplayInternalEmailAddresses(corporate[i,0], corporate[i,1]);
            }

            for (int i = 0; i < external.GetLength(0); i++)
            {
                // display external email addresses
                DisplayExternalEmailAddresses(external[i, 0], external[i, 1], externalDomain);
            }




            Console.ReadLine();
        }

        static void DisplayInternalEmailAddresses(string firstName, string lastName)
        {
            /*Remember, the domain for internal employees is "contoso.com" and the username for all employees is the first two
              characters of their first name, followed by their full last name.
                
            */

            string userName = firstName.Substring(0, 2).ToLower() + lastName.ToLower();
            string internalDomain = "contoso.com";
            Console.WriteLine($"{userName}@{internalDomain}");

            return;

        }

        static void DisplayExternalEmailAddresses(string firstName, string lastName, string externalDomain)
        {
            /*Remember, the domain for internal employees is "contoso.com" and the username for all employees is the first two
              characters of their first name, followed by their full last name.
                
            */

            string userName = firstName.Substring(0, 2).ToLower() + lastName.ToLower();
            Console.WriteLine($"{userName}@{externalDomain}");

            return;

        }

    }
}
