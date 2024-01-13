using System;

namespace FinalCompetition
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            double dancers = Convert.ToDouble(Console.ReadLine());
            double points = Convert.ToDouble(Console.ReadLine());
            string season = Console.ReadLine();
            string place = Console.ReadLine();
            double money = 0;
            double charity = 0;

            if (place == "Bulgaria")
            {
                money = points * dancers;
                
                switch (season)
                {
                    case "summer":
                        money *= 0.95;
                        break;

                    case "winter":
                        money *= 0.92;
                        break;
                }
            }

            else if (place == "Abroad")
            {
                money = points * dancers * 1.5;

                switch (season)
                {
                    case "summer":
                        money *= 0.9;
                        break;

                    case "winter":
                        money *= 0.85;
                        break;
                }
            }

            charity = money * 0.25;
            money -= charity;
            money /= dancers;

            Console.WriteLine($"Charity - {charity:F2}");
            Console.WriteLine($"Money per dancer - {money:F2}");
        }
    }
}