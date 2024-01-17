using System;
using System.Data.SqlTypes;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            int budget = Convert.ToInt32(Console.ReadLine());
            string season = Console.ReadLine();
            int ppl = Convert.ToInt32(Console.ReadLine());
            double price = 0;
            double money = 0;

            if (season == "Spring")
            {
                price = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                price = 4200;
            }
            else if (season == "Winter")
            {
                price = 2600;        
            }

            if (ppl <= 6)
            {
                price *= 0.9;
            }
            else if (ppl > 6 && ppl <= 11)
            {
                price *= 0.85;
            }
            else if (ppl > 11)
            {
                price *= 0.75;
            }

            if (ppl % 2 == 0 && season != "Autumn")
            {
                price *= 0.95;
            }

            

            if (budget >= price)
            {
                money = budget - price;
                Console.WriteLine($"Yes! You have {money:F2} leva left.");
            }
            else if (budget < price)
            {
                money = price - budget;
                Console.WriteLine($"Not enough money! You need {money:F2} leva.");
            }

        }
    }
}