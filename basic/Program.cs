﻿// First we start with basic output and formatting
// Then we get into basic variables and use cases
// Typecasting and user input towards the bottom
using System;

namespace basic
{
    class Program
    {
        // Think of this as the main function, it's where the program begins
        static void Main(string[] args)
        {
            // Body of the main method
            // Output/formatting ---------------------------------------------------
            Console.WriteLine("Hello C#");      // Writes the string and a newline
            Console.Write("Example");           // Just writes the string
            Console.Write("\nHello Again\n");   // Effectively same as WriteLine()
            Console.WriteLine("\tTAB");         // We still have escape sequences


            // Variables -----------------------------------------------------------
            // Same as dec and init in C++
            int x;
            x = 10;
            int y = 20;
            int z = x + y;

            int age = 36;
            Console.WriteLine("You are " + age + " years old!");

            double height = 182.34;
            Console.WriteLine("You are " + height + "cm tall");

            bool alive = true;
            Console.WriteLine("Are you alive? " + alive);

            char gradePoint = 'B';
            Console.WriteLine("Your GPA is a " + gradePoint);

            string movie = "Forrest Gump";
            Console.WriteLine(movie + " is your favorite movie? Great taste!");

            char symbol = '#';
            string user = "John";
            Console.WriteLine("Your username is: " + symbol + user + symbol);


            // Constants, var's that don't change during runtime
            const double pi = 3.14159;
            Console.WriteLine("Pi (" + pi + ") cannot be changed!");


            // Type Casting --------------------------------------------------------
            double a = 7.1394;
            int b = Convert.ToInt32(a);
            Console.WriteLine(a + " is now b: " + b);

            int c = 123;
            //double d = Convert.ToDouble(c);    // Won't show the decimals at first
            double d = Convert.ToDouble(c) + 0.01;
            Console.WriteLine(c + " is now d: " + d);

            Console.WriteLine(b.GetType());     // Shows us the data type of the val


            // User Input ----------------------------------------------------------
            Console.WriteLine("Tell me your favorite sport: ");
            string sport = Console.ReadLine();

            // Readline() has to be read in as a string and then we can type cast
            // for any other vars
            Console.WriteLine("Tell me your weight: ");
            int weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(sport + " is my favorite sport too!");
            Console.WriteLine("So you're " + weight + "lbs.?");


            // Arrays ---------------------------------------------------------------
            // These have a fixed size, they can't change later
            string[] cars = { "Civic", "Acura", "Mustang" };

            Console.WriteLine(cars[0]);                 // Get each indexed value in str array
            cars[1] = "Tesla";                          // Change a value

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            // Array with declared size
            Console.Write("Enter the amount of values in the array: ");
            int count = Convert.ToInt32(Console.ReadLine());
            string[] bangs = new string[count];

            for (int i = 0; i < bangs.Length; i++)
            {
                bangs[i] = "!";
            }
            for (int i = 0; i < bangs.Length; i++)
            {
                Console.Write(bangs[i]);
            }
            Console.WriteLine("");

            // Foreach loop lets you do a simplified for loop to it over each value in order
            foreach (string bang in bangs)
            {
                Console.Write(bang);
            }
            Console.WriteLine("");
        }
    }
}