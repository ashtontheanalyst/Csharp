// Rock, Paper, Scissors
using System;

namespace RPS 
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playing = true;
            string choice;
            string player;
            string computer;

            while (playing)
            {
                player = "";
                computer = "";

                Random random = new Random();
                int compGuess = random.Next(1, 4);

                switch (compGuess)
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }

                Console.WriteLine("------------- RPS SHOOT -------------");
                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.Write("Pick ROCK, PAPER, or SCISSORS: ");
                    player = Console.ReadLine().ToUpper();
                }

                Console.WriteLine("Player:      " + player);
                Console.WriteLine("Computer:    " + computer);

                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("It's a draw");
                        }
                        else if (computer == "SCISSORS")
                        {
                            Console.WriteLine("You win!!!");
                        }
                        else
                        {
                            Console.WriteLine("You lose...");
                        }
                        break;
                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You win!!!");
                        }
                        else if (computer == "SCISSORS")
                        {
                            Console.WriteLine("You lose...");
                        }
                        else
                        {
                            Console.WriteLine("It's a draw");
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You lose...");
                        }
                        else if (computer == "SCISSORS")
                        {
                            Console.WriteLine("It's a draw");
                        }
                        else
                        {
                            Console.WriteLine("You win!!!");
                        }
                        break;
                }

                Console.Write("Keep Playing? (Y/N): ");
                choice = Console.ReadLine().ToUpper();

                if (choice == "N")
                {
                    playing = false;
                } 
            }
        }
    }
}