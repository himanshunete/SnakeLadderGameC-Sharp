using System;

namespace SnakeAndLadderGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Game");
            //Variables
            int numberOfPlayers = 1;
            int position = 0;

            //Constants
            int NoPlay = 0;
            int Ladder = 1;
            int Snake = 2;
            int NUM_OF_PLAY = 20;


            Console.WriteLine(" Only " + numberOfPlayers + " player is playing the game, starting at position " + position + " now ");

            //Computation
            for (int numOfPlay = 1; numOfPlay <= NUM_OF_PLAY; numOfPlay++)
            {
                Random rand = new Random();
                int diceNumber = rand.Next(1, 7);
                int option = rand.Next(0, 3);
                if (option == NoPlay)
                {
                    Console.WriteLine(" The Player is at the same position " + position);
                }
                else if (option == Ladder)
                {
                    position = position + diceNumber;
                    Console.WriteLine("Player moves forward to position:" + position);
                }
                else if (option == Snake)
                {
                    position = position - diceNumber;
                    if (position < 0)
                    {
                        Environment.Exit(0);
                    }
                    Console.WriteLine("Player moves back to position:" + position);
                }

            }
        }
    }
}
