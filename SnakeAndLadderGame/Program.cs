﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace SnakeAndLadderGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Game");
            Dictionary<int, int> map = new Dictionary<int, int>();
            //Variables
            int numberOfPlayers = 1;
            int numOfPlay = 1;

            //Constants
            int NoPlay = 0;
            int Ladder = 1;
            int Snake = 2;
            int WIN_POSITION = 100;
            int[] position = new int[2000];

            Console.WriteLine(" Only " + numberOfPlayers + " player is at start position: 0 now ");

            //Computation
            while ( position[numOfPlay] != WIN_POSITION)
            {
                position[0] = 0;
                map.Add(numOfPlay, position[numOfPlay]);
                Random rand = new Random();
                int diceNumber = rand.Next(1, 7);
                int option = rand.Next(0, 3);
                if (position[numOfPlay] > WIN_POSITION)
                {
                    position[numOfPlay] = position[numOfPlay - 1];
                }
                if (option == NoPlay)
                {
                    position[numOfPlay + 1] = position[numOfPlay];
                    Console.WriteLine(" The Player is at the same position " + position[numOfPlay + 1]);
                }
                else if (option == Ladder)
                {
                    position[numOfPlay + 1] = position[numOfPlay] + diceNumber;
                    Console.WriteLine("Player moves forward to position:" + position[numOfPlay + 1]);
                }
                else if (option == Snake)
                {
                    position[numOfPlay + 1] = position[numOfPlay] - diceNumber;
                    if (position[numOfPlay + 1] < 0)
                    {
                        position[numOfPlay + 1] = 0;
                        Console.WriteLine(" Game restarts ");
                    }
                    Console.WriteLine("Player moves back to position:" + position[numOfPlay + 1]);
                }
                if (position[numOfPlay + 1] == WIN_POSITION)
                {
                    Console.WriteLine(" The Player wins the Snake ladder game ");
                    int m = map.Count;
                    Console.WriteLine(m + " times the dice is rolled to win the game ");

                    Console.WriteLine(" mapping of SnakeLadder is " + map);

                    //get position
                    foreach (int value in map.Values)
                    {
                        Console.WriteLine(" position after die roll is " + value);
                    }
                    Environment.Exit(0);
                }

                numOfPlay++;


            }
        }
    }
}
