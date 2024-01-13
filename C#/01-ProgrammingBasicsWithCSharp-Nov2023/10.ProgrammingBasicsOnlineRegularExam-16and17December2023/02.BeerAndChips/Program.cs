using System;

namespace BeerAndChips
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            string name = Console.ReadLine();
            double budget = Convert.ToDouble(Console.ReadLine());
            double bottles = Convert.ToDouble(Console.ReadLine());
            double chips = Convert.ToDouble(Console.ReadLine());

            double bottlesPrice = bottles * 1.2;
            double chipsPrice = chips * (bottlesPrice * 45 / 100);
            double chipsPrice2 = Math.Ceiling(chipsPrice);
            chipsPrice = chipsPrice2;
            double priceLeft = Math.Abs(budget - chipsPrice - bottlesPrice);

            if (budget >= (bottlesPrice + chipsPrice))
            {
                Console.WriteLine($"{name} bought a snack and has {priceLeft:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"{name} needs {priceLeft:F2} more leva!");
            }
        }
    }
}