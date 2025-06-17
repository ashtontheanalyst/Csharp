using System;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = "John Doe";
            // Super similar to C++
            fullName.ToUpper();                         // fully upper
            fullName.ToLower();                         // fully lower
            fullName.ToUpperInvariant();                // title case
            fullName = fullName.Insert(0, "Mr. ");      // Insert Mr. at the index 0

            Console.WriteLine(fullName);
            Console.WriteLine(fullName.Length);         // Returns an int with the amount of chars in str

            string first = fullName.Substring(4, 4);    // Retrieves the first name from Mr. John Doe
            string last = fullName.Substring(9, 3);     // The last name

            Console.WriteLine(first);
            Console.WriteLine(last);

            string phone = "111-111-1111";
            phone = phone.Replace("-", " ");            // Replace the dashes with a space

            Console.WriteLine(phone);

            // String Interpolation ---------------------------------------------------------
            // This is the same conceptually as an f-string in Python, we just use $ instead of f
            // You can also use string functions within the {}s
            string team = "coWBoYs";
            string city = "DALLAS";
            string place = "laST";

            Console.Write($"Hopefully the {city.ToLower()} {team.ToUpper()} ");
            Console.Write($"won't be {place.ToLower()} this year!\n");
        }
    }
}