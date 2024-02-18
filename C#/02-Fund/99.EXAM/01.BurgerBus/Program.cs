using System;

public class BurgerBus
{
    public static void Main(string[] args)
    {
        int numCities = int.Parse(Console.ReadLine());

        double totalProfit = 0;
        double profit = 0;

        for (int i = 1; i <= numCities; i++)
        {
            string cityName = Console.ReadLine();
            double income = double.Parse(Console.ReadLine());
            double expenses = double.Parse(Console.ReadLine());

            profit = income;

            if (i % 3 == 0 && i % 5 != 0)
            {
                expenses *= 1.5; // Special event
            }
            else if (i % 5 == 0)
            {
                profit *= 0.9; // Raining
            }

            profit -= expenses;
            totalProfit += profit;

            Console.WriteLine($"In {cityName} Burger Bus earned {profit:0.00} leva.");
        }

        Console.WriteLine($"Burger Bus total profit: {totalProfit:0.00} leva.");
    }
}
