using System;

namespace GodzillavsKong
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            double budget = Convert.ToDouble(Console.ReadLine());
            double ppl = Convert.ToDouble(Console.ReadLine());
            double cost = Convert.ToDouble(Console.ReadLine());


            if (ppl > 150)
            {
                cost = cost * 0.9;
            }

            double sumDecore = budget * 0.1;
            double sumClothes = ppl * cost;
            double sumMovie = sumClothes + sumDecore;

            if (budget >= sumMovie)
            {
                double action = budget - sumMovie;
                string formattedNumber = action.ToString("0.00");

                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {formattedNumber} leva left.");
            }
            else
            {
                double notEnoughMoney = sumMovie - budget;
                string formattedNumber = notEnoughMoney.ToString("0.00");

                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {formattedNumber} leva more.");
            }

        }
    }
}