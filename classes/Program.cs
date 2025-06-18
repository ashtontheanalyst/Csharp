// Classes are a bundle of related code and/or functions, great for OOP
// See values.cs for an example of a class outside of the main program doc
using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a function from our CoolValues.cs file holding that class
            CoolValues.MilestoMoon();

            // This is from the messages class in our own file
            Messages.Hello();
            Messages.Waiting();

            // Objects -------------------------------------------------------------------
            // These are instances of a class, have access to methods and values within (OOP)
            // The fields are the values and methods are the functions
            Human human1 = new Human("James", 40);     // create the new object with arguments

            human1.Age();
            human1.Sleep();

            // Second instance of the Human class we made
            Human human2 = new Human("Toby", 349);
            human2.Age();
            human2.Sleep();

            // using our static value and method in the Human class
            Console.WriteLine($"There are {Human.numberOfPeople} people in the Human class currently");
            Human.Amount();

            // Same thing but new class using Cars.cs
            Car fordMustang = new Car("Ford", "Mustang", 2019, "Black");
            fordMustang.Description();
            fordMustang.TestDrive();
        }
    }

    // Creating our own class within the same program
    // public makes the method accessable, static means we don't need to initialize a class object
    class Messages
    {
        public static void Hello()
        {
            Console.WriteLine("Hello! Welcome to my message program...");
        }
        public static void Waiting()
        {
            Console.WriteLine("Waiting on something...I don't remember what.");
        }
    }

    // For now everything is 'public' for ease of modifying but it's not best practice
    class Human
    {
        public string name;
        public int age;
        // Since this is static, the Human class owns it, not just the instance
        // So if I make two human objects, this value will be two, not one and one for each object
        // Think of it like a shared value within the class as a whole
        public static int numberOfPeople;

        // Constructor, this is the first function called when making the object
        // it helps build out the instance
        public Human(string name, int age)
        {
            this.name = name;
            this.age = age;
            numberOfPeople++;
        }

        public void Age()
        {
            Console.WriteLine(name + " is " + age + " years old!");
        }
        public void Sleep()
        {
            Console.WriteLine(name + " is going to sleep..");
        }

        // This is a method invoked by the CLASS not a specific INSTANCE
        public static void Amount()
        {
            Console.WriteLine($"There are {Human.numberOfPeople} people");
        }
    }
}