using System;

namespace classes 
{
    class Car
    {
        string make;
        string model;
        int year;
        string color;

        // Constructor
        public Car(string make, string model, int year, string color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }

        public void Description()
        {
            Console.WriteLine($"This {year} {make} {model} is shiny {color}!!");
        }
        public void TestDrive()
        {
            Console.WriteLine($"Wanna' take the {make} {model} for a spin?");
        }
    }
}