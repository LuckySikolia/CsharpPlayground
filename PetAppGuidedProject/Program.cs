using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetAppGuidedProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // the ourAnimals array will store the following: 
            string animalSpecies = "";
            string animalID = "";
            string animalAge = "";
            string animalPhysicalDescription = "";
            string animalPersonalityDescription = "";
            string animalNickname = "";

            // variables that support data entry
            int maxPets = 8;
            //string? readResult;  //compiler checks if null. not available in c#7.5 which is what i am using. 
            //CHECK FOR NULL REFERENCE MANUALLY
            string readResult = "";
            string menuSelection = "";
            

            // array used to store runtime data, there is no persisted data
            string[,] ourAnimals = new string[maxPets, 6];

            // TODO: Convert the if-elseif-else construct to a switch statement

            // create some initial ourAnimals array entries
            for (int i = 0; i < maxPets; i++)
            {

                //if there is no data assigned to this slot set it to null
                if(i >= 4) // after the prefilled pets, mark other slots as uninitialized
                {
                    ourAnimals[i, 0] = null;  // Mark the ID field as null to indicate empty slot
                    ourAnimals[i, 1] = null;
                    ourAnimals[i, 2] = null;
                    ourAnimals[i, 3] = null;
                    ourAnimals[i, 4] = null;
                    ourAnimals[i, 5] = null;
                } 

                    switch (i)
                {
                    case 0:
                        animalSpecies = "dog";
                        animalID = "d1";
                        animalAge = "2";
                        animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
                        animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
                        animalNickname = "lola";
                        break;

                    case 1:
                        animalSpecies = "dog";
                        animalID = "d2";
                        animalAge = "9";
                        animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
                        animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
                        animalNickname = "loki";
                        break;

                    case 2:
                        animalSpecies = "cat";
                        animalID = "c3";
                        animalAge = "1";
                        animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
                        animalPersonalityDescription = "friendly";
                        animalNickname = "Puss";
                        break;

                    case 3:
                        animalSpecies = "cat";
                        animalID = "c4";
                        animalAge = "?";
                        animalPhysicalDescription = "";
                        animalPersonalityDescription = "";
                        animalNickname = "";
                        break;

                    default:
                        //mark the remaining slots as uninitialized (null)
                        animalSpecies = null;
                        animalID = null;
                        animalAge = null;
                        animalPhysicalDescription = null;
                        animalPersonalityDescription = null;
                        animalNickname = null;
                        break;
                }

                /*
                                if (i == 0)
                                {
                                    animalSpecies = "dog";
                                    animalID = "d1";
                                    animalAge = "2";
                                    animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
                                    animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
                                    animalNickname = "lola";
                                }
                                else if (i == 1)
                                {
                                    animalSpecies = "dog";
                                    animalID = "d2";
                                    animalAge = "9";
                                    animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
                                    animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
                                    animalNickname = "loki";
                                }
                                else if (i == 2)
                                {
                                    animalSpecies = "cat";
                                    animalID = "c3";
                                    animalAge = "1";
                                    animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
                                    animalPersonalityDescription = "friendly";
                                    animalNickname = "Puss";
                                }
                                else if (i == 3)
                                {
                                    animalSpecies = "cat";
                                    animalID = "c4";
                                    animalAge = "?";
                                    animalPhysicalDescription = "";
                                    animalPersonalityDescription = "";
                                    animalNickname = "";
                                }
                                else
                                {
                                    animalSpecies = "";
                                    animalID = "";
                                    animalAge = "";
                                    animalPhysicalDescription = "";
                                    animalPersonalityDescription = "";
                                    animalNickname = "";
                                }*/

                ourAnimals[i, 0] = animalID;
                ourAnimals[i, 1] = animalSpecies;
                ourAnimals[i, 2] = animalAge;
                ourAnimals[i, 3] = animalNickname;
                ourAnimals[i, 4] = animalPhysicalDescription;
                ourAnimals[i, 5] = animalPersonalityDescription;


                /*ourAnimals[i, 0] = "ID #: " + animalID;
                ourAnimals[i, 1] = "Species: " + animalSpecies;
                ourAnimals[i, 2] = "Age: " + animalAge;
                ourAnimals[i, 3] = "Nickname: " + animalNickname;
                ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
                ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;*/
            }

            // display the top-level menu options
            int newIndex = -1;
            
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
                Console.WriteLine(" 1. List all of our current pet information");
                Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
                Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
                Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
                Console.WriteLine(" 5. Edit an animal’s age");
                Console.WriteLine(" 6. Edit an animal’s personality description");
                Console.WriteLine(" 7. Display all cats with a specified characteristic");
                Console.WriteLine(" 8. Display all dogs with a specified characteristic");
                Console.WriteLine();
                Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    menuSelection = readResult.ToLower();
                }

                Console.WriteLine($"You selected menu option {menuSelection}.");
                Console.WriteLine("Press the Enter key to continue");

                switch (menuSelection)
                {
                    case "1":
                        for(int i = 0; i < maxPets; i++)
                        {
                            Console.WriteLine($"Pet {i + 1}:");
                            Console.WriteLine(ourAnimals[i, 0]); // ID
                            Console.WriteLine(ourAnimals[i, 1]); // Species
                            Console.WriteLine(ourAnimals[i, 2]); // Age
                            Console.WriteLine(ourAnimals[i, 3]); // Nickname
                            Console.WriteLine(ourAnimals[i, 4]); // Physical Description
                            Console.WriteLine(ourAnimals[i, 5]); // Personality Description
                            Console.WriteLine(); // Blank line for readability
                        }
                        break;

                    case "2":
                        //read user input and add it to the array

                        //find the next available index
                        newIndex = -1;
                        
                        for (int i = 0; i < maxPets; i++)
                        {
                            if (ourAnimals[i,0] == null) //checking for null
                            {
                                newIndex = i; //add a new index
                                break;
                            }
                        }

                        //if index is full
                        if(newIndex == -1)
                        {
                            Console.WriteLine("No space available for a new pet");
                            break;
                        } else
                        {
                            Console.WriteLine("Enter ID: ");
                            ourAnimals[newIndex, 0] = "ID #: " + Console.ReadLine();
                            Console.WriteLine("Enter Species: ");
                            ourAnimals[newIndex, 1] = "Species: " + Console.ReadLine();
                            Console.WriteLine("Enter Age: ");
                            ourAnimals[newIndex, 2] = "Age: " + Console.ReadLine();
                            Console.WriteLine("Enter Nickname: ");
                            ourAnimals[newIndex, 3] = "Nickname: " + Console.ReadLine();
                            Console.WriteLine("Enter Physical Description: ");
                            ourAnimals[newIndex, 4] = "Physical description: " + Console.ReadLine();
                            Console.WriteLine("Enter Personality Description: ");
                            ourAnimals[newIndex, 5] = "Personality: " + Console.ReadLine();

                            Console.WriteLine("New pet added successfully");

                        }

                        break;

                    case "3":
                        for(int i = 0; i < maxPets; i++)
                        {
                            if (string.IsNullOrEmpty(ourAnimals[i, 2]))
                            {
                                Console.WriteLine($"Pet {ourAnimals[i, 0]} is missing age. Please enter age:");
                                ourAnimals[i, 2] = Console.ReadLine();
                            }
                            if (string.IsNullOrEmpty(ourAnimals[i, 4]))
                            {
                                Console.WriteLine($"Pet {ourAnimals[i, 0]} is missing age. Please enter age:");
                                ourAnimals[i, 4] = Console.ReadLine(); 
                            }

                        }
                        Console.WriteLine("All missing age and physical descriptions have been updated.");
                        break;

                    case "4":
                        for (int i = 0; i < maxPets; i++)
                        {
                            if (string.IsNullOrEmpty(ourAnimals[i, 3]))
                            {
                                Console.WriteLine($"Pet {ourAnimals[i, 0]} is missing age. Please enter age:");
                                ourAnimals[i, 3] = Console.ReadLine();
                            }
                            if (string.IsNullOrEmpty(ourAnimals[i, 5]))
                            {
                                Console.WriteLine($"Pet {ourAnimals[i, 0]} is missing age. Please enter age:");
                                ourAnimals[i, 5] = Console.ReadLine(); 
                            }

                        }
                        Console.WriteLine("All missing age and physical descriptions have been updated.");
                        break;

                    case "5":

                        for (int i = 0; i < maxPets; i++)
                        {
                            if (ourAnimals[i, 0] != null)
                            {
                                if(!string.IsNullOrEmpty(ourAnimals[i, 2]))
                                {
                                    Console.WriteLine("Update the animal's age");
                                    ourAnimals[i, 2] = Console.ReadLine();
                                    
                                }
                                Console.WriteLine("Pets ages has been updated");
                            }
                        }
                        break;

                    case "6":
                        animalPersonalityDescription = Console.ReadLine();
                        break;

                    case "7":
                        if (animalSpecies == "cat" && animalAge == "9") Console.WriteLine($"{animalSpecies}: + {animalAge}" );
                        break;



                }

                 // pause code execution
                readResult = Console.ReadLine();

            } while (menuSelection != "exit");

           /* Console.Clear();

            Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
            Console.WriteLine(" 1. List all of our current pet information");
            Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
            Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
            Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
            Console.WriteLine(" 5. Edit an animal’s age");
            Console.WriteLine(" 6. Edit an animal’s personality description");
            Console.WriteLine(" 7. Display all cats with a specified characteristic");
            Console.WriteLine(" 8. Display all dogs with a specified characteristic");
            Console.WriteLine();
            Console.WriteLine("Enter your selection number (or type Exit to exit the program)");*/

           /* readResult = Console.ReadLine();
            if (readResult != null)
            {
                menuSelection = readResult.ToLower();
            }

            Console.WriteLine($"You selected menu option {menuSelection}.");
            Console.WriteLine("Press the Enter key to continue");*/

           

            //Console.ReadLine();
        }
    }
}
