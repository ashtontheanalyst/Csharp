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
            Random random = new Random();       // This generates a random number object

            int num = random.Next(1, 7);        // Rolling a dice, random number 1-6

            Console.WriteLine(num);
        }
    }
}
