// Basic arithmetic
// Using the Math class
// Random Numbers
using System;

namespace math
{
    class Program
    {
        static void Main(string[] args)
        {
            // Same as C++
            int friends = 2;
            friends += 3;
            friends -= 1;
            friends--;
            friends *= 2;
            friends /= 2;

            // Dividing to get a decimal
            int i = 10;
            i /= 3;         // Won't show the decimal
            double j = 10;
            j /= 3;         // Now it does since it's a double

            // Remainder (modulous)
            int z = 3;
            int remainder = z % 2;  // Returns one since 3/2 is 1 (check for odd num)

            // Math Function -----------------------------------------------------------------------
            double x = 3;
            double a = Math.Pow(x, 2);
            double b = Math.Sqrt(144);
            double c = Math.Abs(-3);
            double d = Math.Round(3.14);    // Rounds to correct direction
            double e = Math.Ceiling(3.14);  // Rounds up ALWAYS
            double f = Math.Floor(3.14);    // Round down ALWAYS
            double g = Math.Max(5, 20);
            g = Math.Min(5, 20);

            Console.WriteLine(friends);
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(remainder);
            Console.WriteLine(a);

            // Random Numbers ----------------------------------------------------------------------
            // Generates an object from the random class, this allows us to use it's inner funcitons
            Random random = new Random();

            int num = random.Next(1, 7);         // Function from the random class, returns a rand int
            double some = random.NextDouble();   // Random double between 0.00 and 1.00

            Console.WriteLine(num);
            Console.WriteLine(some);

            // Triangle Hypotenuse -------------------------------------------------------------------
            Console.WriteLine("Enter the first side of the triangle: ");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second side of the triangle: ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            double hypo = Math.Sqrt((Math.Pow(side1, 2)) + (Math.Pow(side2, 2)));
            Console.WriteLine("The hypotenuse is " + hypo + "cm^2");
        }
    }
}
