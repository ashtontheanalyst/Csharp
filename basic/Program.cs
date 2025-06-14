﻿// First we start with basic output and formatting
// Then we get into basic variables and use cases
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

            Console.ReadKey();                  // Keeps the program alive till key stroke
        }
    }
}