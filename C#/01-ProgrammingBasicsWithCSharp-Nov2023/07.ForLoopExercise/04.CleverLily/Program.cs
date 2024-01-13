using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] _)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            double age = Convert.ToDouble(Console.ReadLine());
            double price = Convert.ToDouble(Console.ReadLine());
            double priceDoll = Convert.ToDouble(Console.ReadLine());
            double moneyTotal = 0;
            double moneyGift = 0;
            double dolls = 0;

            for (int i = 0; i < age; i++)
            {
                if (i % 2 == 1)
                {
                    moneyGift += 10;
                    moneyTotal += moneyGift;
                    moneyTotal--;
                }
                else
                {
                    dolls++;
                    moneyTotal += priceDoll;
                }
            }

            if (price <= moneyTotal)
            {
                moneyTotal = Math.Abs(moneyTotal - price);
                Console.WriteLine($"Yes! {moneyTotal:F2}");
            }
            else
            {
                moneyTotal = Math.Abs(moneyTotal - price);
                Console.WriteLine($"No! {moneyTotal:F2}");
            }

        }
    }
}