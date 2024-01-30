using System;

namespace SummerClothing
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method

            int temperature = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();

            string clothing = "";
            string shoes = "";

            if (temperature >= 10 && temperature <= 18)
            {
                clothing = "Sweatshirt";
                shoes = "Sneakers";
            }
            else if (temperature > 18 && temperature <= 24)
            {
                clothing = "Shirt";
                shoes = "Moccasins";
            }
            else if (temperature >= 25)
            {
                clothing = "T-Shirt";
                shoes = "Sandals";
            }

            Console.WriteLine($"It's {temperature} degrees, get your {clothing} and {shoes}.");
        }
    }
}