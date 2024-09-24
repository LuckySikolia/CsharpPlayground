using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plan_Petting_Zoo_Visit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //REDO THIS PROJECT. 
            /* Project overview
                You're developing an application for the Contoso Petting Zoo that coordinates school visits. The Contoso Petting Zoo is home to 18 
                different species of animals. At the zoo, visiting students are assigned to groups, and each group has a set of animals assigned to it. 
                After visiting their set of animals, the students will rotate groups until they've seen all the animals at the petting zoo.

                By default, the students are divided into 6 groups. However, there are some classes that have a small or large number of students, so the 
                number of groups must be adjusted accordingly. The animals should also be randomly assigned to each group, so as to keep the experience 
                unique.

                The design specification for the Contoso Petting Zoo application is as follows:

                There are currently three visiting schools

                School A has six visiting groups (the default number)
                School B has three visiting groups
                School C has two visiting groups
                For each visiting school, perform the following tasks

                Randomize the animals
                Assign the animals to the correct number of groups
                Print the school name
                Print the animal groups
             * 
             */

            string[] pettingZoo =
            {
                "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
                "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
                "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
            };

            


            Console.ReadLine();
        }

        //method for student assignment according to groups
        static int GetNumberOfGroups(string schoolName)
        {             
            switch (schoolName)
            {
                case "School A":
                    return 6; // Default number of groups
                case "School B":
                    return 3;
                case "School C":
                    return 2;
                default:
                    Console.WriteLine($"School {schoolName} not recognized.");
                    return 0; // Invalid school, return 0 to indicate no groups
            }     
        }

        //method to randomize the animals using an array
        static string[] RandomizeAnimals(string[] pettingZoo)
        {
            Random rnd = new Random();
            string[] randomizedAnimals = new string[pettingZoo.Length];
            Array.Copy(pettingZoo, randomizedAnimals, pettingZoo.Length);

            for(int i = randomizedAnimals.Length - 1; i > 0; i--)
            {
                int j = random.Next
            }
        }
    }
}
