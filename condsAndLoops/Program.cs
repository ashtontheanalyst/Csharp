using System;

namespace condsAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // If Statement --------------------------------------------------------------------------
            Console.WriteLine("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age > 100)
            {
                Console.WriteLine("You're probably so dead.");
            }
            else if (age >= 18)
            {
                Console.WriteLine("You can get a credit card!");
            }
            else if (age <= 0)
            {
                Console.WriteLine("You aren't even born yet bro.");
            }
            else
            {
                Console.WriteLine("You're too young...");
            }

            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();

            if (name == "")
            {
                Console.WriteLine("You didn't enter anything");
            }
            else
            {
                Console.WriteLine("Hello " + name + "!");
            }


            // Switches ------------------------------------------------------------------------------
            Console.WriteLine("What day is it today?: ");
            string day = Console.ReadLine();
            day = day.ToLower();

            switch (day)
            {
                case "monday":
                    Console.WriteLine("It's " + day.ToUpperInvariant() + "!");
                    break;
                case "tuesday":
                    Console.WriteLine("It's " + day.ToUpperInvariant() + "!");
                    break;
                case "wednesday":
                    Console.WriteLine("It's " + day.ToUpperInvariant() + "!");
                    break;
                case "thursday":
                    Console.WriteLine("It's " + day.ToUpperInvariant() + "!");
                    break;
                case "friday":
                    Console.WriteLine("It's " + day.ToUpperInvariant() + "!");
                    break;
                case "saturday":
                    Console.WriteLine("It's " + day.ToUpperInvariant() + "!");
                    break;
                case "sunday":
                    Console.WriteLine("It's " + day.ToUpperInvariant() + "!");
                    break;
                default:
                    Console.WriteLine("That's not a day...");
                    break;
            }


            // Logical Operators && || -----------------------------------------------------------------------------------
            Console.WriteLine("What's the temp outside? (*F): ");
            int temp = Convert.ToInt32(Console.ReadLine());

            if (temp >= 60 && temp <= 80)
            {
                Console.WriteLine("The weather is nice!");
            }
            else if (temp > 130 || temp < -10)
            {
                Console.WriteLine("DON'T GO OUTSIDE!!");
            }
            else
            {
                Console.WriteLine("It ain't too nice...");
            }


            // While Loops -----------------------------------------------------------------------------------------------
            /*
            Console.WriteLine("Please enter your name: ");
            string user = Console.ReadLine();

            while (name == "")
            {
                Console.WriteLine("Please enter your ACTUAL name: ");
                user = Console.ReadLine();
            }
            */

            // This is a better way to write that while loop as a "do while loop"
            string user = "";

            while (user == "")
            {
                Console.WriteLine("Please enter your name: ");
                user = Console.ReadLine();
            }

            Console.WriteLine("What's up " + user);


            // For Loops -------------------------------------------------------------------------------------------------

            // Count 1 to ten, odd #'s, just like C++
            for (int i = 1; i < 11; i += 2)
            {
                Console.WriteLine(i);
            }

            // Count backwards down from 20 to 0, ever multiple of 5
            for (int j = 20; j >= 0; j -= 5)
            {
                Console.WriteLine(j);
            }


            // Nested Loops ----------------------------------------------------------------------------------------------
            Console.WriteLine("How many rows?: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many columns?: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write("#");
                }
                Console.Write("\n");
            }
        }
    }
}