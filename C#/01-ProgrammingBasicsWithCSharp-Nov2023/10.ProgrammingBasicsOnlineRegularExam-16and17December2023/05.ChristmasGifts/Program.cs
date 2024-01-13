using System;

namespace ChristmasGifts
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            string input = Console.ReadLine();
            int age = 0;
            int adults = 0;
            int kids = 0;
            int toys = 0;
            int sweaters = 0;

            while (input != "Christmas")
            {
                age = Convert.ToInt32(input);
                input = Console.ReadLine();

                if (age <= 16)
                {
                    kids++;
                    toys += 5;
                }
                else
                {
                    adults++;
                    sweaters += 15;
                }
            }

            Console.WriteLine($"Number of adults: {adults}");
            Console.WriteLine($"Number of kids: {kids}");
            Console.WriteLine($"Money for toys: {toys}");
            Console.WriteLine($"Money for sweaters: {sweaters}");
        }
    }
}