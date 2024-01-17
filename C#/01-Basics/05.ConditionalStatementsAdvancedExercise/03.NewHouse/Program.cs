using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            string type = Console.ReadLine();
            int amount = Convert.ToInt32(Console.ReadLine());
            int budget = Convert.ToInt32(Console.ReadLine());

            double total = 0;

            switch (type)
            {
                case "Roses":
                    total = amount * 5;
                    break;
                case "Dahlias":
                    total = amount * 3.8;
                    break;
                case "Tulips":
                    total = amount * 2.8;
                    break;
                case "Narcissus":
                    total = amount * 3;
                    break;
                case "Gladiolus":
                    total = amount * 2.5;
                    break;
            }



            if (type == "Roses" && amount > 80)
            {
                total *= 0.9;
            }
            else if (type == "Dahlias" && amount > 90)
            {
                total *= 0.85;
            }
            else if (type == "Tulips" && amount > 80)
            {
                total *= 0.85;
            }
            else if (type == "Narcissus" && amount < 120)
            {
                total *= 1.15;
            }
            else if (type == "Gladiolus" && amount < 80)
            {
                total *= 1.2;
            }

            if (budget >= total)
            {
                double money = budget - total;
                Console.WriteLine("Hey, you have a great garden with " + amount + " " + type + $" and {money:F2} leva left.");
            }
            else
            {
                double money = total - budget;
                Console.WriteLine($"Not enough money, you need {money:F2} leva more.");
            }
        }
    }
}