// Methods are the C# version of functions in C++

using System;

namespace methods 
{
    class Program
    {
        static void Main(string[] args)
        {
            // Methods ----------------------------------------------------------------------
            // Invoking the happyBDay method we made, in the main function
            // We can invoke this method as many times as we like
            happyBDay();
            happyBDay();

            // Same thing but adding an argument
            string name = "Dementus";
            happyBDayRef(name);

            // Multiple arguments
            int age = 20;
            happyBDayMul(name, age);


            // Return for Methods -----------------------------------------------------------
            double first = 2.343;
            double second = 923.91223;
            double third = multiply(first, second);
            Console.WriteLine(third + " is the product of " + first + " and " + second);


            // Method Overloading -----------------------------------------------------------
            // This is when you have methods of the same name, but each with a different amount
            // of data types, or different types
            double fourth = 12.422;
            double fifth = 23.13;
            Console.WriteLine(multiply(first, second, fourth));
            Console.WriteLine(multiply(first, second, fourth, fifth));


            // Params for Method Arguments --------------------------------------------------
            // Allows a method to take in as many arguments as you want because they become
            // a array parameter
            Console.WriteLine("Your total is: " + CheckOut(1.2));
            Console.WriteLine("Your total is: " + CheckOut(1.2, 23.23));
            Console.WriteLine("Your total is: " + CheckOut(1.2, 94.233, 8173));
            Console.WriteLine("Your total is: " + CheckOut(1.2, 11.1, 3445.2, 94.92, 5.5));


            // Exceptions -------------------------------------------------------------------
            // Catching errors in a method or piece of code before it ruins the program
            Dividing();
        }

        // This is a new method, think of it like a function in C++
        static void happyBDay()
        {
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday dear YOUUUUUUUU!");
            Console.WriteLine("Happy birthday to you!\n");
        }

        // Similar to the happyBDay method but with a parameter
        // The argument is "name" which is passed to the method and becomes param. "birthdayPerson"
        static void happyBDayRef(string birthdayPerson)
        {
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday dear " + birthdayPerson + "!!!");
            Console.WriteLine("Happy birthday to you!\n");
        }

        // Method with multiple arguments/params
        static void happyBDayMul(string birthdayPerson, int age)
        {
            Console.Write("Happy birthday " + birthdayPerson + ", you're now ");
            Console.Write(age + " years old\n");
        }

        // Method that returns a value back to main
        // You change 'static void' to 'static {data type to be returned}' 
        static double multiply(double x, double y)
        {
            return x * y;
        }

        // This is method overloading, it's the multiple method but with different amounts of nums
        static double multiply(double x, double y, double z)
        {
            return x * y * z;
        }
        static double multiply(double x, double y, double z, double w)
        {
            return x * y * z * w;
        }

        // Using the param keyword for arguments, turns the passed arguments into an array
        static double CheckOut(params double[] prices)
        {
            double total = 0;

            // Add up the total value of each price (argument)
            foreach (double price in prices)
            {
                total += price;
            }

            return total;
        }

        // This is the method with exception handling
        static void Dividing()
        {
            double a;
            double b;
            double result;

            try
            {
                Console.Write("Enter the first value: ");
                a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the first value: ");
                b = Convert.ToDouble(Console.ReadLine());

                result = a / b;

                Console.WriteLine(a + " / " + b + " = " + result);
            }
            catch (FormatException e) {
                Console.WriteLine("ERROR: Input was not proper");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("ERROR: You can't divide by 0!!");
            }
            // This code runs no matter if there's an exception or not, it's also optional
            finally
            {
                Console.WriteLine("Thanks for dividing!");
            }
        }
    }
}