using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Rock Paper Scissors \nBEST OUT OF FIVE");
            Console.ForegroundColor = ConsoleColor.White;

            //LIST WITH HANDS
            var hand = new List<string>() { "ROCK", "PAPER", "SCISSORS" };

            Random random = new Random();
            Console.WriteLine("Select a hand \n1. ROCK \n2. PAPER \n3. SCISSORS");

            int playerScore = 0;
            int computerScore = 0;
            string restart;

            //GAME LOGIC
            while(playerScore < 5 || playerScore <5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your Score: {0} Computer Score: {1}", playerScore, computerScore);
                Console.ForegroundColor = ConsoleColor.White;

                if (playerScore == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("YOU WIN!!!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("TRY AGAIN? (Y/N)");
                    restart = (Console.ReadLine().ToLower());
                    if(restart == "y")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Rock Paper Scissors \nBEST OUT OF FIVE");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Select a hand \n1. ROCK \n2. PAPER \n3. SCISSORS");
                        playerScore = 0;
                        computerScore = 0;
                        continue;
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
                else if (computerScore == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("COMPUTER WINS!!!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("TRY AGAIN? (Y/N)");
                    restart = (Console.ReadLine().ToLower());
                    if (restart == "y")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Rock Paper Scissors \nBEST OUT OF FIVE");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Select a hand \n1. ROCK \n2. PAPER \n3. SCISSORS");
                        playerScore = 0;
                        computerScore = 0;
                        continue;
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
                else
                {
                }

                try
                {
                    try
                    {
                        Console.WriteLine("Enter 1, 2, or 3...");

                        int playerHand = int.Parse(Console.ReadLine()) - 1;
                        int computerHand = random.Next(0, 3);

                        Console.WriteLine("You Selected: \t\t" + hand[playerHand]);
                        Console.WriteLine("Computer Selected: \t" + hand[computerHand]);

                        if (playerHand == 0 && computerHand == 1)
                        {
                            computerScore++;
                        }
                        else if (playerHand == 0 && computerHand == 2)
                        {
                            playerScore++;
                        }
                        else if (playerHand == 1 && computerHand == 0)
                        {
                            playerScore++;
                        }
                        else if (playerHand == 1 && computerHand == 2)
                        {
                            computerScore++;
                        }
                        else if (playerHand == 2 && computerHand == 0)
                        {
                            computerScore++;
                        }
                        else if (playerHand == 2 && computerHand == 1)
                        {
                            playerScore++;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("TIE!!!");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("THAT'S NOT A NUMBER!!! TRY AGAIN!!!");
                        continue;
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("WRONG NUMBER!!! TRY AGAIN!!!");
                    continue;
                }
            }            
        }
    }
}



