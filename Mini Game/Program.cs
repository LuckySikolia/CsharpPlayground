using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Mini_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initializations
            Random random = new Random();
            Console.CursorVisible = false;
            int height = Console.WindowHeight - 1;
            int width = Console.WindowWidth - 5;
            bool shouldExit = false;

            // Set console position of the player
            int playerX = 0;
            int playerY = 0;

            // Set console position of the food
            int foodX = 0;
            int foodY = 0;

            // The available player states and food strings
            string[] states = { "('-')", "(^-^)", "(x_x)" };
            string[] foods = { "@@@@@", "$$$$$", "#####" };

            // Current player string displayed in the console
            string player = states[0];

            // Index of the current food
            int food = 0;

            // Start the game
            InitializeGame(random, food, foods, ref foodX, ref foodY, width, height, player);
            while (!shouldExit)
            {
                Move(ref playerX, ref playerY, ref shouldExit, player, width, height);

                // Check if player has consumed the food
                if (playerX == foodX && playerY == foodY)
                {
                    // Change the player's appearance to match the food consumed
                    ChangePlayer(ref player, food, states, playerX, playerY);

                    // Decide randomly if the food should freeze the player
                    if (random.Next(0, 2) == 1)
                    {
                        FreezePlayer(ref player, states);
                    }

                    // Redisplay the food at a new location
                    ShowFood(random, ref food, foods, ref foodX, ref foodY, width, height, player);
                }

                // Terminate if the terminal was resized
                if (TerminalResized(height, width))
                {
                    shouldExit = true;
                }
            }
        }

        // A method to determine if the Terminal window was resized.
        static bool TerminalResized(int height, int width)
        {
            return height != Console.WindowHeight - 1 || width != Console.WindowWidth - 5;
        }

        // A method to display a random food appearance at a random location.
        static void ShowFood(Random random, ref int food, string[] foods, ref int foodX, ref int foodY, int width, int height, string player)
        {
            // Update food to a random type
            food = random.Next(0, foods.Length);

            // Update food position to random location
            foodX = random.Next(0, width - player.Length);
            foodY = random.Next(0, height - 1);

            // Display the food at the new location
            Console.SetCursorPosition(foodX, foodY);
            Console.Write(foods[food]);
        }

        // A method that changes the player appearance to match the food consumed.
        static void ChangePlayer(ref string player, int food, string[] states, int playerX, int playerY)
        {
            player = states[food];
            Console.SetCursorPosition(playerX, playerY);
            Console.Write(player);
        }

        // A method that temporarily freezes the player movement.
        static void FreezePlayer(ref string player, string[] states)
        {
            System.Threading.Thread.Sleep(1000); // Pause movement for 1 second
            player = states[0];
        }

        // A method that moves the player according to directional input.
        static void Move(ref int playerX, ref int playerY, ref bool shouldExit, string player, int width, int height)
        {
            int lastX = playerX;
            int lastY = playerY;

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.UpArrow:
                    playerY--;
                    break;
                case ConsoleKey.DownArrow:
                    playerY++;
                    break;
                case ConsoleKey.LeftArrow:
                    playerX--;
                    break;
                case ConsoleKey.RightArrow:
                    playerX++;
                    break;
                case ConsoleKey.Escape:
                    shouldExit = true;
                    break;
                default:
                    // Terminate if an unsupported key is entered
                    shouldExit = true;
                    break;
            }

            // Clear the characters at the previous position
            Console.SetCursorPosition(lastX, lastY);
            Console.Write(new string(' ', player.Length));

            // Keep the player position within the bounds of the terminal window
            playerX = (playerX < 0) ? 0 : (playerX >= width ? width : playerX);
            playerY = (playerY < 0) ? 0 : (playerY >= height ? height : playerY);

            // Draw the player at the new location
            Console.SetCursorPosition(playerX, playerY);
            Console.Write(player);
        }

        // A method that sets up the initial game state.
        static void InitializeGame(Random random, int food, string[] foods, ref int foodX, ref int foodY, int width, int height, string player)
        {
            Console.Clear();
            ShowFood(random, ref food, foods, ref foodX, ref foodY, width, height, player);
            Console.SetCursorPosition(0, 0);
            Console.Write(player);
        }
    }
}
