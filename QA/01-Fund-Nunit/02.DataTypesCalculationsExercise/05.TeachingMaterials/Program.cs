using System;

namespace TeachingMaterials
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method

            int pensCount = int.Parse(Console.ReadLine());
            int markersCount = int.Parse(Console.ReadLine());
            int boardCleanerLiters = int.Parse(Console.ReadLine());
            int discountPercentage = int.Parse(Console.ReadLine());

            double pensPrice = pensCount * 5.80;
            double markersPrice = markersCount * 7.20;
            double boardCleanerPrice = boardCleanerLiters * 1.20;

            double totalCost = pensPrice + markersPrice + boardCleanerPrice;
            double discountAmount = totalCost * (discountPercentage / 100.0);
            double finalPrice = totalCost - discountAmount;

            Console.WriteLine(finalPrice);
        }
    }
}

