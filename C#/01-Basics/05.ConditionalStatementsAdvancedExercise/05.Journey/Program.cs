using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            double budget = Convert.ToDouble(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";

            if (budget <= 100)
            {
                destination = "Bulgaria";
            }
            else if (budget <= 1000 && budget > 100)
            {
                destination = "Balkans";
            }
            else if (budget > 1000)
            {
                destination = "Europe";
            }

            if (season == "summer")
            {
                switch (destination)
                {
                    case "Bulgaria":
                        budget *= 0.3;
                        Console.WriteLine("Somewhere in " + destination);
                        Console.WriteLine($"Camp - {budget:F2}"); break;
                    case "Balkans":
                        budget *= 0.4;
                        Console.WriteLine("Somewhere in " + destination);
                        Console.WriteLine($"Camp - {budget:F2}"); break;
                    case "Europe":
                        budget *= 0.9;
                        Console.WriteLine("Somewhere in " + destination);
                        Console.WriteLine($"Hotel - {budget:F2}"); break;
                }
            }
            else if (season == "winter")
            {
                switch (destination)
                {
                    case "Bulgaria":
                        budget *= 0.7;
                        Console.WriteLine("Somewhere in " + destination);
                        Console.WriteLine($"Hotel - {budget:F2}"); break;
                    case "Balkans":
                        budget *= 0.8;
                        Console.WriteLine("Somewhere in " + destination);
                        Console.WriteLine($"Hotel - {budget:F2}"); break;
                    case "Europe":
                        budget *= 0.9;
                        Console.WriteLine("Somewhere in " + destination);
                        Console.WriteLine($"Hotel - {budget:F2}"); break;
                }
            }

        }
    }
}