using System;

namespace classes 
{
    // Using static makes it to where you don't necessarily have to make a Values object
    // back in the main program to use the functions
    static class CoolValues
    {
        // Putting public in front of these makes them visible to outside programming
        public static void Pi()
        {
            Console.WriteLine("The value of Pi is 3.14159....");
        }
        public static void MilestoMoon()
        {
            Console.WriteLine("From the Earth to our Moon is ~240,000 miles!");
        }
    }
}