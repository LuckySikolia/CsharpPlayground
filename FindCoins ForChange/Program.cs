﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindCoins_ForChange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Suppose you have several coins of different values. You're tasked to find two coins whose sum is equal to a target value
             * In this exercise, the coins available are represented in an integer array. 
             * You'll need to return the indices (position / index) of the two coins in a new array
             */

            int[] coins = new int[]{5,5,25,25,10,5};
            int target = 60;

            int[,] result = TwoCoins(coins, target);
            if (result.Length == 0)
            {
                Console.WriteLine("No two coins make change");
            }
            else
            {
                Console.WriteLine($"Change found at positions");
                for (int i = 0; i < result.GetLength(0); i++)
                {
                    if (result[i, 0] == -1)
                    {
                        break;
                    }
                    Console.WriteLine($"{result[i, 0]},{result[i, 1]}");
                }
            }



            Console.ReadLine();
        }

        static int[,] TwoCoins(int[] coins, int target)
        {
            int[,] result = { { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 } };
            int count = 0;

            for (int curr = 0; curr < coins.Length; curr++)
            {
                for (int next = curr + 1; next < coins.Length; next++)
                {
                    if (coins[curr] + coins[next] == target)
                    {
                        result[count, 0] = curr;
                        result[count, 1] = next;
                        count++;
                    }
                    if (count == result.GetLength(0))
                    {
                        return result;
                    }
                }
            }
            return (count == 0) ? new int[0, 0] : result;



        }
    }
}
