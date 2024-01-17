using System;

namespace GoldMine
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            int numberOfLocations = Convert.ToInt32(Console.ReadLine());
            double minedTotal = 0;
            double averageGoldPerDay = 0;
            double goldNeeded = 0;
            double expectedAverageGold = 0;
            double days = 0;

            for (int i = 0; i < numberOfLocations; i++)
            {
                expectedAverageGold = Convert.ToDouble(Console.ReadLine());
                days = Convert.ToDouble(Console.ReadLine());
                minedTotal = 0;

                for (int j = 0; j < days; j++)
                {
                    minedTotal += Convert.ToDouble(Console.ReadLine());
                }

                if (minedTotal >= (days * expectedAverageGold))
                {
                    averageGoldPerDay = minedTotal / days;
                    goldNeeded = Math.Abs((minedTotal / days) - expectedAverageGold);
                    Console.WriteLine($"Good job! Average gold per day: {averageGoldPerDay:F2}.");
                }
                else
                {
                    averageGoldPerDay = minedTotal / days;
                    goldNeeded = Math.Abs((minedTotal / days) - expectedAverageGold);
                    Console.WriteLine($"You need {goldNeeded:F2} gold.");
                }
            }
        }
    }
}