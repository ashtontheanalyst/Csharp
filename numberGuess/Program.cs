// Random number guessing game, gives hint if the user is off after 3 tries

using System;
using System.Net.Quic;

namespace numberGuess 
{
    class Program
    {
        static void Main(string[] args)
        {
            // Random number
            Random random = new Random();
            int number = random.Next(0, 101);       // between 0 and 100
            int guess;                              // Just some val out of bounds to start

            Console.WriteLine(number);

            do
            {
                Console.WriteLine("Guess the number between 0 and 100:");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess > number)
                {
                    Console.WriteLine(guess + " is too high.");
                }
                else if (guess < number)
                {
                    Console.WriteLine(guess + " is too low.");
                }
                else
                {
                    break;
                }
            }
            while (guess != number);

            Console.WriteLine(number + " was the correct number, great job!!");

            Console.WriteLine("Thanks for playing!");
        }
    }
}