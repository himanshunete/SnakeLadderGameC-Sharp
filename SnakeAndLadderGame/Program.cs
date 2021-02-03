using System;
using System.Collections.Generic;
using System.Linq;

namespace SnakeAndLadderGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Game");
            Dictionary<int, int> map1 = new Dictionary<int, int>();
            Dictionary<int, int> map2 = new Dictionary<int, int>();
            //Variables
            int numberOfPlayers = 2;

            //Constants
            int NoPlay = 0;
            int Ladder = 1;
            int Snake = 2;
            int NUM_OF_PLAY = 2000;
            int WIN_POSITION = 100;
            int[] position = new int[NUM_OF_PLAY];

            Console.WriteLine(numberOfPlayers + " players ie player 1 and 2 both at the start position: 0 now ");

            //Computation
            for (int numOfPlay = 0; numOfPlay < NUM_OF_PLAY; numOfPlay++)
            { 
                for ( numberOfPlayers = 0; numberOfPlayers < 2; numberOfPlayers++)
                {
                    //Player 1 is playing
                    if (numberOfPlayers == 0)
                    {
                        position[0] = 0;
                        map1.Add(numOfPlay, position[numOfPlay]);
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
                            Console.WriteLine(" The Player 1 is at the same position: " + position[numOfPlay + 1]);
                        }


                        //If a Player gets a ladder then play again (bonus)
                        else if (option == Ladder)
                        {
                            position[numOfPlay + 1] = position[numOfPlay] + diceNumber;
                            Console.WriteLine("Player 1 moves forward to position:" + position[numOfPlay + 1]);
                            if (position[numOfPlay] > WIN_POSITION)
                            {
                                position[numOfPlay] = position[numOfPlay - 1];
                            }
                            if (option == NoPlay)
                            {
                                position[numOfPlay + 1] = position[numOfPlay];
                                Console.WriteLine(" The Player 1 is at the same position: " + position[numOfPlay + 1]);
                            }
                            else if (option == Ladder)
                            {
                                position[numOfPlay + 1] = position[numOfPlay] + diceNumber;
                                Console.WriteLine("Player 1 moves forward to position:" + position[numOfPlay + 1]);


                            }
                            else if (option == Snake)
                            {
                                position[numOfPlay + 1] = position[numOfPlay] - diceNumber;
                                if (position[numOfPlay + 1] < 0)
                                {
                                    position[numOfPlay + 1] = 0;
                                    Console.WriteLine(" Game restarts ");
                                }
                                Console.WriteLine("Player 1 moves back to position:" + position[numOfPlay + 1]);
                            }
                            if (position[numOfPlay + 1] == WIN_POSITION)
                            {
                                Console.WriteLine(" The Player 1 wins the Snake ladder game ");
                                int m = map1.Count;
                                Console.WriteLine(m + " times the dice is rolled to win the game ");
                                foreach (int value in map1.Values)
                                {
                                    Console.WriteLine(" position of player 1 after die roll is " + value);
                                }


                                Environment.Exit(0);
                            }


                        }
                        else if (option == Snake)
                        {
                            position[numOfPlay + 1] = position[numOfPlay] - diceNumber;
                            if (position[numOfPlay + 1] < 0)
                            {
                                position[numOfPlay + 1] = 0;
                                Console.WriteLine(" Game restarts ");
                            }
                            Console.WriteLine("Player 1 moves back to position:" + position[numOfPlay + 1]);
                        }
                        if (position[numOfPlay + 1] == WIN_POSITION)
                        {
                            Console.WriteLine(" The Player 1 wins the Snake ladder game ");
                            int m = map1.Count;
                            Console.WriteLine(m + " times the dice is rolled to win the game ");
                            foreach (int value in map1.Values)
                            {
                                Console.WriteLine(" position of player 1 after die roll is " + value);
                            }


                            Environment.Exit(0);
                        }
                    }

                    //Player 2 is playing
                    else if (numberOfPlayers == 1)
                    {
                        position[0] = 0;
                        map2.Add(numOfPlay, position[numOfPlay]);
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
                            Console.WriteLine(" The Player 2 is at the same position: " + position[numOfPlay + 1]);
                        }


                        //If a Player  gets a ladder then play again (bonus)
                        else if (option == Ladder)
                        {
                            position[numOfPlay + 1] = position[numOfPlay] + diceNumber;
                            Console.WriteLine("Player 2 moves forward to position:" + position[numOfPlay + 1]);
                            if (position[numOfPlay] > WIN_POSITION)
                            {
                                position[numOfPlay] = position[numOfPlay - 1];
                            }
                            if (option == NoPlay)
                            {
                                position[numOfPlay + 1] = position[numOfPlay];
                                Console.WriteLine(" The Player 2 is at the same position: " + position[numOfPlay + 1]);
                            }
                            else if (option == Ladder)
                            {
                                position[numOfPlay + 1] = position[numOfPlay] + diceNumber;
                                Console.WriteLine("Player 2 moves forward to position:" + position[numOfPlay + 1]);


                            }
                            else if (option == Snake)
                            {
                                position[numOfPlay + 1] = position[numOfPlay] - diceNumber;
                                if (position[numOfPlay + 1] < 0)
                                {
                                    position[numOfPlay + 1] = 0;
                                    Console.WriteLine(" Game restarts ");
                                }
                                Console.WriteLine("Player 2 moves back to position:" + position[numOfPlay + 1]);
                            }
                            if (position[numOfPlay + 1] == WIN_POSITION)
                            {
                                Console.WriteLine(" The Player 2 wins the Snake ladder game ");
                                int m = map2.Count;
                                Console.WriteLine(m + " times the dice is rolled to win the game ");
                                foreach (int value in map2.Values)
                                {
                                    Console.WriteLine(" position of player 2 after die roll is " + value);
                                }


                                Environment.Exit(0);
                            }

                        }
                        else if (option == Snake)
                        {
                            position[numOfPlay + 1] = position[numOfPlay] - diceNumber;
                            if (position[numOfPlay + 1] < 0)
                            {
                                position[numOfPlay + 1] = 0;
                                Console.WriteLine(" Game restarts ");
                            }
                            Console.WriteLine("Player 2 moves back to position:" + position[numOfPlay + 1]);
                        }
                        if (position[numOfPlay + 1] == WIN_POSITION)
                        {
                            Console.WriteLine(" The Player 2 wins the Snake ladder game ");
                            int m = map2.Count;
                            Console.WriteLine(m + " times the dice is rolled to win the game ");
                            foreach (int value in map2.Values)
                            {
                                Console.WriteLine(" position player 2 after die roll is " + value);
                            }

                            Environment.Exit(0);
                        }

                    }
                }
            }
        }
    }
}
