using System;

namespace SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            int deg = Convert.ToInt32(Console.ReadLine());
            string time = Console.ReadLine();

            if (deg >= 10 && deg <= 18)
            {
                switch (time)
                {
                    case "Morning":
                        Console.WriteLine("It's " + deg + " degrees, get your Sweatshirt and Sneakers.");
                        break;
                    case "Afternoon":
                        Console.WriteLine("It's " + deg + " degrees, get your Shirt and Moccasins.");
                        break;
                    case "Evening":
                        Console.WriteLine("It's " + deg + " degrees, get your Shirt and Moccasins.");
                        break;
                }
            }
            else if (deg > 18 &&  deg <= 24)
            {
                switch (time)
                {
                    case "Morning":
                        Console.WriteLine("It's " + deg + " degrees, get your Shirt and Moccasins.");
                        break;
                    case "Afternoon":
                        Console.WriteLine("It's " + deg + " degrees, get your T-Shirt and Sandals.");
                        break;
                    case "Evening":
                        Console.WriteLine("It's " + deg + " degrees, get your Shirt and Moccasins.");
                        break;
                }
            }
            else if ( deg > 24)
            {
                switch (time)
                {
                    case "Morning":
                        Console.WriteLine("It's " + deg + " degrees, get your T-Shirt and Sandals.");
                        break;
                    case "Afternoon":
                        Console.WriteLine("It's " + deg + " degrees, get your Swim Suit and Barefoot.");
                        break;
                    case "Evening":
                        Console.WriteLine("It's " + deg + " degrees, get your Shirt and Moccasins.");
                        break;
                }
            }
        }
    }
}